Imports AForge.Controls
Imports AForge.Video.DirectShow
Imports System.Drawing.Imaging

Public Class Webcam

    ' Count avaiable webcams
    Public Function CountWebcamDevices() As Integer
        Dim VideoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        Dim DeviceCount As Integer = 0
        For Each MySingleDevice In VideoDevices
            DeviceCount += 1
        Next
        Return DeviceCount
    End Function

    ' Get Webcam device names
    Public Function GetWebcamDeviceNames() As String
        Dim VideoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        Dim Devices As String = Nothing
        If Not CountWebcamDevices() = 0 Then
            For Each MySingleDevice As FilterInfo In VideoDevices
                Devices &= MySingleDevice.Name & "|||"
            Next
            Return Devices
        Else
            Return Nothing
        End If
    End Function

    ' Take a webcam snapshot
    Public Function TakeWebcamSnapshot(ByVal DeviceID As Integer) As String
        Dim TimeoutCoutner As New Stopwatch
        TimeoutCoutner.Start()
        Dim VideoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
        Using VideoSourcePlayer As New VideoSourcePlayer
            VideoSourcePlayer.VideoSource = New VideoCaptureDevice(VideoDevices(DeviceID).MonikerString)
            VideoSourcePlayer.Start()
            Dim myimg As Image = Nothing
            Do While VideoSourcePlayer.IsRunning AndAlso myimg Is Nothing
                If TimeoutCoutner.ElapsedMilliseconds > 7000 Then
                    Return String.Empty
                Else
                    myimg = VideoSourcePlayer.GetCurrentVideoFrame()
                End If
            Loop
            Dim webcambytes As String = ModuleMain.ScreenshotToHex(myimg)
            TimeoutCoutner.Stop()
            If VideoSourcePlayer.IsRunning = True Then
                VideoSourcePlayer.SignalToStop()
                VideoSourcePlayer.WaitForStop()
            End If
            Return webcambytes
        End Using
    End Function


End Class
