<?php
$usuario=$_POST['uname'];
$password=$_POST['psw'];
include_once 'conexion.php';
$mysqlConexion=new mysqli($hostDb,$usuarioDb,$claveDb,$nombreDb);
$sqlQuery="SELECT * FROM usuarios WHERE User='".$usuario."'";
$resultado=$mysqlConexion->query($sqlQuery);
if($row = $resultado->fetch_array(MYSQLI_ASSOC))
{
    if($row['Password'] == $password){
        session_start();
        $_SESSION['usuarios'] = $usuario;
        header("Location: pedidos.php");
    }else{
        header("Location: login.php");
        exit();
    }
}else{
    header("Location: login.php");
    exit();
}

?>