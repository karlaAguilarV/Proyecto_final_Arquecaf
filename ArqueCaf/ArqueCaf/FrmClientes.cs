using System;
using System.Windows.Forms;

namespace ArqueCaf
{
    public partial class FrmClientes : Form
    {
        private bool Termino = false;
        public FrmClientes()
        {
            InitializeComponent();
            CBBuscar.SelectedIndex = 0;
            DGVClientes.DataSource = ClientesBD.Listar();
        }

        //Poner dgv para listar los clientes
        //El id de generacion automatica, LA BD lo genera

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxbNombre.Text != "")
            {
                if (TxbTelefono.Text != "")
                {
                    if (TxbID.Text != "")
                    {
                        //Actualizar
                        Clientes actualizarC = new Clientes()
                        {
                            ID = Convert.ToInt32(TxbID.Text),
                            Nombre = TxbNombre.Text,
                            Telefono = TxbTelefono.Text
                        };
                        if (ClientesBD.Actualizar(actualizarC) > 0)
                        {
                            MessageBox.Show("Datos del Cliente Actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            DGVClientes.DataSource = ClientesBD.Listar();
                            BtnGuardar.Text = "Guardar";
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar los datos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Guardar nuevo
                        Clientes nuevoC = new Clientes()
                        {
                            Nombre = TxbNombre.Text,
                            Telefono = TxbTelefono.Text
                        };
                        if (ClientesBD.Agregar(nuevoC) > 0)
                        {
                            MessageBox.Show("Datos del Cliente Guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            DGVClientes.DataSource = ClientesBD.Listar();
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar los datos del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Proporcione un número télefonico de contacto para el cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxbTelefono.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Proporcione el nombre del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (MessageBox.Show("¿Esta seguro que desea eliminar al cliente actual?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(DGVClientes.CurrentRow.Cells[0].Value);
                if (ClientesBD.Eliminar(ID) > 0)
                {
                    MessageBox.Show("¡Registro del cliente Eliminado Correctamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVClientes.DataSource = ClientesBD.Listar();
                    Limpiar();
                    BtnGuardar.Text = "Guardar";
                    if (DGVClientes.Rows.Count == 0)
                    {
                        BtnEliminar.Enabled = false;
                    }
                }
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            switch (CBBuscar.SelectedIndex)
            {
                case 0:
                    if (TxbNombre.Text != "")
                    {
                        DGVClientes.DataSource = ClientesBD.Buscar(TxbNombre.Text, 1);
                    }
                    else
                    {
                        MessageBox.Show("Proporcione el nombre del cliente para buscarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxbNombre.Focus();
                    }
                    break;
                case 1:
                    if (TxbTelefono.Text != "")
                    {
                        DGVClientes.DataSource = ClientesBD.Buscar(TxbTelefono.Text, 2);
                    }
                    else
                    {
                        MessageBox.Show("Proporcione el telefono del cliente para buscarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxbTelefono.Focus();
                    }
                    break;
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Limpiar()
        {
            TxbID.Clear();
            TxbNombre.Clear();
            TxbTelefono.Clear();
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

        private void DGVClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxbID.Text = DGVClientes.CurrentRow.Cells[0].Value.ToString();
            TxbNombre.Text = DGVClientes.CurrentRow.Cells[1].Value.ToString();
            TxbTelefono.Text = DGVClientes.CurrentRow.Cells[2].Value.ToString();
            BtnGuardar.Text = "Actualizar";
            BtnCancelar.Visible = true;
        }

        private void DGVClientes_SelectionChanged(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = true;
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                Button DataTemp = (Button)sender;
                Accesibilidad.Hablar(DataTemp.Text);
            }
        }

        private void FrmClientes_Shown(object sender, EventArgs e)
        {
            Termino = true;
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

        private void L_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                Label DataTemp = (Label)sender;
                Accesibilidad.Hablar(DataTemp.Text);
            }
        }

        private void FrmClientes_KeyUp(object sender, KeyEventArgs e)
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
                case "TxbTelefono":
                    TxbNombre.Text = Frase;
                    break;
            }
        }


    }
}
