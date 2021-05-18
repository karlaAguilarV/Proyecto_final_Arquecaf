namespace ArqueCaf
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controlCLi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxbTelefono = new System.Windows.Forms.TextBox();
            this.TxbNombre = new System.Windows.Forms.TextBox();
            this.TxbID = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LID = new System.Windows.Forms.Label();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CBBuscar = new System.Windows.Forms.ComboBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // controlCLi
            // 
            this.controlCLi.AutoSize = true;
            this.controlCLi.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlCLi.Location = new System.Drawing.Point(215, 60);
            this.controlCLi.Name = "controlCLi";
            this.controlCLi.Size = new System.Drawing.Size(208, 25);
            this.controlCLi.TabIndex = 29;
            this.controlCLi.Text = "Control de Clientes";
            this.controlCLi.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // TxbTelefono
            // 
            this.TxbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbTelefono.Location = new System.Drawing.Point(133, 240);
            this.TxbTelefono.MaxLength = 10;
            this.TxbTelefono.Name = "TxbTelefono";
            this.TxbTelefono.Size = new System.Drawing.Size(186, 32);
            this.TxbTelefono.TabIndex = 26;
            this.TxbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // TxbNombre
            // 
            this.TxbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbNombre.Location = new System.Drawing.Point(133, 190);
            this.TxbNombre.MaxLength = 60;
            this.TxbNombre.Name = "TxbNombre";
            this.TxbNombre.Size = new System.Drawing.Size(186, 32);
            this.TxbNombre.TabIndex = 24;
            // 
            // TxbID
            // 
            this.TxbID.Enabled = false;
            this.TxbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbID.Location = new System.Drawing.Point(133, 139);
            this.TxbID.MaxLength = 11;
            this.TxbID.Name = "TxbID";
            this.TxbID.Size = new System.Drawing.Size(100, 32);
            this.TxbID.TabIndex = 23;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(12, 244);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(96, 25);
            this.LTelefono.TabIndex = 21;
            this.LTelefono.Text = "Teléfono";
            this.LTelefono.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(12, 194);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(87, 25);
            this.LNombre.TabIndex = 19;
            this.LNombre.Text = "Nombre";
            this.LNombre.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LID.Location = new System.Drawing.Point(12, 143);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(32, 25);
            this.LID.TabIndex = 18;
            this.LID.Text = "ID";
            this.LID.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // DGVClientes
            // 
            this.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVClientes.Location = new System.Drawing.Point(342, 140);
            this.DGVClientes.MultiSelect = false;
            this.DGVClientes.Name = "DGVClientes";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVClientes.Size = new System.Drawing.Size(530, 280);
            this.DGVClientes.TabIndex = 35;
            this.DGVClientes.TabStop = false;
            this.DGVClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVClientes_CellMouseDoubleClick);
            this.DGVClientes.SelectionChanged += new System.EventHandler(this.DGVClientes_SelectionChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(133, 453);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 35);
            this.BtnCancelar.TabIndex = 37;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // CBBuscar
            // 
            this.CBBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CBBuscar.FormattingEnabled = true;
            this.CBBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Teléfono"});
            this.CBBuscar.Location = new System.Drawing.Point(133, 290);
            this.CBBuscar.Name = "CBBuscar";
            this.CBBuscar.Size = new System.Drawing.Size(186, 33);
            this.CBBuscar.TabIndex = 42;
            this.CBBuscar.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.Location = new System.Drawing.Point(12, 294);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(116, 25);
            this.LBuscar.TabIndex = 41;
            this.LBuscar.Text = "Buscar por";
            this.LBuscar.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(372, 453);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(92, 35);
            this.BtnEliminar.TabIndex = 38;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(12, 453);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 35);
            this.BtnGuardar.TabIndex = 36;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.BtnGuardar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(579, 453);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(92, 35);
            this.BtnConsultar.TabIndex = 39;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            this.BtnConsultar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(780, 453);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(92, 35);
            this.BtnAtras.TabIndex = 40;
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            this.BtnAtras.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 500);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.CBBuscar);
            this.Controls.Add(this.LBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.controlCLi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxbTelefono);
            this.Controls.Add(this.TxbNombre);
            this.Controls.Add(this.TxbID);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientes";
            this.Shown += new System.EventHandler(this.FrmClientes_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmClientes_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label controlCLi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxbTelefono;
        private System.Windows.Forms.TextBox TxbNombre;
        private System.Windows.Forms.TextBox TxbID;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CBBuscar;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnAtras;
    }
}