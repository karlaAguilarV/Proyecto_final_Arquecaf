<?php
    // require 'conexion.php';

     $nombre=$_POST['name'];
     $usuario=$_POST['telefono'];

     include_once 'conexion.php';
    $mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
    $sqlQuerys="INSERT INTO clientes(Nombre,Telefono)VALUES('$nombre','$usuario')";  
    echo $sqlQuerys;
    if( $resultado=$mysqlConexion->query($sqlQuerys))
    {
        header("Location:confirmacion.php");
    }
    else
    {
        echo $resultado;  
    }

?>
 