namespace ArqueCaf
{
    partial class FrmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.LID = new System.Windows.Forms.Label();
            this.TxbID = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TxbNombre = new System.Windows.Forms.TextBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.TxbPrecio = new System.Windows.Forms.TextBox();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GBCantidades = new System.Windows.Forms.GroupBox();
            this.TxbDisponible = new System.Windows.Forms.TextBox();
            this.TxbMinima = new System.Windows.Forms.TextBox();
            this.TxbMaxima = new System.Windows.Forms.TextBox();
            this.LDisponible = new System.Windows.Forms.Label();
            this.LMinima = new System.Windows.Forms.Label();
            this.LMaxima = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBDatos.SuspendLayout();
            this.GBCantidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LID.Location = new System.Drawing.Point(62, 24);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(29, 24);
            this.LID.TabIndex = 0;
            this.LID.Text = "ID";
            this.LID.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // TxbID
            // 
            this.TxbID.Enabled = false;
            this.TxbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbID.Location = new System.Drawing.Point(97, 20);
            this.TxbID.Name = "TxbID";
            this.TxbID.Size = new System.Drawing.Size(99, 32);
            this.TxbID.TabIndex = 1;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LNombre.Location = new System.Drawing.Point(6, 74);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(85, 24);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre";
            this.LNombre.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // TxbNombre
            // 
            this.TxbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbNombre.Location = new System.Drawing.Point(97, 70);
            this.TxbNombre.Name = "TxbNombre";
            this.TxbNombre.Size = new System.Drawing.Size(276, 32);
            this.TxbNombre.TabIndex = 3;
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LPrecio.Location = new System.Drawing.Point(21, 124);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(70, 24);
            this.LPrecio.TabIndex = 4;
            this.LPrecio.Text = "Precio";
            this.LPrecio.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // TxbPrecio
            // 
            this.TxbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbPrecio.Location = new System.Drawing.Point(97, 120);
            this.TxbPrecio.Name = "TxbPrecio";
            this.TxbPrecio.Size = new System.Drawing.Size(107, 32);
            this.TxbPrecio.TabIndex = 5;
            // 
            // GBDatos
            // 
            this.GBDatos.Controls.Add(this.pictureBox1);
            this.GBDatos.Controls.Add(this.BtnCancelar);
            this.GBDatos.Controls.Add(this.GBCantidades);
            this.GBDatos.Controls.Add(this.BtnEliminar);
            this.GBDatos.Controls.Add(this.BtnGuardar);
            this.GBDatos.Controls.Add(this.TxbPrecio);
            this.GBDatos.Controls.Add(this.BtnConsultar);
            this.GBDatos.Controls.Add(this.LPrecio);
            this.GBDatos.Controls.Add(this.BtnAtras);
            this.GBDatos.Controls.Add(this.TxbNombre);
            this.GBDatos.Controls.Add(this.LNombre);
            this.GBDatos.Controls.Add(this.TxbID);
            this.GBDatos.Controls.Add(this.LID);
            this.GBDatos.Location = new System.Drawing.Point(12, 7);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(970, 203);
            this.GBDatos.TabIndex = 0;
            this.GBDatos.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(477, 162);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(92, 35);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.BtnCancelar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // GBCantidades
            // 
            this.GBCantidades.Controls.Add(this.TxbDisponible);
            this.GBCantidades.Controls.Add(this.TxbMinima);
            this.GBCantidades.Controls.Add(this.TxbMaxima);
            this.GBCantidades.Controls.Add(this.LDisponible);
            this.GBCantidades.Controls.Add(this.LMinima);
            this.GBCantidades.Controls.Add(this.LMaxima);
            this.GBCantidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCantidades.Location = new System.Drawing.Point(379, 19);
            this.GBCantidades.Name = "GBCantidades";
            this.GBCantidades.Size = new System.Drawing.Size(425, 112);
            this.GBCantidades.TabIndex = 6;
            this.GBCantidades.TabStop = false;
            this.GBCantidades.Text = "Cantidad";
            // 
            // TxbDisponible
            // 
            this.TxbDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbDisponible.Location = new System.Drawing.Point(10, 60);
            this.TxbDisponible.Name = "TxbDisponible";
            this.TxbDisponible.Size = new System.Drawing.Size(100, 32);
            this.TxbDisponible.TabIndex = 1;
            this.TxbDisponible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // TxbMinima
            // 
            this.TxbMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbMinima.Location = new System.Drawing.Point(160, 60);
            this.TxbMinima.Name = "TxbMinima";
            this.TxbMinima.Size = new System.Drawing.Size(100, 32);
            this.TxbMinima.TabIndex = 3;
            this.TxbMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // TxbMaxima
            // 
            this.TxbMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbMaxima.Location = new System.Drawing.Point(310, 60);
            this.TxbMaxima.Name = "TxbMaxima";
            this.TxbMaxima.Size = new System.Drawing.Size(100, 32);
            this.TxbMaxima.TabIndex = 5;
            this.TxbMaxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // LDisponible
            // 
            this.LDisponible.AutoSize = true;
            this.LDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LDisponible.Location = new System.Drawing.Point(10, 33);
            this.LDisponible.Name = "LDisponible";
            this.LDisponible.Size = new System.Drawing.Size(109, 24);
            this.LDisponible.TabIndex = 0;
            this.LDisponible.Text = "Disponible";
            this.LDisponible.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LMinima
            // 
            this.LMinima.AutoSize = true;
            this.LMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LMinima.Location = new System.Drawing.Point(160, 33);
            this.LMinima.Name = "LMinima";
            this.LMinima.Size = new System.Drawing.Size(77, 24);
            this.LMinima.TabIndex = 2;
            this.LMinima.Text = "Mínima";
            this.LMinima.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LMaxima
            // 
            this.LMaxima.AutoSize = true;
            this.LMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LMaxima.Location = new System.Drawing.Point(310, 33);
            this.LMaxima.Name = "LMaxima";
            this.LMaxima.Size = new System.Drawing.Size(82, 24);
            this.LMaxima.TabIndex = 4;
            this.LMaxima.Text = "Máxima";
            this.LMaxima.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(614, 162);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(92, 35);
            this.BtnEliminar.TabIndex = 9;
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
            this.BtnGuardar.Location = new System.Drawing.Point(379, 162);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 35);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.BtnGuardar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(712, 162);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(92, 35);
            this.BtnConsultar.TabIndex = 10;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            this.BtnConsultar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(872, 162);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(92, 35);
            this.BtnAtras.TabIndex = 11;
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            this.BtnAtras.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // DGVProductos
            // 
            this.DGVProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVProductos.Location = new System.Drawing.Point(12, 216);
            this.DGVProductos.MultiSelect = false;
            this.DGVProductos.Name = "DGVProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(970, 315);
            this.DGVProductos.TabIndex = 36;
            this.DGVProductos.TabStop = false;
            this.DGVProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVProductos_CellMouseDoubleClick);
            this.DGVProductos.SelectionChanged += new System.EventHandler(this.DGVProductos_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(817, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 130);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 543);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.GBDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productos";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmProductos_KeyUp);
            this.GBDatos.ResumeLayout(false);
            this.GBDatos.PerformLayout();
            this.GBCantidades.ResumeLayout(false);
            this.GBCantidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.TextBox TxbID;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TxbNombre;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.TextBox TxbPrecio;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.GroupBox GBCantidades;
        private System.Windows.Forms.TextBox TxbMinima;
        private System.Windows.Forms.TextBox TxbMaxima;
        private System.Windows.Forms.Label LMinima;
        private System.Windows.Forms.Label LMaxima;
        private System.Windows.Forms.TextBox TxbDisponible;
        private System.Windows.Forms.Label LDisponible;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}