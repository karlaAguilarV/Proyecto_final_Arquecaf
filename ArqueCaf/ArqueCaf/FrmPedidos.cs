using System;
using System.Windows.Forms;

namespace ArqueCaf
{
    public partial class FrmPedidos : Form
    {
        private readonly int[] ID_Clientes = new int[1000000];
        private readonly int[] ID_Empleados = new int[1000000];
        private readonly string[,] Data_Productos = new string[1000000, 6];
        private readonly string[,] Data_Pedido = new string[1000000, 4];
        private int Contador = 1, actual;
        private bool Nuevo = true, Modificando = false;
        private float Total = 0;
        private bool Termino = false;

        public FrmPedidos()
        {
            InitializeComponent();
            int i = 0;
            foreach (Clientes cliente in ClientesBD.Listar())
            {
                CBClientes.Items.Add(cliente.ID + ".-" + cliente.Nombre);
                ID_Clientes[i] = cliente.ID;
                i++;
            }
            i = 0;
            foreach (Empleados empleado in EmpleadosBD.Listar())
            {
                CBEmpleados.Items.Add(empleado.ID + ".-" + empleado.Nombre);
                ID_Empleados[i] = empleado.ID;
                i++;
            }
            i = 0;
            foreach (Productos producto in ProductosBD.Listar())
            {
                CBProductos.Items.Add(producto.ID + ".-" + producto.Nombre);
                Data_Productos[i, 0] = producto.ID.ToString();
                Data_Productos[i, 1] = producto.Nombre;
                Data_Productos[i, 2] = producto.Precio.ToString();
                Data_Productos[i, 3] = producto.Disponible.ToString();
                Data_Productos[i, 4] = producto.Minimo.ToString();
                i++;
            }
            try
            {
                CBClientes.SelectedIndex = 0;
                CBEmpleados.SelectedIndex = 0;
                CBProductos.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
            
            DTPFecha.Value = DateTime.Now;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(Modificando)
            {
                //Se esta actualizando la cantidad de producto
                Data_Pedido[actual, 2] = NUDCantidad.Value.ToString();                    //Cantidad
                Data_Pedido[actual, 3] = TxbSTotal.Text;                                  //Subtotal
                DgvPedidos.Rows[actual - 1].Cells[2].Value = Data_Pedido[actual, 2];
                DgvPedidos.Rows[actual - 1].Cells[4].Value = Data_Pedido[actual, 3];
                Total = 0;
                for (int i = 1; i < Contador; i++)
                {
                    Total += float.Parse(Data_Pedido[i, 3]);
                }
                TxbTotal.Text = Total.ToString();
                BtnAgregar.Text = "Agregar";
                BtnModificar.Text = "Modificar";
                CBProductos.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnGuardar.Enabled = true;
                CBProductos.SelectedIndex = 0;
                Modificando = false;
            }
            else
            {
                //Nuevo producto a agregar
                if (NUDCantidad.Value > 0)
                {
                    if (Contador == 1)
                    {
                        CBClientes.Enabled = false;
                        CBEmpleados.Enabled = false;
                        BtnGuardar.Enabled = true;
                    }
                    for (int i = 1; i < Contador; i++)
                    {
                        if (Data_Pedido[i, 0] == Data_Productos[CBProductos.SelectedIndex, 0])
                        {
                            Nuevo = false;
                        }
                    }
                    if (Nuevo)
                    {
                        Data_Pedido[Contador, 0] = Data_Productos[CBProductos.SelectedIndex, 0];    //ID
                        Data_Pedido[Contador, 1] = Data_Productos[CBProductos.SelectedIndex, 1];    //Nombre
                        Data_Pedido[Contador, 2] = NUDCantidad.Value.ToString();                    //Cantidad
                        Data_Pedido[Contador, 3] = TxbSTotal.Text;                                  //Subtotal
                        DgvPedidos.Rows.Add(Contador, Data_Pedido[Contador, 1], Data_Pedido[Contador, 2], Data_Productos[CBProductos.SelectedIndex, 2], Data_Pedido[Contador, 3]);
                        Total += float.Parse(Data_Pedido[Contador, 3]);
                        TxbTotal.Text = Total.ToString();
                        Contador++;
                        CBProductos.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Este producto ya fue agregado, si desea agregar una cantidad mayor del produto, seleccione el producto y modifique la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Nuevo = true;
                    }
                }
                else
                {
                    MessageBox.Show("Tiene que indicar una cantidad valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NUDCantidad.Focus();
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(Modificando)
            {
                BtnAgregar.Text = "Agregar";
                BtnModificar.Text = "Modificar";
                CBProductos.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnGuardar.Enabled = true;
                CBProductos.SelectedIndex = 0;
                Modificando = false;
            }
            else
            {
                actual = Convert.ToInt32(DgvPedidos.CurrentRow.Cells[0].Value);
                BtnAgregar.Text = "Actualizar";
                BtnModificar.Text = "Cancelar";
                CBProductos.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnGuardar.Enabled = false;
                CBProductos.SelectedItem = Data_Pedido[actual, 0] + ".-" + Data_Pedido[actual, 1];
                NUDCantidad.Value = int.Parse(Data_Pedido[actual, 2]);
                Modificando = true;
                
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            actual = Convert.ToInt32(DgvPedidos.CurrentRow.Cells[0].Value);
            if(Contador > 1)
            {
                Contador--;
                for (; actual < Contador; actual++)
                {
                    Data_Pedido[actual, 0] = Data_Pedido[actual + 1, 0];    //ID
                    Data_Pedido[actual, 1] = Data_Pedido[actual + 1, 1];    //Nombre
                    Data_Pedido[actual, 2] = Data_Pedido[actual + 1, 2];    //Cantidad
                    Data_Pedido[actual, 3] = Data_Pedido[actual + 1, 3];    //Subtotal

                    DgvPedidos.Rows[actual - 1].Cells[0].Value = actual;
                    DgvPedidos.Rows[actual - 1].Cells[1].Value = DgvPedidos.Rows[actual].Cells[1].Value;
                    DgvPedidos.Rows[actual - 1].Cells[2].Value = DgvPedidos.Rows[actual].Cells[2].Value;
                    DgvPedidos.Rows[actual - 1].Cells[3].Value = DgvPedidos.Rows[actual].Cells[3].Value;
                    DgvPedidos.Rows[actual - 1].Cells[4].Value = DgvPedidos.Rows[actual].Cells[4].Value;
                }
                DgvPedidos.Rows.Remove(DgvPedidos.Rows[Contador -1]);
                Total = 0;
                for (int i = 1; i < Contador; i++)
                {
                    Total += float.Parse(Data_Pedido[i, 3]);
                }
                TxbTotal.Text = Total.ToString();
            }
            else
            {
                Total = 0;
                TxbTotal.Text = Total.ToString();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea realizar el pedido con los siguientes productos?","¿Realizar Pedido?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Pedidos DPedido = new Pedidos() {
                    Cliente = ID_Clientes[CBClientes.SelectedIndex],
                    Empleado = ID_Empleados[CBEmpleados.SelectedIndex],
                    Fecha = DTPFecha.Value,
                    Total = Total
                };
                if(PedidosBD.Agregar(DPedido) > 0)
                {
                    int ID_Pedido = PedidosBD.Obtener_ID(ID_Clientes[CBClientes.SelectedIndex], ID_Empleados[CBEmpleados.SelectedIndex], DTPFecha.Value);
                    for (int i = 1; i < Contador; i++)
                    {
                        Detalles_Pedidos DDetalle = new Detalles_Pedidos {
                            Pedido = ID_Pedido,
                            Producto = Convert.ToInt32(Data_Pedido[i, 0]),
                            Cantidad = Convert.ToInt32(Data_Pedido[i, 2])
                        };
                        Movimientos DMovimiento = new Movimientos() {
                            Razon = "Pedido #"+ ID_Pedido,
                            Producto = Convert.ToInt32(Data_Pedido[i, 0]),
                            Cantidad = Convert.ToInt32(Data_Pedido[i, 2]),
                            Fecha = DTPFecha.Value
                        };
                        if (Detalles_PedidosBD.Agregar(DDetalle) <= 0)
                        {
                            MessageBox.Show("Algo salio de manera inesperada al procesar su pedido\n\nContacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (MovimientosBD.Agregar(DMovimiento) <= 0)
                        {
                            MessageBox.Show("Algo salio de manera inesperada al guardar el detalle de su pedido\n\nContacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //Actualizar las cantidades disponibles
                        int aux = 0;
                        for(int j=0; j <= 1000000; j++)
                        {
                            if(Data_Pedido[i, 0] == Data_Productos[j, 0])
                            {
                                aux = j;
                                break;
                            }
                        }
                        int nueva_cantidad = (Convert.ToInt32(Data_Productos[aux, 3]) - Convert.ToInt32(Data_Pedido[i, 2]));
                        if (ProductosBD.Actualizar(Convert.ToInt32(Data_Pedido[i, 0]), nueva_cantidad) > 0)
                        {
                            Data_Productos[aux, 3] = nueva_cantidad.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Algo salio de manera inesperada al actualizar el inventario\n\nContacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    CBClientes.Enabled = true;
                    CBEmpleados.Enabled = true;
                    BtnGuardar.Enabled = false;
                    Contador = 1; 
                    Total = 0;
                    TxbTotal.Text = "0";
                    DgvPedidos.Rows.Clear();
                    MessageBox.Show("Pedido Realizado con Exito", "Pedido Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algo salio de manera inesperada\n\nContacte con el administrador", "Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void CBProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxbPrecio.Text = Data_Productos[CBProductos.SelectedIndex, 2];
            NUDCantidad.Value = 0; 
            NUDCantidad.Maximum = Convert.ToInt32(Data_Productos[CBProductos.SelectedIndex, 3]);
        }

        private void NUDCantidad_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TxbSTotal.Text = (float.Parse(TxbPrecio.Text) * Convert.ToInt32(NUDCantidad.Value)).ToString();

            }
            catch (Exception)
            {
                TxbSTotal.Text = "0";
            }

            if (Properties.Settings.Default.Escucha)
            {
                Accesibilidad.Hablar(NUDCantidad.Value.ToString());
            }
        }

        private void DgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            actual = DgvPedidos.Rows.Count;
            if (actual > 0)
            {
                BtnModificar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else
            {
                BtnModificar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnGuardar.Enabled = false;
            }
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                Button DataTemp = (Button)sender;
                Accesibilidad.Hablar(DataTemp.Text);
            }
        }

        private void FrmPedidos_Shown(object sender, EventArgs e)
        {
            Termino = true;
        }

        private void DTPFecha_ValueChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                if (Termino)
                {
                    Accesibilidad.Hablar(DTPFecha.Value.ToShortDateString());
                }
            }

        }

        private void FrmPedidos_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.M))
            {
                //Reconocimiento de voz
                if (Properties.Settings.Default.Habla)
                {
                    Accion_Escucha(Accesibilidad.Escuchar());
                }
                else
                {
                    MessageBox.Show("El reconocimiento de voz no esta habilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.L))
            {
                //Escritura por voz
                if (Properties.Settings.Default.Dicta)
                {
                    Accion_Escritura(Accesibilidad.Escuchar());
                }
                else
                {
                    MessageBox.Show("La escritura por voz no esta habilitada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Accion_Escucha(string Frase)
        {
            switch (Frase)
            {
                case "agregar":
                    BtnGuardar.PerformClick();
                    break;
                case "modificar":
                    BtnModificar.PerformClick();
                    break;
                case "eliminar":
                    BtnEliminar.PerformClick();
                    break;
                case "realizar pedido":
                    BtnGuardar.PerformClick();
                    break;
                case "atrás":
                    BtnAtras.PerformClick();
                    break;
                default:
                    Accesibilidad.Hablar("Disculpa, no te entendi, hable fuerte y claro");
                    break;
            }
        }

        private void Accion_Escritura(string Frase)
        {
            switch (ActiveControl.Name)
            {
                case "TxbPrecio":
                    TxbPrecio.Text = Frase;
                    break;
            }
        }

        private void L_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                Label DataTemp = (Label)sender;
                Accesibilidad.Hablar(DataTemp.Text);
            }
        }



        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                if (Termino)
                {
                    ComboBox DataTemp = (ComboBox)sender;
                    Accesibilidad.Hablar(DataTemp.Text);
                }
            }
        }
    }
}
