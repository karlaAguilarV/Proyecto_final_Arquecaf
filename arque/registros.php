<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Registros</title>
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
					<a href="pedidos.php">
						<div class="icon"><img src="icons/pedidos.png" alt=" "></div>
						<div class="title"><span>Pedidos</span></div>
					</a>
				</div>
				
				<div class="item separator"> 
				</div>
				<div class="item">
					<a href="quienesomos.html">
						<div class="icon"><img src="icons/quienes.png" alt=" "></div>
						<div class="title"><span>Quienes somos</span></div>
					</a>
				</div>
				<div class="item">
					<a href="home.php">
						<div class="icon"><img src="icons/salida.png" alt=" "></div>
						<div class="title"><span>Salir</span></div>
					</a>
				</div>
			</div>
	</div>	
	<form class="formulario" action="guardarcliente.php" method="post">
                    
                    <h1>Registrate</h1>
                    <div class="contenedor">

							<div>
								<label for="name"><b>Nombre completo</b></label>
								<div class="input-contenedor">
								<i class="fas fa-user icon"></i>
								<input type="text"  name="name" required>
							</div>
							
								</div>
									<label for="uname"><b>Teléfono</b></label>
									<div class="input-contenedor">
									<i class="fas fa-envelope icon"></i>
									<input type="text" name="telefono" required>
								</div>
							<input type="submit" value="Registrate" class="button">
							<p>¿Ya tienes una cuenta?<a class="link" href="login.php">Iniciar Sesion</a></p>
                    </div>
     </form>
	
</body>
</html>