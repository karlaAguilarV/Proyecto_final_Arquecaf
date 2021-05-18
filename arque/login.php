<?php
session_start();
if (isset($_SESSION['usuarios'])){ 
		$loginSession=$_SESSION['usuarios'];
	} 
	else{
		$loginSession="";
	}
?>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>home</title>
	<link rel="stylesheet" href="css/style.css">
</head>
<body>
	<div id="sidemenu"  class="menu-collapsed" >
		<!--cabecera-->
		<div id="header">
			<div id="title">ArqueCaf</div>
			
			
		</div>
		<!--perfil-->
		<div id="profile" >
			<div id="photo"><img src="icons/c.gif" alt=""> </div>
			<div id="name"><span>usuario </span>
			</div>
		</div>
		<!--item-->
			<div id="menu-items">
				<div class="item">
					<a href="home.php">
						<div class="icon"><img src="icons/casa.png" alt=" "></div>
						<div class="title"><span>Inicio</span></div>
					</a>
				</div>
				<div class="item">
					<a href="login.php">
						<div class="icon"><img src="icons/usuario.png" alt=" "></div>
						<div class="title"><span>Usuarios</span></div>
					</a>
				</div>
				<div class="item">
					<a href="productos.php">
						<div class="icon"><img src="icons/productos.png" alt=" "></div>
						<div class="title"><span>Productos</span></div>
					</a>
				</div>
				<div class="item">
					<?php
							if($loginSession<>'')
							{
								?>
								<a href="pedidos.php">
								<div class="icon"><img src="icons/pedidos.png" alt=" "></div>
								<div class="title"><span>Pedidos</span></div>
							    </a>
								<?php
							}
							?>
				</div>
				
				<div class="item separator"> 
				</div>
				<div class="item">
					<a href="quienesomos.php">
						<div class="icon"><img src="icons/quienes.png" alt=" "></div>
						<div class="title"><span>Quienes somos</span></div>
					</a>
				</div>
				<div class="item">
					<a href="cerrarSesion.php">
						<div class="icon"><img src="icons/salida.png" alt=" "></div>
						<div class="title"><span>Salir</span></div>
					</a>
				</div>
			</div>
	</div>
    <form class="formulario" action="validar.php" method="post">

        <h1 class=h1>Login</h1>
     <div class="contenedor">
     
     
       <label for="uname"><b>usuario</b></label>
         <div class="input-contenedor">
         <i class="fas fa-envelope icon"></i>
         <input type="text" placeholder="Nombre" name="uname" required>
         
         </div>
         <label for="psw"><b>contraseña</b></label>
         <div class="input-contenedor">
        <i class="fas fa-key icon"></i>
         <input type="password" placeholder="Contraseña" name="psw"  required>
         
         </div>
         <input type="submit" value="Login" class="button">
        
         <p>¿No tienes una cuenta? <a class="link" href="registros.php">Registrate </a></p>
         </div>
        </form>	
</body>
</html>