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
	<title>Productos</title>
	<link rel="stylesheet" href="css/style.css">
	<link rel="stylesheet" href="css/sty.css">

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
	<div class="prod">
	<img src="icons/arquetipo.jpeg" width="286px" alt="">
	    
		<p><ln>¿Por qué "altura"?
			Porque a gran altitud, a la planta le cuesta más trabajo crecer y así la maduración se prolonga. 
			Esto le da más tiempo a la fruta de crear los azúcares y sabores suculentos que hacen una gran taza de café.</ln></p>
			<input type="button" value="$139.00" class="precio">
	</div>
		<div class="prod">
				<img src="icons/pcafe.jpg" width="286px"  alt="">
				<p>Los Árboles son enanos, llegan a medir hasta 2 metros, los puedes
					tener en tierra o macetas simprolemas,
				SON 100% ORGANICOS	</p>
				<input type="button" value="$396.00" class="precio">
		</div>
	
</body>
</html>