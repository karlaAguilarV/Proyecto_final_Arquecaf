using System;

namespace ArqueCaf
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int Rol { get; set; }

        public Usuarios() { }

        public Usuarios(int pId, string pUsuario, string pContrasena, int pRol)
        {
            this.ID = pId;
            this.Usuario = pUsuario;
            this.Contrasena = pContrasena;
            this.Rol = pRol;
        }
    }


    public class Empleados
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Empleados() { }

        public Empleados(int pId, string pNombre, string pRFC, string pTelefono, string pDireccion)
        {
            this.ID = pId;
            this.Nombre = pNombre;
            this.RFC = pRFC;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
        }
    }

    public class Clientes
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Clientes() { }

        public Clientes(int pId, string pNombre, string pTelefono)
        {
            this.ID = pId;
            this.Nombre = pNombre;
            this.Telefono = pTelefono;
        }
    }

    public class Productos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Disponible { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }

        public Productos() { }

        public Productos(int pId, string pNombre, float pPrecio, int pDisponible, int pMinimo, int pMaximo)
        {
            this.ID = pId;
            this.Nombre = pNombre;
            this.Precio = pPrecio;
            this.Disponible = pDisponible;
            this.Minimo = pMinimo;
            this.Maximo = pMaximo;
        }
    }

    public class Pedidos
    {
        public int ID { get; set; }
        public int Cliente { get; set; }
        public int Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public float Total { get; set; }

        public Pedidos() { }

        public Pedidos(int pId, int pCliente, int pEmpleado, DateTime pFecha, string pHora, float pTotal)
        {
            this.ID = pId;
            this.Cliente = pCliente;
            this.Empleado = pEmpleado;
            this.Fecha = pFecha;
            this.Hora = pHora;
            this.Total = pTotal;
        }
    }

    public class VerPedidos
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public float Total { get; set; }

        public VerPedidos() { }

        public VerPedidos(int pId, string pCliente, string pEmpleado, DateTime pFecha, string pHora, float pTotal)
        {
            this.ID = pId;
            this.Cliente = pCliente;
            this.Empleado = pEmpleado;
            this.Fecha = pFecha;
            this.Hora = pHora;
            this.Total = pTotal;
        }
    }

    public class Detalles_Pedidos
    {
        public int Pedido { get; set; }
        public int Producto { get; set; }
        public int Cantidad { get; set; }

        public Detalles_Pedidos() { }

        public Detalles_Pedidos(int pPedido, int pProducto, int pCantidad)
        {
            this.Pedido = pPedido;
            this.Producto = pProducto;
            this.Cantidad = pCantidad;
        }
    }

    public class VerDetalles_Pedidos
    {
        public string Producto { get; set; }
        public float Precio{ get; set; }
        public int Cantidad { get; set; }
        public float SubTotal { get; set; }
        public VerDetalles_Pedidos() { }

        public VerDetalles_Pedidos(string pProducto, float pPrecio, int pCantidad, float pSubTotal)
        {
            this.Producto = pProducto;
            this.Precio = pPrecio;
            this.Cantidad = pCantidad;
            this.SubTotal = pSubTotal;
        }
    }
    public class Movimientos
    {
        public int ID { get; set; }
        public string Razon { get; set; }
        public int Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public Movimientos() { }

        public Movimientos(int pId, string pRazon, int pProducto, int pCantidad, DateTime pFecha)
        {
            this.ID = pId;
            this.Razon = pRazon;
            this.Producto = pProducto;
            this.Cantidad = pCantidad;
            this.Fecha = pFecha;
        }
    }

    public class VerMovimientos
    {
        public int ID { get; set; }
        public string Razon { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public VerMovimientos() { }

        public VerMovimientos(int pId, string pRazon, string pProducto, int pCantidad, DateTime pFecha)
        {
            this.ID = pId;
            this.Razon = pRazon;
            this.Producto = pProducto;
            this.Cantidad = pCantidad;
            this.Fecha = pFecha;
        }
    }
}
