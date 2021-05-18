using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ArqueCaf
{
    class UsuariosBD
    {
        public static int Existe(string usuario, string contrasena)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("SELECT count(*) FROM Usuarios WHERE User='{0}' AND Password='{1}';",
                usuario, contrasena), BDConexion.ObtenerConexion());
            Retorno = Convert.ToInt32(Comando.ExecuteScalar());
            return Retorno;
        }

        public static int Obtener_Rol(string usuario, string contrasena)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("SELECT Rol FROM Usuarios WHERE User='{0}' AND Password='{1}'", usuario, contrasena), BDConexion.ObtenerConexion());
            Retorno = Convert.ToInt32(Comando.ExecuteScalar());
            return Retorno;
        }
    }

    class EmpleadosBD
    {
        public static List<Empleados> Listar()
        {
            List<Empleados> _lista = new List<Empleados>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select * FROM Empleados;"), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Empleados cEmpleados = new Empleados
                {
                    ID = _reader.GetInt32(0),
                    Nombre = _reader.GetString(1),
                    RFC = _reader.GetString(2),
                    Telefono = _reader.GetString(3),
                    Direccion = _reader.GetString(4)
                };
                _lista.Add(cEmpleados);
            }
            return _lista;
        }

        public static int Agregar(Empleados pEmpleado)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("INSERT INTO Empleados (Nombre, RFC, Telefono, Direccion) VALUES ('{0}', '{1}', '{2}', '{3}');",
                pEmpleado.Nombre, pEmpleado.RFC, pEmpleado.Telefono, pEmpleado.Direccion), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static int Eliminar(int ID)
        {
            int retorno;
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Empleados WHERE ID_Empleado={0}", ID), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int Actualizar(Empleados pEmpleado)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("UPDATE Empleados set Nombre='{0}', RFC='{1}', Telefono='{2}', Direccion='{3}' WHERE ID_Empleado='{4}';",
                pEmpleado.Nombre, pEmpleado.RFC, pEmpleado.Telefono, pEmpleado.Direccion, pEmpleado.ID), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static List<Empleados> Buscar(string dato, int buscar)
        {
            List<Empleados> _lista = new List<Empleados>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM Empleados"), BDConexion.ObtenerConexion());
            switch(buscar)
            {
                case 1:     //Buscar por nombre
                    _comando = new MySqlCommand(String.Format("SELECT * FROM Empleados WHERE Nombre LIKE '%{0}%'", dato), BDConexion.ObtenerConexion());
                    break;
                case 2:     //Buscar por RFC
                    _comando = new MySqlCommand(String.Format("SELECT * FROM Empleados WHERE RFC LIKE '%{0}%'", dato), BDConexion.ObtenerConexion());
                    break;
                case 3:     //Buscar por telefono
                    _comando = new MySqlCommand(String.Format("SELECT * FROM Empleados WHERE Telefono LIKE '%{0}%'", dato), BDConexion.ObtenerConexion());
                    break;
            }
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Empleados cEmpleados = new Empleados
                {
                    ID = _reader.GetInt32(0),
                    Nombre = _reader.GetString(1),
                    RFC = _reader.GetString(2),
                    Telefono = _reader.GetString(3),
                    Direccion = _reader.GetString(4)
                };
                _lista.Add(cEmpleados);
            }
            return _lista;
        }
    }

    class ClientesBD
    {
        public static List<Clientes> Listar()
        {
            List<Clientes> _lista = new List<Clientes>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select * FROM Clientes;"), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Clientes cClientes = new Clientes
                {
                    ID = _reader.GetInt32(0),
                    Nombre = _reader.GetString(1),
                    Telefono = _reader.GetString(2)
                };
                _lista.Add(cClientes);
            }
            return _lista;
        }

        public static int Agregar(Clientes pCliente)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("INSERT INTO Clientes (Nombre, Telefono) VALUES ('{0}', '{1}');",
                pCliente.Nombre, pCliente.Telefono), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static int Eliminar(int ID)
        {
            int retorno;
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Clientes WHERE ID_Cliente={0}", ID), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int Actualizar(Clientes pCliente)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("UPDATE Clientes set Nombre='{0}', Telefono='{1}' WHERE ID_Cliente='{2}';",
                pCliente.Nombre, pCliente.Telefono, pCliente.ID), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static List<Clientes> Buscar(string dato, int buscar)
        {
            List<Clientes> _lista = new List<Clientes>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM Clientes"), BDConexion.ObtenerConexion());
            switch (buscar)
            {
                case 1:     //Buscar por nombre
                    _comando = new MySqlCommand(String.Format("SELECT * FROM Clientes WHERE Nombre LIKE '%{0}%'", dato), BDConexion.ObtenerConexion());
                    break;
                case 2:     //Buscar por telefono
                    _comando = new MySqlCommand(String.Format("SELECT * FROM Clientes WHERE Telefono LIKE '%{0}%'", dato), BDConexion.ObtenerConexion());
                    break;
            }
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Clientes cClientes = new Clientes
                {
                    ID = _reader.GetInt32(0),
                    Nombre = _reader.GetString(1),
                    Telefono = _reader.GetString(2)
                };
                _lista.Add(cClientes);
            }
            return _lista;
        }
    }

    class ProductosBD
    {
        public static List<Productos> Listar()
        {
            List<Productos> _lista = new List<Productos>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select * FROM Productos;"), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Productos cProductos = new Productos
                {
                    ID = _reader.GetInt32(0),
                    Nombre = _reader.GetString(1),
                    Precio = _reader.GetFloat(2),
                    Disponible = _reader.GetInt32(3),
                    Minimo = _reader.GetInt32(4),
                    Maximo = _reader.GetInt32(5)
                };
                _lista.Add(cProductos);
            }
            return _lista;
        }

        public static int Agregar(Productos pProductos)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("INSERT INTO Productos (Nombre, Precio, Disponible, Minimo, Maximo) VALUES ('{0}', '{1}','{2}','{3}','{4}');",
                pProductos.Nombre, pProductos.Precio, pProductos.Disponible, pProductos.Minimo, pProductos.Maximo), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static int Eliminar(int ID)
        {
            int retorno;
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM Productos WHERE ID_Producto={0}", ID), conexion);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int Actualizar(Productos pProductos)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("UPDATE Productos set Nombre='{0}', Precio='{1}', Disponible='{2}', Minimo='{3}', Maximo='{4}' WHERE ID_Producto='{5}';",
                pProductos.Nombre, pProductos.Precio, pProductos.Disponible, pProductos.Minimo, pProductos.Maximo, pProductos.ID), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static int Actualizar(int ID, int Cantidad)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("UPDATE Productos set Disponible='{0}' WHERE ID_Producto='{1}';",
                Cantidad, ID), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static List<Productos> Buscar(string nombre)
        {
            List<Productos> _lista = new List<Productos>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM Productos WHERE Nombre LIKE '%{0}%'", nombre), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Productos cProductos = new Productos
                {
                    ID = _reader.GetInt32(0),
                    Nombre = _reader.GetString(1),
                    Precio = _reader.GetFloat(2),
                    Disponible = _reader.GetInt32(3),
                    Minimo = _reader.GetInt32(4),
                    Maximo = _reader.GetInt32(5)
                };
                _lista.Add(cProductos);
            }
            return _lista;
        }

        public static List<Productos> Buscar(int ID)
        {
            List<Productos> _lista = new List<Productos>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM Productos WHERE ID_Producto = '{0}';", ID), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Productos cProductos = new Productos
                {
                    ID = _reader.GetInt32(0),
                    Nombre = _reader.GetString(1),
                    Precio = _reader.GetFloat(2),
                    Disponible = _reader.GetInt32(3),
                    Minimo = _reader.GetInt32(4),
                    Maximo = _reader.GetInt32(5)
                };
                _lista.Add(cProductos);
            }
            return _lista;
        }
    }

    class PedidosBD
    {
        public static int Agregar(Pedidos pPedidos)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("INSERT INTO Pedidos (ID_Cliente, ID_Empleado, Fecha, Total) VALUES ('{0}','{1}','{2}','{3}');",
                pPedidos.Cliente, pPedidos.Empleado, pPedidos.Fecha.ToString("yyyy-MM-dd"), pPedidos.Total), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static int Obtener_ID(int Cliente, int Empleado, DateTime Fecha)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("SELECT ID_Pedido FROM Pedidos WHERE ID_Cliente='{0}' AND ID_Empleado='{1}' AND Fecha = '{2}' ORDER BY Hora DESC LIMIT 1;", 
                Cliente, Empleado, Fecha.ToString("yyyy-MM-dd")), BDConexion.ObtenerConexion());
            Retorno = Convert.ToInt32(Comando.ExecuteScalar());
            return Retorno;
        }

        public static List<VerPedidos> Listar()
        {
            List<VerPedidos> _lista = new List<VerPedidos>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ID_Pedido, Clientes.Nombre as Cliente, Empleados.Nombre as Empleado, Fecha, Hora, Total FROM Pedidos JOIN Clientes ON Pedidos.ID_Cliente = Clientes.ID_Cliente JOIN Empleados ON Pedidos.ID_Empleado = Empleados.ID_Empleado;"), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                VerPedidos cPedidos = new VerPedidos
                {
                    ID = _reader.GetInt32(0),
                    Cliente = _reader.GetString(1),
                    Empleado = _reader.GetString(2),
                    Fecha = Convert.ToDateTime(_reader.GetDateTime(3).ToString("dd/MM/yyyy")),
                    Hora = _reader.GetString(4),
                    Total = _reader.GetFloat(5)
                };
                _lista.Add(cPedidos);
            }
            return _lista;
        }
    }

    class Detalles_PedidosBD
    {
        public static int Agregar(Detalles_Pedidos pDetalles)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("INSERT INTO Detalles_Pedidos (ID_Pedido, ID_Producto, Cantidad) VALUES ('{0}','{1}','{2}');",
                pDetalles.Pedido, pDetalles.Producto, pDetalles.Cantidad), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static List<VerDetalles_Pedidos> Listar(int ID_Pedido)
        {
            List<VerDetalles_Pedidos> _lista = new List<VerDetalles_Pedidos>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Nombre, Precio, cantidad FROM Detalles_Pedidos JOIN Productos ON Detalles_Pedidos.ID_Producto = Productos.ID_Producto WHERE ID_pedido = '{0}';", ID_Pedido), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                VerDetalles_Pedidos cDetalles = new VerDetalles_Pedidos
                {
                    Producto = _reader.GetString(0),
                    Precio = _reader.GetFloat(1),
                    Cantidad = _reader.GetInt32(2), 
                    SubTotal = (_reader.GetFloat(1) * _reader.GetInt32(2))
                };
                _lista.Add(cDetalles);
            }
            return _lista;
        }
    }

    class MovimientosBD
    {
        public static int Agregar(Movimientos pMovimiento)
        {
            int Retorno;
            MySqlCommand Comando = new MySqlCommand(string.Format("INSERT INTO Movimientos (Razon, ID_Producto, Cantidad, Fecha) VALUES ('{0}','{1}','{2}','{3}');",
                pMovimiento.Razon, pMovimiento.Producto, pMovimiento.Cantidad, pMovimiento.Fecha.ToString("yyyy-MM-dd")), BDConexion.ObtenerConexion());
            Retorno = Comando.ExecuteNonQuery();
            return Retorno;
        }

        public static List<VerMovimientos> Listar()
        {
            List<VerMovimientos> _lista = new List<VerMovimientos>();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT ID_Movimiento, Razon, Productos.Nombre, Cantidad, Fecha FROM Movimientos JOIN Productos ON Movimientos.ID_Producto = Productos.ID_Producto ORDER BY ID_Movimiento DESC;"), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                VerMovimientos cMovimientos = new VerMovimientos
                {
                    ID = _reader.GetInt32(0),
                    Razon = _reader.GetString(1),
                    Producto = _reader.GetString(2),
                    Cantidad = _reader.GetInt32(3),
                    Fecha = Convert.ToDateTime(_reader.GetDateTime(4).ToString("dd/MM/yyyy"))
                };
                _lista.Add(cMovimientos);
            }
            return _lista;
        }
    }
}
