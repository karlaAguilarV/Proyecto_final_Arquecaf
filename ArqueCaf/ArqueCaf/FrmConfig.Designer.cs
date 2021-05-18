namespace ArqueCaf
{
    partial class FrmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.LRV = new System.Windows.Forms.Label();
            this.LEV = new System.Windows.Forms.Label();
            this.LAV = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CBRV = new System.Windows.Forms.ComboBox();
            this.CBEV = new System.Windows.Forms.ComboBox();
            this.CBAV = new System.Windows.Forms.ComboBox();
            this.RTBAyuda = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LRV
            // 
            this.LRV.AutoSize = true;
            this.LRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRV.Location = new System.Drawing.Point(12, 58);
            this.LRV.Name = "LRV";
            this.LRV.Size = new System.Drawing.Size(242, 25);
            this.LRV.TabIndex = 1;
            this.LRV.Text = "Reconocimiento de voz:";
            this.LRV.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LEV
            // 
            this.LEV.AutoSize = true;
            this.LEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEV.Location = new System.Drawing.Point(74, 108);
            this.LEV.Name = "LEV";
            this.LEV.Size = new System.Drawing.Size(180, 25);
            this.LEV.TabIndex = 2;
            this.LEV.Text = "Escritura por voz:";
            this.LEV.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LAV
            // 
            this.LAV.AutoSize = true;
            this.LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAV.Location = new System.Drawing.Point(110, 158);
            this.LAV.Name = "LAV";
            this.LAV.Size = new System.Drawing.Size(144, 25);
            this.LAV.TabIndex = 3;
            this.LAV.Text = "Ayuda Visual:";
            this.LAV.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(168, 9);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(158, 25);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Configuración";
            this.LTitulo.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(362, 427);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(92, 35);
            this.BtnAtras.TabIndex = 8;
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            this.BtnAtras.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(12, 427);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 35);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.BtnGuardar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // CBRV
            // 
            this.CBRV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CBRV.FormattingEnabled = true;
            this.CBRV.Items.AddRange(new object[] {
            "Deshabilitado",
            "Habilitado"});
            this.CBRV.Location = new System.Drawing.Point(260, 55);
            this.CBRV.Name = "CBRV";
            this.CBRV.Size = new System.Drawing.Size(186, 33);
            this.CBRV.TabIndex = 4;
            this.CBRV.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // CBEV
            // 
            this.CBEV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CBEV.FormattingEnabled = true;
            this.CBEV.Items.AddRange(new object[] {
            "Deshabilitado",
            "Habilitado"});
            this.CBEV.Location = new System.Drawing.Point(260, 108);
            this.CBEV.Name = "CBEV";
            this.CBEV.Size = new System.Drawing.Size(186, 33);
            this.CBEV.TabIndex = 5;
            this.CBEV.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // CBAV
            // 
            this.CBAV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CBAV.FormattingEnabled = true;
            this.CBAV.Items.AddRange(new object[] {
            "Deshabilitado",
            "Habilitado"});
            this.CBAV.Location = new System.Drawing.Point(260, 155);
            this.CBAV.Name = "CBAV";
            this.CBAV.Size = new System.Drawing.Size(186, 33);
            this.CBAV.TabIndex = 6;
            this.CBAV.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // RTBAyuda
            // 
            this.RTBAyuda.BackColor = System.Drawing.Color.White;
            this.RTBAyuda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBAyuda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBAyuda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBAyuda.Location = new System.Drawing.Point(12, 216);
            this.RTBAyuda.Name = "RTBAyuda";
            this.RTBAyuda.ReadOnly = true;
            this.RTBAyuda.Size = new System.Drawing.Size(434, 205);
            this.RTBAyuda.TabIndex = 10;
            this.RTBAyuda.TabStop = false;
            this.RTBAyuda.Text = resources.GetString("RTBAyuda.Text");
            this.RTBAyuda.MouseHover += new System.EventHandler(this.RTBAyuda_MouseHover);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 474);
            this.Controls.Add(this.RTBAyuda);
            this.Controls.Add(this.CBAV);
            this.Controls.Add(this.CBEV);
            this.Controls.Add(this.CBRV);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.LAV);
            this.Controls.Add(this.LEV);
            this.Controls.Add(this.LRV);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FrmConfig_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LRV;
        private System.Windows.Forms.Label LEV;
        private System.Windows.Forms.Label LAV;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CBRV;
        private System.Windows.Forms.ComboBox CBEV;
        private System.Windows.Forms.ComboBox CBAV;
        private System.Windows.Forms.RichTextBox RTBAyuda;
    }
}