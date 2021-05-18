namespace ArqueCaf
{
    partial class FrmSProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSProductos));
            this.LNombre = new System.Windows.Forms.Label();
            this.TxbNombre = new System.Windows.Forms.TextBox();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.GBDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LNombre.Location = new System.Drawing.Point(6, 24);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(85, 24);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre";
            this.LNombre.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // TxbNombre
            // 
            this.TxbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbNombre.Location = new System.Drawing.Point(97, 20);
            this.TxbNombre.Name = "TxbNombre";
            this.TxbNombre.Size = new System.Drawing.Size(297, 32);
            this.TxbNombre.TabIndex = 3;
            this.TxbNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbNombre_KeyUp);
            // 
            // GBDatos
            // 
            this.GBDatos.Controls.Add(this.BtnAtras);
            this.GBDatos.Controls.Add(this.TxbNombre);
            this.GBDatos.Controls.Add(this.LNombre);
            this.GBDatos.Location = new System.Drawing.Point(12, 7);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(400, 110);
            this.GBDatos.TabIndex = 0;
            this.GBDatos.TabStop = false;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(302, 69);
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
            this.DGVProductos.Location = new System.Drawing.Point(12, 123);
            this.DGVProductos.MultiSelect = false;
            this.DGVProductos.Name = "DGVProductos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProductos.Size = new System.Drawing.Size(970, 408);
            this.DGVProductos.TabIndex = 36;
            this.DGVProductos.TabStop = false;
            this.DGVProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVProductos_CellMouseDoubleClick);
            // 
            // FrmSProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 543);
            this.Controls.Add(this.DGVProductos);
            this.Controls.Add(this.GBDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmSProductos_KeyUp);
            this.GBDatos.ResumeLayout(false);
            this.GBDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TxbNombre;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.DataGridView DGVProductos;
    }
}