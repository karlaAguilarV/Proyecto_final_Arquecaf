using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArqueCaf
{
    public partial class FrmInventario : Form, IProducto
    {
        private bool Termino = false;
        public FrmInventario()
        {
            InitializeComponent();
            CBRazon.SelectedIndex = 0;
            DGVMovimientos.DataSource = MovimientosBD.Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Buscar producto y cargarlo
            FrmSProductos Buscar = new FrmSProductos();
            Buscar.ShowDialog(this);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxbID.Text != "")
            {
                if (TxbCantidad.Text != "" && Convert.ToInt32(TxbCantidad.Text) > 0)
                {
                    if(CBRazon.SelectedIndex == 0)
                    {
                        //Entrada
                        Movimientos DataM = new Movimientos() {
                            Razon = "Entrada de mercancia",
                            Producto = Convert.ToInt32(TxbID.Text),
                            Cantidad = Convert.ToInt32(TxbCantidad.Text),
                            Fecha = DateTime.Now
                        };

                        int NuevaC = Convert.ToInt32(TxbDisponible.Text) + Convert.ToInt32(TxbCantidad.Text);
                        if(MovimientosBD.Agregar(DataM) > 0)
                        {
                            if (ProductosBD.Actualizar(Convert.ToInt32(TxbID.Text), NuevaC) > 0)
                            {
                                if(NuevaC > Convert.ToInt32(TxbMaximo.Text))
                                {
                                    MessageBox.Show("Se ha sobrepasado el máximo del inventario para el producto actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                MessageBox.Show("Inventario Actualizado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Algo salio mal al actualizar el inventario\n\nContacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Algo salio mal al registrar el movimiento en inventariado\n\nContacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Salida
                        Movimientos DataM = new Movimientos()
                        {
                            Razon = "Salida de mercancia",
                            Producto = Convert.ToInt32(TxbID.Text),
                            Cantidad = Convert.ToInt32(TxbCantidad.Text),
                            Fecha = DateTime.Now
                        };
                        int NuevaC = Convert.ToInt32(TxbDisponible.Text) - Convert.ToInt32(TxbCantidad.Text);
                        if(NuevaC < 0)
                        {
                            MessageBox.Show("No se puedo procesar la solicitud, no cuenta con el suficiente producto\n\nEl inventario no puede quedar negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxbCantidad.Focus();
                        }
                        else
                        {
                            if (MovimientosBD.Agregar(DataM) > 0)
                            {
                                if (ProductosBD.Actualizar(Convert.ToInt32(TxbID.Text), NuevaC) > 0)
                                {
                                    if (NuevaC < Convert.ToInt32(TxbMinimo.Text))
                                    {
                                        MessageBox.Show("Escasez de producto actual\n\nConsidere ordenar más producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    MessageBox.Show("Inventario Actualizado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Algo salio mal al actualizar el inventario\n\nContacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Algo salio mal al registrar el movimiento en inventariado\n\nContacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Proporcione una cantidad valida para realizar el movimiento en inventario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxbCantidad.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnBuscar.Focus();
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        public void Limpiar()
        {
            CBRazon.SelectedIndex = 0;
            TxbID.Clear();
            TxbNombre.Clear();
            TxbDisponible.Clear();
            TxbMinimo.Clear();
            TxbMaximo.Clear();
            TxbCantidad.Clear();
            DGVMovimientos.DataSource = MovimientosBD.Listar();
        }

        public void Cargar(int ID)
        {
            foreach (Productos producto in ProductosBD.Buscar(ID))
            {
                TxbID.Text = producto.ID.ToString();
                TxbNombre.Text = producto.Nombre;
                TxbDisponible.Text = producto.Disponible.ToString();
                TxbMinimo.Text = producto.Minimo.ToString();
                TxbMaximo.Text = producto.Maximo.ToString();
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

        private void FrmInventario_Shown(object sender, EventArgs e)
        {
            Termino = true;
        }

        private void FrmInventario_KeyUp(object sender, KeyEventArgs e)
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
                case "buscar":
                    BtnBuscar.PerformClick();
                    break;
                case "aplicar":
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
                case "TxbMinimo":
                    TxbMinimo.Text = Frase;
                    break;
                case "TxbMaximo":
                    TxbMaximo.Text = Frase;
                    break;
                case "TxbNombre":
                    TxbNombre.Text = Frase;
                    break;
                case "TxbDisponible":
                    TxbDisponible.Text = Frase;
                    break;
                case "TxbCantidad":
                    TxbCantidad.Text = Frase;
                    break;
            }
        }


    }
    internal interface IProducto
    {
        void Cargar(int ID);
    }
}
