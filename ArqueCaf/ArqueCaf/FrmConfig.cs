using System;
using System.Windows.Forms;

namespace ArqueCaf
{
    public partial class FrmConfig : Form
    {
        private bool Termino = false;
        public FrmConfig()
        {
            InitializeComponent();

            //Reconocimiento de voz
            if(Properties.Settings.Default.Habla)
            {
                CBRV.SelectedIndex = 1;
            }else {
                CBRV.SelectedIndex = 0;
            }
            //Escritura por voz
            if (Properties.Settings.Default.Dicta)
            {
                CBEV.SelectedIndex = 1;
            }else {
                CBEV.SelectedIndex = 0;
            }
            //Ayuda visual (Habla al colocar los elementos encima el cursos)
            if (Properties.Settings.Default.Escucha)
            {
                CBAV.SelectedIndex = 1;
            }else {
                CBAV.SelectedIndex = 0;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CBRV.SelectedIndex == 0)
            {
                Properties.Settings.Default.Habla = false;
            }else {
                Properties.Settings.Default.Habla = true;
            }

            if(CBEV.SelectedIndex == 0)
            { 
                Properties.Settings.Default.Dicta = false;
            }else {
                Properties.Settings.Default.Dicta = true;
            }
            
            if(CBAV.SelectedIndex == 0)
            {
                Properties.Settings.Default.Escucha = false;
            }else {
                Properties.Settings.Default.Escucha = true;
                Accesibilidad.Hablar("Configuración Actualizada");
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("Configuración Actualizada", "Cambios Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
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
                if(Termino)
                {
                    ComboBox DataTemp = (ComboBox)sender;
                    Accesibilidad.Hablar(DataTemp.Text);
                }
            }
        }

        private void RTBAyuda_MouseHover(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Escucha)
            {
                RichTextBox DataTemp = (RichTextBox)sender;
                Accesibilidad.Hablar(DataTemp.Text);
            }

        }

        private void FrmConfig_Shown(object sender, EventArgs e)
        {
            Termino = true;
        }
    }
}
