namespace ArqueCaf
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.TxbUsuario = new System.Windows.Forms.TextBox();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LUser = new System.Windows.Forms.Label();
            this.LPasword = new System.Windows.Forms.Label();
            this.GBLogin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.GBLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbLogo
            // 
            this.PbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(40, 40);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(188, 121);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // TxbUsuario
            // 
            this.TxbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbUsuario.Location = new System.Drawing.Point(20, 76);
            this.TxbUsuario.MaxLength = 50;
            this.TxbUsuario.Name = "TxbUsuario";
            this.TxbUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxbUsuario.Size = new System.Drawing.Size(196, 32);
            this.TxbUsuario.TabIndex = 1;
            this.TxbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // TxbPassword
            // 
            this.TxbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbPassword.Location = new System.Drawing.Point(20, 160);
            this.TxbPassword.MaxLength = 100;
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '*';
            this.TxbPassword.Size = new System.Drawing.Size(196, 32);
            this.TxbPassword.TabIndex = 3;
            this.TxbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter_KeyPress);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnIniciar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(67, 207);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(101, 39);
            this.BtnIniciar.TabIndex = 4;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // LUser
            // 
            this.LUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LUser.AutoSize = true;
            this.LUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUser.Location = new System.Drawing.Point(87, 43);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(68, 20);
            this.LUser.TabIndex = 0;
            this.LUser.Text = "Usuario ";
            // 
            // LPasword
            // 
            this.LPasword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LPasword.AutoSize = true;
            this.LPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPasword.Location = new System.Drawing.Point(76, 124);
            this.LPasword.Name = "LPasword";
            this.LPasword.Size = new System.Drawing.Size(92, 20);
            this.LPasword.TabIndex = 2;
            this.LPasword.Text = "Contraseña";
            // 
            // GBLogin
            // 
            this.GBLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBLogin.BackColor = System.Drawing.Color.Transparent;
            this.GBLogin.Controls.Add(this.LPasword);
            this.GBLogin.Controls.Add(this.LUser);
            this.GBLogin.Controls.Add(this.BtnIniciar);
            this.GBLogin.Controls.Add(this.TxbPassword);
            this.GBLogin.Controls.Add(this.TxbUsuario);
            this.GBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBLogin.Location = new System.Drawing.Point(12, 167);
            this.GBLogin.Name = "GBLogin";
            this.GBLogin.Size = new System.Drawing.Size(243, 268);
            this.GBLogin.TabIndex = 0;
            this.GBLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(271, 447);
            this.Controls.Add(this.GBLogin);
            this.Controls.Add(this.PbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.GBLogin.ResumeLayout(false);
            this.GBLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.TextBox TxbUsuario;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label LPasword;
        private System.Windows.Forms.GroupBox GBLogin;
    }
}

