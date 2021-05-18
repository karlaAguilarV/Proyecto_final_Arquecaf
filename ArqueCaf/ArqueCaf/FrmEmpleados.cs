using System;
using System.Windows.Forms;

namespace ArqueCaf
{
    public partial class FrmEmpleados : Form
    {
        private bool Termino = false;
        public FrmEmpleados()
        {
            InitializeComponent();
            CBBuscar.SelectedIndex = 0;
            DGVEmpleados.DataSource = EmpleadosBD.Listar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxbNombre.Text != "")
            {
                if (TxbRFC.Text != "")
                {
                    if (TxbTelefono.Text != "")
                    {
                        if (TxbDireccion.Text != "")
                        {
                            if(TxbID.Text != "")
                            {
                                //Actualizar
                                Empleados actualizarE = new Empleados()
                                {
                                    ID = Convert.ToInt32(TxbID.Text),
                                    Nombre = TxbNombre.Text,
                                    RFC = TxbRFC.Text,
                                    Telefono = TxbTelefono.Text,
                                    Direccion = TxbDireccion.Text
                                };
                                if (EmpleadosBD.Actualizar(actualizarE) > 0)
                                {
                                    MessageBox.Show("Datos del Empleado Actualizados correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                    DGVEmpleados.DataSource = EmpleadosBD.Listar();
                                    BtnGuardar.Text = "Guardar";
                                }
                                else
                                {
                                    MessageBox.Show("Error al guardar los datos del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //Guardar nuevo
                                Empleados nuevoE = new Empleados()
                                {
                                    Nombre = TxbNombre.Text,
                                    RFC = TxbRFC.Text,
                                    Telefono = TxbTelefono.Text,
                                    Direccion = TxbDireccion.Text
                                };
                                if (EmpleadosBD.Agregar(nuevoE) > 0)
                                {
                                    MessageBox.Show("Datos del Empleado Guardados correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Limpiar();
                                    DGVEmpleados.DataSource = EmpleadosBD.Listar();
                                }
                                else
                                {
                                    MessageBox.Show("Error al guardar los datos del empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proporcione la direccion del empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TxbDireccion.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Proporcione un número télefonico de contacto para el empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxbTelefono.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Proporcione el RFC del empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxbRFC.Focus();
                }
            }
            else {
                MessageBox.Show("Proporcione el nombre del empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbNombre.Focus();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el empleado actual?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(DGVEmpleados.CurrentRow.Cells[0].Value);
                if (EmpleadosBD.Eliminar(ID) > 0)
                {
                    MessageBox.Show("¡Registro del empleado Eliminado Correctamente!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVEmpleados.DataSource = EmpleadosBD.Listar();
                    Limpiar();
                    BtnGuardar.Text = "Guardar";
                    if (DGVEmpleados.Rows.Count == 0)
                    {
                        BtnEliminar.Enabled = false;
                    }
                }
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            switch(CBBuscar.SelectedIndex)
            {
                case 0:
                    if(TxbNombre.Text != "")
                    {
                        DGVEmpleados.DataSource = EmpleadosBD.Buscar(TxbNombre.Text, 1);
                    }
                    else
                    {
                        MessageBox.Show("Proporcione el nombre del empleado para buscarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxbNombre.Focus();
                    }
                    break;
                case 1:
                    if (TxbRFC.Text != "")
                    {
                        DGVEmpleados.DataSource = EmpleadosBD.Buscar(TxbRFC.Text, 2);
                    }
                    else
                    {
                        MessageBox.Show("Proporcione el RFC del empleado para buscarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxbRFC.Focus();
                    }
                    break;
                case 2:
                    if (TxbTelefono.Text != "")
                    {
                        DGVEmpleados.DataSource = EmpleadosBD.Buscar(TxbTelefono.Text, 3);
                    }
                    else
                    {
                        MessageBox.Show("Proporcione el telefono del empleado para buscarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            TxbRFC.Clear();
            TxbTelefono.Clear();
            TxbDireccion.Clear();
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

        private void DGVEmpleados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxbID.Text = DGVEmpleados.CurrentRow.Cells[0].Value.ToString();
            TxbNombre.Text = DGVEmpleados.CurrentRow.Cells[1].Value.ToString();
            TxbRFC.Text = DGVEmpleados.CurrentRow.Cells[2].Value.ToString();
            TxbTelefono.Text = DGVEmpleados.CurrentRow.Cells[3].Value.ToString();
            TxbDireccion.Text = DGVEmpleados.CurrentRow.Cells[4].Value.ToString();
            BtnGuardar.Text = "Actualizar";
            BtnCancelar.Visible = true;

        }

        private void DGVEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            BtnGuardar.Text = "Guardar";
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

        private void FrmEmpleados_Shown(object sender, EventArgs e)
        {
            Termino = true;
        }

        private void FrmEmpleados_KeyUp(object sender, KeyEventArgs e)
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
                if(Properties.Settings.Default.Dicta)
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
            switch(ActiveControl.Name)
            {
                case "TxbNombre":
                    TxbNombre.Text = Frase;
                    break;
                case "TxbRFC":
                    TxbRFC.Text = Frase;
                    break;
                case "TxbTelefono":
                    TxbTelefono.Text = Frase;
                    break;
                case "TxbDireccion":
                    TxbDireccion.Text = Frase;
                    break;
            }
        }
    }
}
