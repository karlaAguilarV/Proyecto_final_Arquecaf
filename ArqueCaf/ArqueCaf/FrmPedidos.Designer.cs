namespace ArqueCaf
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.LCliente = new System.Windows.Forms.Label();
            this.LEmpleado = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.GBPedido = new System.Windows.Forms.GroupBox();
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.LProducto = new System.Windows.Forms.Label();
            this.CBEmpleados = new System.Windows.Forms.ComboBox();
            this.CBClientes = new System.Windows.Forms.ComboBox();
            this.TxbPrecio = new System.Windows.Forms.TextBox();
            this.LPrecio = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.DgvPedidos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxbSTotal = new System.Windows.Forms.TextBox();
            this.LSTotal = new System.Windows.Forms.Label();
            this.TxbTotal = new System.Windows.Forms.TextBox();
            this.LTotal = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GBCantidades = new System.Windows.Forms.GroupBox();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.GBPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).BeginInit();
            this.GBCantidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCliente.Location = new System.Drawing.Point(9, 34);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(75, 24);
            this.LCliente.TabIndex = 0;
            this.LCliente.Text = "Cliente";
            this.LCliente.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LEmpleado
            // 
            this.LEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LEmpleado.AutoSize = true;
            this.LEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LEmpleado.Location = new System.Drawing.Point(9, 91);
            this.LEmpleado.Name = "LEmpleado";
            this.LEmpleado.Size = new System.Drawing.Size(105, 24);
            this.LEmpleado.TabIndex = 2;
            this.LEmpleado.Text = "Empleado";
            this.LEmpleado.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LFecha
            // 
            this.LFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LFecha.Location = new System.Drawing.Point(613, 34);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(69, 24);
            this.LFecha.TabIndex = 4;
            this.LFecha.Text = "Fecha";
            this.LFecha.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // DTPFecha
            // 
            this.DTPFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTPFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFecha.Location = new System.Drawing.Point(688, 30);
            this.DTPFecha.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DTPFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(154, 32);
            this.DTPFecha.TabIndex = 5;
            this.DTPFecha.TabStop = false;
            this.DTPFecha.Value = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            this.DTPFecha.ValueChanged += new System.EventHandler(this.DTPFecha_ValueChanged);
            // 
            // GBPedido
            // 
            this.GBPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBPedido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBPedido.Controls.Add(this.CBProductos);
            this.GBPedido.Controls.Add(this.LProducto);
            this.GBPedido.Controls.Add(this.CBEmpleados);
            this.GBPedido.Controls.Add(this.CBClientes);
            this.GBPedido.Controls.Add(this.DTPFecha);
            this.GBPedido.Controls.Add(this.LFecha);
            this.GBPedido.Controls.Add(this.LEmpleado);
            this.GBPedido.Controls.Add(this.LCliente);
            this.GBPedido.Location = new System.Drawing.Point(12, 12);
            this.GBPedido.Name = "GBPedido";
            this.GBPedido.Size = new System.Drawing.Size(848, 150);
            this.GBPedido.TabIndex = 0;
            this.GBPedido.TabStop = false;
            // 
            // CBProductos
            // 
            this.CBProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Location = new System.Drawing.Point(542, 87);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(300, 33);
            this.CBProductos.TabIndex = 7;
            this.CBProductos.SelectedIndexChanged += new System.EventHandler(this.CBProductos_SelectedIndexChanged);
            // 
            // LProducto
            // 
            this.LProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LProducto.AutoSize = true;
            this.LProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LProducto.Location = new System.Drawing.Point(442, 91);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(94, 24);
            this.LProducto.TabIndex = 6;
            this.LProducto.Text = "Producto";
            this.LProducto.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // CBEmpleados
            // 
            this.CBEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CBEmpleados.FormattingEnabled = true;
            this.CBEmpleados.Location = new System.Drawing.Point(120, 87);
            this.CBEmpleados.Name = "CBEmpleados";
            this.CBEmpleados.Size = new System.Drawing.Size(300, 33);
            this.CBEmpleados.TabIndex = 3;
            // 
            // CBClientes
            // 
            this.CBClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CBClientes.FormattingEnabled = true;
            this.CBClientes.Location = new System.Drawing.Point(90, 30);
            this.CBClientes.Name = "CBClientes";
            this.CBClientes.Size = new System.Drawing.Size(330, 33);
            this.CBClientes.TabIndex = 1;
            // 
            // TxbPrecio
            // 
            this.TxbPrecio.Enabled = false;
            this.TxbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbPrecio.Location = new System.Drawing.Point(14, 43);
            this.TxbPrecio.Name = "TxbPrecio";
            this.TxbPrecio.Size = new System.Drawing.Size(116, 32);
            this.TxbPrecio.TabIndex = 1;
            this.TxbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LPrecio.Location = new System.Drawing.Point(14, 16);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(70, 24);
            this.LPrecio.TabIndex = 0;
            this.LPrecio.Text = "Precio";
            this.LPrecio.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LCantidad.Location = new System.Drawing.Point(173, 16);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(92, 24);
            this.LCantidad.TabIndex = 2;
            this.LCantidad.Text = "Cantidad";
            this.LCantidad.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // DgvPedidos
            // 
            this.DgvPedidos.AllowUserToAddRows = false;
            this.DgvPedidos.AllowUserToDeleteRows = false;
            this.DgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPedidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.DgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvPedidos.Location = new System.Drawing.Point(12, 272);
            this.DgvPedidos.MultiSelect = false;
            this.DgvPedidos.Name = "DgvPedidos";
            this.DgvPedidos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPedidos.Size = new System.Drawing.Size(848, 195);
            this.DgvPedidos.TabIndex = 2;
            this.DgvPedidos.TabStop = false;
            this.DgvPedidos.SelectionChanged += new System.EventHandler(this.DgvPedidos_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // TxbSTotal
            // 
            this.TxbSTotal.Enabled = false;
            this.TxbSTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbSTotal.Location = new System.Drawing.Point(339, 43);
            this.TxbSTotal.Name = "TxbSTotal";
            this.TxbSTotal.Size = new System.Drawing.Size(116, 32);
            this.TxbSTotal.TabIndex = 5;
            this.TxbSTotal.Text = "0";
            this.TxbSTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LSTotal
            // 
            this.LSTotal.AutoSize = true;
            this.LSTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LSTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LSTotal.Location = new System.Drawing.Point(339, 16);
            this.LSTotal.Name = "LSTotal";
            this.LSTotal.Size = new System.Drawing.Size(93, 24);
            this.LSTotal.TabIndex = 4;
            this.LSTotal.Text = "SubTotal";
            this.LSTotal.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // TxbTotal
            // 
            this.TxbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxbTotal.Enabled = false;
            this.TxbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxbTotal.Location = new System.Drawing.Point(74, 492);
            this.TxbTotal.Name = "TxbTotal";
            this.TxbTotal.Size = new System.Drawing.Size(130, 32);
            this.TxbTotal.TabIndex = 4;
            this.TxbTotal.Text = "0";
            this.TxbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LTotal
            // 
            this.LTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LTotal.Location = new System.Drawing.Point(12, 492);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(56, 24);
            this.LTotal.TabIndex = 3;
            this.LTotal.Text = "Total";
            this.LTotal.MouseHover += new System.EventHandler(this.L_MouseHover);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(554, 42);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(92, 35);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            this.BtnAgregar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(652, 42);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(92, 35);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            this.BtnModificar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(750, 42);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(92, 35);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.BtnEliminar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(768, 488);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(92, 35);
            this.BtnAtras.TabIndex = 6;
            this.BtnAtras.Text = "Atrás";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            this.BtnAtras.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(572, 488);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(190, 35);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Realizar Pedido";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.BtnGuardar.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // GBCantidades
            // 
            this.GBCantidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBCantidades.Controls.Add(this.NUDCantidad);
            this.GBCantidades.Controls.Add(this.LSTotal);
            this.GBCantidades.Controls.Add(this.LPrecio);
            this.GBCantidades.Controls.Add(this.TxbPrecio);
            this.GBCantidades.Controls.Add(this.LCantidad);
            this.GBCantidades.Controls.Add(this.BtnEliminar);
            this.GBCantidades.Controls.Add(this.TxbSTotal);
            this.GBCantidades.Controls.Add(this.BtnModificar);
            this.GBCantidades.Controls.Add(this.BtnAgregar);
            this.GBCantidades.Location = new System.Drawing.Point(12, 168);
            this.GBCantidades.Name = "GBCantidades";
            this.GBCantidades.Size = new System.Drawing.Size(848, 98);
            this.GBCantidades.TabIndex = 1;
            this.GBCantidades.TabStop = false;
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NUDCantidad.Location = new System.Drawing.Point(173, 43);
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.ReadOnly = true;
            this.NUDCantidad.Size = new System.Drawing.Size(120, 32);
            this.NUDCantidad.TabIndex = 9;
            this.NUDCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDCantidad.ValueChanged += new System.EventHandler(this.NUDCantidad_ValueChanged);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 535);
            this.Controls.Add(this.GBCantidades);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.TxbTotal);
            this.Controls.Add(this.LTotal);
            this.Controls.Add(this.DgvPedidos);
            this.Controls.Add(this.GBPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Shown += new System.EventHandler(this.FrmPedidos_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmPedidos_KeyUp);
            this.GBPedido.ResumeLayout(false);
            this.GBPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidos)).EndInit();
            this.GBCantidades.ResumeLayout(false);
            this.GBCantidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Label LEmpleado;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.GroupBox GBPedido;
        private System.Windows.Forms.TextBox TxbPrecio;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.TextBox TxbSTotal;
        private System.Windows.Forms.Label LSTotal;
        private System.Windows.Forms.TextBox TxbTotal;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.ComboBox CBEmpleados;
        private System.Windows.Forms.ComboBox CBClientes;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CBProductos;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.GroupBox GBCantidades;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridView DgvPedidos;
    }
}