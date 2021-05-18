using System;
using System.Windows.Forms;

namespace ArqueCaf
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            DGVProductos.DataSource = ProductosBD.Listar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxbNombre.Text != "")
            {
                if (TxbPrecio.Text != "")
                {
                    if (TxbDisponible.Text != "")
                    {
                        if (TxbMinima.Text != "")
                        {
                            if (TxbMaxima.Text != "")
                            {
                                if (Convert.ToInt32(TxbMaxima.Text) > Convert.ToInt32(TxbMinima.Text))
                                {
                                    if (TxbID.Text != "")
                                    {
                                        //Actualizar
                                        Productos actualizarP = new Productos()
                                        {
                                            ID = Convert.ToInt32(TxbID.Text),
                                            Nombre = TxbNombre.Text,
                                            Precio = float.Parse(TxbPrecio.Text),
                                            Disponible = Convert.ToInt32(TxbDisponible.Text),
                                            Minimo = Convert.ToInt32(TxbMinima.Text),
                                            Maximo = Convert.ToInt32(TxbMaxima.Text)
                                        };
                                        if (ProductosBD.Actualizar(actualizarP) > 0)
                                        {
                                            MessageBox.Show("Datos del Producto Actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Limpiar();
                                            DGVProductos.DataSource = ProductosBD.Listar();
                                            BtnGuardar.Text = "Guardar";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al guardar los datos del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        //Guardar nuevo
                                        Productos nuevoP = new Productos()
                                        {
                                            Nombre = TxbNombre.Text,
                                            Precio = float.Parse(TxbPrecio.Text),
                                            Disponible = Convert.ToInt32(TxbDisponible.Text),
                                            Minimo = Convert.ToInt32(TxbMinima.Text),
                                            Maximo = Convert.ToInt32(TxbMaxima.Text)
                                        };
                                        if (ProductosBD.Agregar(nuevoP) > 0)
                                        {
                                            MessageBox.Show("Datos del Producto Guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Limpiar();
                                            DGVProductos.DataSource = ProductosBD.Listar();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al guardar los datos del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La cantidad minima no puede ser mayor a la maxima", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    TxbMinima.Focus();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Proporcione la cantidad máxima del producto en inventario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TxbMaxima.Focus();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Proporcione la cantidad mínima del producto en inventario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxbMinima.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Proporcione la cantidad actual del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxbDisponible.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Proporcione el precio del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxbPrecio.Focus();
                }
            }
            else
            {
                MessageBox.Show("Proporcione el nombre del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbNombre.Focus();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            BtnGuardar.Text = "Guardar";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el producto actual?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(DGVProductos.CurrentRow.Cells[0].Value);
                if (ProductosBD.Eliminar(ID) > 0)
                {
                    MessageBox.Show("¡Registro del producto Eliminado Correctamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVProductos.DataSource = ProductosBD.Listar();
                    Limpiar();
                    BtnGuardar.Text = "Guardar";
                    if (DGVProductos.Rows.Count == 0)
                    {
                        BtnEliminar.Enabled = false;
                    }
                }
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (TxbNombre.Text != "")
            {
                DGVProductos.DataSource = ProductosBD.Buscar(TxbNombre.Text);
            }
            else
            {
                MessageBox.Show("Proporcione el nombre del producto para buscarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbNombre.Focus();
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void DGVProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxbID.Text = DGVProductos .CurrentRow.Cells[0].Value.ToString();
            TxbNombre.Text = DGVProductos.CurrentRow.Cells[1].Value.ToString();
            TxbPrecio.Text = DGVProductos.CurrentRow.Cells[2].Value.ToString();
            TxbDisponible.Text = DGVProductos.CurrentRow.Cells[3].Value.ToString();
            TxbMinima.Text = DGVProductos.CurrentRow.Cells[4].Value.ToString();
            TxbMaxima.Text = DGVProductos.CurrentRow.Cells[5].Value.ToString();
            BtnGuardar.Text = "Actualizar";
            BtnCancelar.Visible = true;
        }

        private void DGVProductos_SelectionChanged(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = true;
        }

        private void Limpiar()
        {
            TxbID.Clear();
            TxbNombre.Clear();
            TxbPrecio.Clear();
            TxbDisponible.Clear();
            TxbMinima.Clear();
            TxbMaxima.Clear();
            TxbNombre.Focus();
            BtnCancelar.Visible = false;
        }

        //Solo números
        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
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

        private void FrmProductos_KeyUp(object sender, KeyEventArgs e)
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
                case "guardar":
                    BtnGuardar.PerformClick();
                    break;
                case "cancelar":
                    BtnCancelar.PerformClick();
                    break;
                case "eliminar":
                    BtnEliminar.PerformClick();
                    break;
                case "consultar":
                    BtnConsultar.PerformClick();
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
                case "TxbNombre":
                    TxbNombre.Text = Frase;
                    break;
                case "TxbPrecio":
                    TxbPrecio.Text = Frase;
                    break;
                case "TxbDisponible":
                    TxbDisponible.Text = Frase;
                    break;
                case "TxbMinima":
                    TxbMinima.Text = Frase;
                    break;
                case "TxbMaxima":
                    TxbMaxima.Text = Frase;
                    break;
            }
        }
    }
}
