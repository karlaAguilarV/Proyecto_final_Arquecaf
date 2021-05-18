namespace ArqueCaf
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.TxbID = new System.Windows.Forms.TextBox();
            this.LID = new System.Windows.Forms.Label();
            this.GBProducto = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxbMinimo = new System.Windows.Forms.TextBox();
            this.TxbMaximo = new System.Windows.Forms.TextBox();
            this.LMinima = new System.Windows.Forms.Label();
            this.LMaxima = new System.Windows.Forms.Label();
            this.TxbDisponible = new System.Windows.Forms.TextBox();
            this.LDisponible = new System.Windows.Forms.Label();
            this.TxbNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LRazon = new System.Windows.Forms.Label();
            this.TxbCantidad = new System.Windows.Forms.TextBox();
            this.CBRazon = new System.Windows.Forms.ComboBox();
            this.LCantidad = new System.Windows.Forms.Label();
            this.PBMarca = new System.Windows.Forms.PictureBox();
            this.DGVMovimientos = new System.Windows.Forms.DataGridView();
            this.GBMovimiento = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.GBProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovimientos)).BeginInit();
            this.GBMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxbID
            // 
            this.TxbID.Enabled = false;
            this.TxbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbID.Location = new System.Drawing.Point(119, 35);
            this.TxbID.Name = "TxbID";
            this.TxbID.Size = new System.Drawing.Size(110, 32);
            this.TxbID.TabIndex = 1;
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LID.Location = new System.Drawing.Point(84, 39);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(29, 24);
            this.LID.TabIndex = 0;
            this.LID.Text = "ID";
            this.LID.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // GBProducto
            // 
            this.GBProducto.Controls.Add(this.BtnBuscar);
            this.GBProducto.Controls.Add(this.TxbMinimo);
            this.GBProducto.Controls.Add(this.TxbMaximo);
            this.GBProducto.Controls.Add(this.LMinima);
            this.GBProducto.Controls.Add(this.LMaxima);
            this.GBProducto.Controls.Add(this.TxbDisponible);
            this.GBProducto.Controls.Add(this.LDisponible);
            this.GBProducto.Controls.Add(this.TxbNombre);
            this.GBProducto.Controls.Add(this.LNombre);
            this.GBProducto.Controls.Add(this.LID);
            this.GBProducto.Controls.Add(this.TxbID);
            this.GBProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GBProducto.Location = new System.Drawing.Point(12, 0);
            this.GBProducto.Name = "GBProducto";
            this.GBProducto.Size = new System.Drawing.Size(559, 200);
            this.GBProducto.TabIndex = 0;
            this.GBProducto.TabStop = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(454, 159);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 35);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.BtnBuscar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // TxbMinimo
            // 
            this.TxbMinimo.Enabled = false;
            this.TxbMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbMinimo.Location = new System.Drawing.Point(318, 35);
            this.TxbMinimo.Name = "TxbMinimo";
            this.TxbMinimo.Size = new System.Drawing.Size(70, 32);
            this.TxbMinimo.TabIndex = 7;
            // 
            // TxbMaximo
            // 
            this.TxbMaximo.Enabled = false;
            this.TxbMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbMaximo.Location = new System.Drawing.Point(482, 35);
            this.TxbMaximo.Name = "TxbMaximo";
            this.TxbMaximo.Size = new System.Drawing.Size(70, 32);
            this.TxbMaximo.TabIndex = 9;
            // 
            // LMinima
            // 
            this.LMinima.AutoSize = true;
            this.LMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LMinima.Location = new System.Drawing.Point(235, 39);
            this.LMinima.Name = "LMinima";
            this.LMinima.Size = new System.Drawing.Size(77, 24);
            this.LMinima.TabIndex = 6;
            this.LMinima.Text = "Mínima";
            this.LMinima.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LMaxima
            // 
            this.LMaxima.AutoSize = true;
            this.LMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LMaxima.Location = new System.Drawing.Point(394, 39);
            this.LMaxima.Name = "LMaxima";
            this.LMaxima.Size = new System.Drawing.Size(82, 24);
            this.LMaxima.TabIndex = 8;
            this.LMaxima.Text = "Máxima";
            this.LMaxima.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // TxbDisponible
            // 
            this.TxbDisponible.Enabled = false;
            this.TxbDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbDisponible.Location = new System.Drawing.Point(119, 135);
            this.TxbDisponible.Name = "TxbDisponible";
            this.TxbDisponible.Size = new System.Drawing.Size(110, 32);
            this.TxbDisponible.TabIndex = 5;
            // 
            // LDisponible
            // 
            this.LDisponible.AutoSize = true;
            this.LDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LDisponible.Location = new System.Drawing.Point(6, 127);
            this.LDisponible.Name = "LDisponible";
            this.LDisponible.Size = new System.Drawing.Size(107, 48);
            this.LDisponible.TabIndex = 4;
            this.LDisponible.Text = "Cantidad\r\ndisponible";
            this.LDisponible.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // TxbNombre
            // 
            this.TxbNombre.Enabled = false;
            this.TxbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbNombre.Location = new System.Drawing.Point(119, 85);
            this.TxbNombre.Name = "TxbNombre";
            this.TxbNombre.Size = new System.Drawing.Size(433, 32);
            this.TxbNombre.TabIndex = 3;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LNombre.Location = new System.Drawing.Point(28, 89);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(85, 24);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre";
            this.LNombre.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LRazon
            // 
            this.LRazon.AutoSize = true;
            this.LRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LRazon.Location = new System.Drawing.Point(6, 39);
            this.LRazon.Name = "LRazon";
            this.LRazon.Size = new System.Drawing.Size(69, 24);
            this.LRazon.TabIndex = 0;
            this.LRazon.Text = "Razón";
            this.LRazon.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // TxbCantidad
            // 
            this.TxbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbCantidad.Location = new System.Drawing.Point(104, 85);
            this.TxbCantidad.Name = "TxbCantidad";
            this.TxbCantidad.Size = new System.Drawing.Size(120, 32);
            this.TxbCantidad.TabIndex = 3;
            // 
            // CBRazon
            // 
            this.CBRazon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CBRazon.FormattingEnabled = true;
            this.CBRazon.Items.AddRange(new object[] {
            "ENTRADA",
            "SALIDA"});
            this.CBRazon.Location = new System.Drawing.Point(81, 35);
            this.CBRazon.Name = "CBRazon";
            this.CBRazon.Size = new System.Drawing.Size(143, 33);
            this.CBRazon.TabIndex = 1;
            this.CBRazon.SelectedIndexChanged += new System.EventHandler(this.CB_SelectedIndexChanged);
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LCantidad.Location = new System.Drawing.Point(6, 89);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(92, 24);
            this.LCantidad.TabIndex = 2;
            this.LCantidad.Text = "Cantidad";
            this.LCantidad.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // PBMarca
            // 
            this.PBMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBMarca.BackgroundImage")));
            this.PBMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBMarca.Location = new System.Drawing.Point(813, 12);
            this.PBMarca.Name = "PBMarca";
            this.PBMarca.Size = new System.Drawing.Size(159, 188);
            this.PBMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMarca.TabIndex = 5;
            this.PBMarca.TabStop = false;
            // 
            // DGVMovimientos
            // 
            this.DGVMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMovimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVMovimientos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVMovimientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVMovimientos.Location = new System.Drawing.Point(12, 206);
            this.DGVMovimientos.MultiSelect = false;
            this.DGVMovimientos.Name = "DGVMovimientos";
            this.DGVMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMovimientos.Size = new System.Drawing.Size(960, 330);
            this.DGVMovimientos.TabIndex = 2;
            this.DGVMovimientos.TabStop = false;
            // 
            // GBMovimiento
            // 
            this.GBMovimiento.Controls.Add(this.BtnGuardar);
            this.GBMovimiento.Controls.Add(this.BtnAtras);
            this.GBMovimiento.Controls.Add(this.TxbCantidad);
            this.GBMovimiento.Controls.Add(this.LRazon);
            this.GBMovimiento.Controls.Add(this.CBRazon);
            this.GBMovimiento.Controls.Add(this.LCantidad);
            this.GBMovimiento.Location = new System.Drawing.Point(577, 0);
            this.GBMovimiento.Name = "GBMovimiento";
            this.GBMovimiento.Size = new System.Drawing.Size(230, 200);
            this.GBMovimiento.TabIndex = 1;
            this.GBMovimiento.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(10, 159);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 35);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Aplicar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.BtnGuardar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(132, 159);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(92, 35);
            this.BtnAtras.TabIndex = 5;
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            this.BtnAtras.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 541);
            this.Controls.Add(this.GBMovimiento);
            this.Controls.Add(this.DGVMovimientos);
            this.Controls.Add(this.PBMarca);
            this.Controls.Add(this.GBProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Shown += new System.EventHandler(this.FrmInventario_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmInventario_KeyUp);
            this.GBProducto.ResumeLayout(false);
            this.GBProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovimientos)).EndInit();
            this.GBMovimiento.ResumeLayout(false);
            this.GBMovimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxbID;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.GroupBox GBProducto;
        private System.Windows.Forms.PictureBox PBMarca;
        private System.Windows.Forms.DataGridView DGVMovimientos;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LDisponible;
        private System.Windows.Forms.TextBox TxbNombre;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox TxbDisponible;
        private System.Windows.Forms.ComboBox CBRazon;
        private System.Windows.Forms.TextBox TxbMinimo;
        private System.Windows.Forms.TextBox TxbMaximo;
        private System.Windows.Forms.Label LMinima;
        private System.Windows.Forms.Label LMaxima;
        private System.Windows.Forms.Label LRazon;
        private System.Windows.Forms.TextBox TxbCantidad;
        private System.Windows.Forms.GroupBox GBMovimiento;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnGuardar;
    }
}