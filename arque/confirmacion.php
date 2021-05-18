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
	<title>Quienes Somos</title>
	<link rel="stylesheet" href="css/sty.css">
</head>
<body>
	
	<div id="sidemenu"  class="menu-collapsed">
		<!--cabecera-->
		<div id="header">
			<div id="title">  ArqueCaf </div>
			
			
		</div>
		<!--perfil-->
		<div id="profile" >
			<div id="photo"><img src="icons/c.gif" alt=""> </div>
			<?php
				if($loginSession<>'')
				{
					?>
					
					<div id="name"><span>usuario:<?php echo $loginSession; ?> </span>
					</div>
				
				<?php
				}
				?>
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
	<div class="who">
		<h1> <center>Felicidades</center></h1>
		<p>Tu pedido ha sido solicitado</p>
        <center> <img src="icons/cafe.jpg" width="486px" alt=""> </center>
		
	</div>
	
</body>
</html>