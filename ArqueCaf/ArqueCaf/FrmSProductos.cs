using System;
using System.Windows.Forms;

namespace ArqueCaf
{
    public partial class FrmSProductos : Form
    {
        public FrmSProductos()
        {
            InitializeComponent();
            DGVProductos.DataSource = ProductosBD.Listar();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ID = Convert.ToInt32(DGVProductos.CurrentRow.Cells[0].Value);
            if (this.Owner is IProducto envio)
                envio.Cargar(ID);
            this.Close();
        }

        private void TxbNombre_KeyUp(object sender, KeyEventArgs e)
        {
            DGVProductos.DataSource = ProductosBD.Buscar(TxbNombre.Text);
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

        private void FrmSProductos_KeyUp(object sender, KeyEventArgs e)
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
            }
        }
    }
}
