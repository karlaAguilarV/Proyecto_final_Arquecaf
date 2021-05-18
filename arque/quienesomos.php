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
		<h1> <center>¿Quiénes Somos?</center></h1>
		<p>Somos una empresa que se dedica a la venta de bolsas de café, así como también a la cosecha de la misma. Nosotros ofrecemos café 100% y estamos ubicados en el libramiento sur, oriente kilometro 115</p>
		<h2><center>Acerca de</center></h1>
			<p>Somos una empresa que se dedica a la venta de bolsas de café, así como también a la cosecha de la misma. Nosotros ofrecemos café 100% puro para que puedas disfrutarlo en tus mañanas o en tus momentos de relajación, recuerda </p>
				<p>“La calidad y la profesionalidad nos distingue”.</p>
			<h2><center>Misión </center></h2>
			<p>Satisfacer al cliente con la excelente elaboración de café 100% puro de alta calidad que aumentara su gusto de la misma.</p>
			<h2><center>Visión</center></h2>
			<p>Satisfaciendo las necesidades de nuestros clientes y ser reconocidos por el mercado tanto municipal y estatal; ofrecemos profesionalismo, integridad, superando las expectativas del cliente.</p>
	</div>
	
</body>
</html>