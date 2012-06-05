<?php

$uploaddir = 'archivos/'; // Relative Upload Location of data file

if (is_uploaded_file($_FILES['file']['tmp_name'])) {


$uploadfile = $uploaddir . basename($_FILES['file']['name']);

//echo "El archivo ". $_FILES['file']['name'] ." fue cargado exitosamente!";

if (move_uploaded_file($_FILES['file']['tmp_name'], $uploadfile)) {

echo "El archivo ". $_FILES['file']['name'] ." fue cargado exitosamente!";

}

else

print_r($_FILES);

}

else {

echo "Subida de archivo fallida.";

print_r($_FILES);

}

?>