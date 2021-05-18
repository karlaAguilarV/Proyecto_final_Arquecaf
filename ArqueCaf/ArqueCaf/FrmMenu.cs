using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace ArqueCaf
{
    public partial class FrmMenu : Form
    {
        private readonly int Rol;

        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(int rol_id)
        {
            InitializeComponent();
            Rol = rol_id;
            if (Rol != 1)
            {
                BtnEmpleados.Enabled = false;
            }
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleado = new FrmEmpleados();
            empleado.Show(this);
            this.Hide();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario inventario = new FrmInventario();
            inventario.Show(this);
            this.Hide();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos pedidos = new FrmPedidos();
            pedidos.Show(this);
            this.Hide();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes cliente= new FrmClientes();
            cliente.Show(this);
            this.Hide();
        }

        private void Btnproductos_Click(object sender, EventArgs e)
        {
            FrmProductos producto = new FrmProductos();
            producto.Show(this);
            this.Hide();
        }

        private void BtnLPedidos_Click(object sender, EventArgs e)
        {
            FrmDPedidos detalles = new FrmDPedidos();
            detalles.Show(this);
            this.Hide();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            FrmConfig Config = new FrmConfig();
            Config.Show(this);
            this.Hide();
        }

        private void FrmMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.M))
            {
                //Reconocimiento de voz
                if(Properties.Settings.Default.Habla)
                {
                    Accion_Escucha(Accesibilidad.Escuchar());
                }
                else
                {
                    MessageBox.Show("El reconocimiento de voz no esta habilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //Reconocimiento de voz
        private void Accion_Escucha(string Frase)
        {
            switch (Frase)
            {
                case "control de empleados":
                    BtnEmpleados.PerformClick();
                    break;
                case "control de inventarios":
                    BtnInventario.PerformClick();
                    break;
                case "control de pedidos":
                    BtnPedidos.PerformClick();
                    break;
                case "control de clientes":
                    BtnClientes.PerformClick();
                    break;
                case "control de productos":
                    BtnProductos.PerformClick();
                    break;
                case "pedidos":
                    BtnLPedidos.PerformClick();
                    break;
                case "cerrar sesión":
                    BtnCerrar.PerformClick();
                    break;
                case "salir":
                    Accesibilidad.Hablar("Cerrando la aplicación");
                    BtnSalir.PerformClick();
                    break;
                default: 
                    Accesibilidad.Hablar("Disculpa, no te entendi, hable fuerte y claro");
                    break;
            }
        }

        //Ayuda visual
        private void Btn_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                //MessageBox.Show("Tipo:" + sender.GetType().Name + "\nDato: " + DataTemp.Text);
                Button DataTemp = (Button)sender;
                Accesibilidad.Hablar(DataTemp.Text);
            }
        }

        private void BtnConfig_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                Accesibilidad.Hablar("Acceso a ajustes de accesibilidad");
            }
        }
    }
}
