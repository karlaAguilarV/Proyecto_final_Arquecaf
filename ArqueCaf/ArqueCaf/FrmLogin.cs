using System;
using System.Windows.Forms;

namespace ArqueCaf
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Accesibilidad.Inicializar();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if(TxbUsuario.Text != "")
            {
                if (TxbPassword.Text != "")
                {
                    if(UsuariosBD.Existe(TxbUsuario.Text, Seguridad.GetSHA1Hash(Seguridad.GetMD5Hash(TxbPassword.Text))) == 1)
                    {
                        int Rol = UsuariosBD.Obtener_Rol(TxbUsuario.Text, Seguridad.GetSHA1Hash(Seguridad.GetMD5Hash(TxbPassword.Text)));
                        TxbUsuario.Clear();
                        TxbPassword.Clear();
                        TxbUsuario.Focus();
                        FrmMenu menu = new FrmMenu(Rol);
                        menu.Show(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Verifique su Informacion de acceso\n\nPosibles fallos:\nContraseña incorrecta\nUsuario inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxbUsuario.Focus();
                        TxbPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Debe de proporcionar su contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxbPassword.Focus();
                }
            }
            else {
                MessageBox.Show("Debe de proporcionar su nombre de usuario","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxbUsuario.Focus();
            }
        }

        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                if (sender.Equals(TxbUsuario))
                {
                    e.Handled = true;
                    TxbPassword.Focus();
                }
                else
                {
                    e.Handled = true;
                    BtnIniciar.PerformClick();
                }
            }
        }
    }
}
