namespace ArqueCaf
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LID = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LRFC = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.TxbID = new System.Windows.Forms.TextBox();
            this.TxbNombre = new System.Windows.Forms.TextBox();
            this.TxbRFC = new System.Windows.Forms.TextBox();
            this.TxbTelefono = new System.Windows.Forms.TextBox();
            this.TxbDireccion = new System.Windows.Forms.TextBox();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.DGVEmpleados = new System.Windows.Forms.DataGridView();
            this.LBuscar = new System.Windows.Forms.Label();
            this.CBBuscar = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LID.Location = new System.Drawing.Point(95, 138);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(32, 25);
            this.LID.TabIndex = 1;
            this.LID.Text = "ID";
            this.LID.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(40, 189);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(87, 25);
            this.LNombre.TabIndex = 3;
            this.LNombre.Text = "Nombre";
            this.LNombre.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LRFC
            // 
            this.LRFC.AutoSize = true;
            this.LRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRFC.Location = new System.Drawing.Point(72, 239);
            this.LRFC.Name = "LRFC";
            this.LRFC.Size = new System.Drawing.Size(55, 25);
            this.LRFC.TabIndex = 5;
            this.LRFC.Text = "RFC";
            this.LRFC.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(31, 289);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(96, 25);
            this.LTelefono.TabIndex = 7;
            this.LTelefono.Text = "Télefono";
            this.LTelefono.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccion.Location = new System.Drawing.Point(25, 339);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(102, 25);
            this.LDireccion.TabIndex = 9;
            this.LDireccion.Text = "Dirección";
            this.LDireccion.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // TxbID
            // 
            this.TxbID.Enabled = false;
            this.TxbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbID.Location = new System.Drawing.Point(133, 134);
            this.TxbID.MaxLength = 11;
            this.TxbID.Name = "TxbID";
            this.TxbID.Size = new System.Drawing.Size(100, 32);
            this.TxbID.TabIndex = 2;
            // 
            // TxbNombre
            // 
            this.TxbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbNombre.Location = new System.Drawing.Point(133, 185);
            this.TxbNombre.MaxLength = 60;
            this.TxbNombre.Name = "TxbNombre";
            this.TxbNombre.Size = new System.Drawing.Size(186, 32);
            this.TxbNombre.TabIndex = 4;
            // 
            // TxbRFC
            // 
            this.TxbRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbRFC.Location = new System.Drawing.Point(133, 235);
            this.TxbRFC.MaxLength = 13;
            this.TxbRFC.Name = "TxbRFC";
            this.TxbRFC.Size = new System.Drawing.Size(186, 32);
            this.TxbRFC.TabIndex = 6;
            // 
            // TxbTelefono
            // 
            this.TxbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbTelefono.Location = new System.Drawing.Point(133, 285);
            this.TxbTelefono.MaxLength = 10;
            this.TxbTelefono.Name = "TxbTelefono";
            this.TxbTelefono.Size = new System.Drawing.Size(186, 32);
            this.TxbTelefono.TabIndex = 8;
            this.TxbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // TxbDireccion
            // 
            this.TxbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbDireccion.Location = new System.Drawing.Point(133, 335);
            this.TxbDireccion.MaxLength = 100;
            this.TxbDireccion.Name = "TxbDireccion";
            this.TxbDireccion.Size = new System.Drawing.Size(186, 32);
            this.TxbDireccion.TabIndex = 10;
            // 
            // PBImagen
            // 
            this.PBImagen.Image = ((System.Drawing.Image)(resources.GetObject("PBImagen.Image")));
            this.PBImagen.Location = new System.Drawing.Point(465, 12);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(120, 120);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagen.TabIndex = 11;
            this.PBImagen.TabStop = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(206, 60);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(238, 25);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Control de Empleados";
            this.LTitulo.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(780, 440);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(92, 35);
            this.BtnAtras.TabIndex = 15;
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            this.BtnAtras.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(535, 440);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(92, 35);
            this.BtnConsultar.TabIndex = 14;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            this.BtnConsultar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(44, 440);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 35);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.BtnGuardar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(289, 440);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(92, 35);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // DGVEmpleados
            // 
            this.DGVEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVEmpleados.Location = new System.Drawing.Point(352, 136);
            this.DGVEmpleados.MultiSelect = false;
            this.DGVEmpleados.Name = "DGVEmpleados";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVEmpleados.Size = new System.Drawing.Size(520, 282);
            this.DGVEmpleados.TabIndex = 16;
            this.DGVEmpleados.TabStop = false;
            this.DGVEmpleados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVEmpleados_CellMouseDoubleClick);
            this.DGVEmpleados.SelectionChanged += new System.EventHandler(this.DGVEmpleados_SelectionChanged);
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.Location = new System.Drawing.Point(11, 389);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(116, 25);
            this.LBuscar.TabIndex = 16;
            this.LBuscar.Text = "Buscar por";
            this.LBuscar.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // CBBuscar
            // 
            this.CBBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CBBuscar.FormattingEnabled = true;
            this.CBBuscar.Items.AddRange(new object[] {
            "Nombre",
            "RFC",
            "Télefono"});
            this.CBBuscar.Location = new System.Drawing.Point(133, 385);
            this.CBBuscar.Name = "CBBuscar";
            this.CBBuscar.Size = new System.Drawing.Size(186, 33);
            this.CBBuscar.TabIndex = 17;
            this.CBBuscar.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(142, 440);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 35);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 487);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.CBBuscar);
            this.Controls.Add(this.LBuscar);
            this.Controls.Add(this.DGVEmpleados);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.LTitulo);
            this.Controls.Add(this.PBImagen);
            this.Controls.Add(this.TxbDireccion);
            this.Controls.Add(this.TxbTelefono);
            this.Controls.Add(this.TxbRFC);
            this.Controls.Add(this.TxbNombre);
            this.Controls.Add(this.TxbID);
            this.Controls.Add(this.LDireccion);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LRFC);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Shown += new System.EventHandler(this.FrmEmpleados_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmEmpleados_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LRFC;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.TextBox TxbID;
        private System.Windows.Forms.TextBox TxbNombre;
        private System.Windows.Forms.TextBox TxbRFC;
        private System.Windows.Forms.TextBox TxbTelefono;
        private System.Windows.Forms.TextBox TxbDireccion;
        private System.Windows.Forms.PictureBox PBImagen;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DGVEmpleados;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.ComboBox CBBuscar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}