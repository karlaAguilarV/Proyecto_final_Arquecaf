using System;
using System.Windows.Forms;

namespace ArqueCaf
{
    public partial class FrmDPedidos : Form
    {
        public FrmDPedidos()
        {
            InitializeComponent();
            DGVPedidos.DataSource = PedidosBD.Listar();
            
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void DGVPedidos_SelectionChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(DGVPedidos.CurrentRow.Cells[0].Value);
            DGVDetalles.DataSource = Detalles_PedidosBD.Listar(ID);
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                Button DataTemp = (Button)sender;
                Accesibilidad.Hablar(DataTemp.Text);
            }
        }
    }
}
