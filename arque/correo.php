<?php 
use  PHPMailer\PHPMailer\PHPMailer;
use  PHPMailer\PHPMailer\Exception;

require  'Phpmailer/Exception.php' ;
require  'Phpmailer/PHPMailer.php' ;
require  'Phpmailer/SMTP.php' ;

$cnombre=$_POST['name'];
$ctelefono=$_POST['telefono'];

$ccorreo=$_POST['correo'];
$cpedido=$_POST['pedido'];
$ccantidad=$_POST['cantidad']



// La instanciación y el paso de `true` habilita excepciones 
$mail = new  PHPMailer ( true );

try {
    $mail->SMTPOptions = array(
		'ssl' => array(
		'verify_peer' => false,
		'verify_peer_name' => false,
		'allow_self_signed' => true
		)
	);
     // Configuración del servidor 
    $mail->SMTPDebug = 0;                      // Habilita la salida de depuración detallada 
    $mail -> isSMTP ();                                            // Enviar usando SMTP 
    $mail -> Host        = 'smtp.gmail.com' ;                    // Configure el servidor SMTP para enviar a través de 
    $mail -> SMTPAuth    = true ;                                   // Habilita la autenticación SMTP 
    $mail -> Username    = 'djuridico89@gmail.com' ;                     // Nombre 
    $mail -> Password    = 'registroc1' ;                               // Contraseña SMTP 
    $mail -> SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;         // Habilite el cifrado TLS; `PHPMailer :: ENCRYPTION_SMTPS` alentó 
    $mail -> Port        = 587 ;                                    // Puerto TCP para conectarse, use 465 para `PHPMailer :: ENCRYPTION_SMTPS` arriba

    // Destinatarios 
    $mail -> setFrom ( 'djuridico89@gmail.com' , 'Caficultora Arquetipo' );
    $mail -> addAddress ($ccorreo,$cnombre);    // Agregar un destinatario 

    // Archivos adjuntos 
    //$ mail -> addAttachment ( '/var/tmp/file.tar.gz' );         // Agregar archivos adjuntos 
    //$ mail -> addAttachment ( '/tmp/image.jpg' , 'new.jpg' );    // Nombre opcional

    // Contenido 
    $mail -> isHTML (true);                                  // Establecer el formato de correo electrónico en HTML 
    $mail -> Subject = 'Confirmacion de Pedido' ;
    $mail -> Body     = ('<b>Datos del pedido:</b> '.$cnombre .$ctelefono .$cpedido .$ccantidad);
    //$ mail -> AltBody = 'Este es el cuerpo en texto plano para clientes de correo que no son HTML' ;

    $mail -> send();
    include("confirmacion.php");
    echo  'Mensaje enviado correctamente';
} catch ( Exception  $e ) {
     echo  "No se pudo enviar el mensaje. Error de correo: {$mail-> ErrorInfo}";
}
     //echo $v1['valor1']
