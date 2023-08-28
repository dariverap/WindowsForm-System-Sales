namespace FerreteriaYerias
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnImprimirTerminar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.txtProductoCodigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFerreteriaDireccion = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFerreteria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmpleadoID = new System.Windows.Forms.TextBox();
            this.txtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoDocumentoVenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Location = new System.Drawing.Point(954, 330);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(13, 13);
            this.lblTotalProductos.TabIndex = 57;
            this.lblTotalProductos.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(863, 330);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 13);
            this.label28.TabIndex = 54;
            this.label28.Text = "Total Items:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(382, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 23);
            this.label26.TabIndex = 49;
            this.label26.Text = "Tipo Pago:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(699, 511);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(14, 13);
            this.lblSubTotal.TabIndex = 46;
            this.lblSubTotal.Text = "0";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(814, 511);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(14, 13);
            this.lblIGV.TabIndex = 48;
            this.lblIGV.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(938, 511);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 13);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(875, 511);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 45;
            this.label25.Text = "Total : S/.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(759, 511);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "IGV : S/.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(601, 511);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Sub Total : S/.";
            // 
            // btnImprimirTerminar
            // 
            this.btnImprimirTerminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnImprimirTerminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirTerminar.ForeColor = System.Drawing.Color.Black;
            this.btnImprimirTerminar.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirTerminar.Image")));
            this.btnImprimirTerminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirTerminar.Location = new System.Drawing.Point(610, 536);
            this.btnImprimirTerminar.Name = "btnImprimirTerminar";
            this.btnImprimirTerminar.Size = new System.Drawing.Size(155, 33);
            this.btnImprimirTerminar.TabIndex = 17;
            this.btnImprimirTerminar.Text = "Imprimir y Terminar";
            this.btnImprimirTerminar.UseVisualStyleBackColor = false;
            this.btnImprimirTerminar.Click += new System.EventHandler(this.btnImprimirTerminar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.txtApellidoCliente);
            this.gbCliente.Controls.Add(this.btnGuardarCliente);
            this.gbCliente.Controls.Add(this.label22);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.label20);
            this.gbCliente.Controls.Add(this.txtDocumentoCliente);
            this.gbCliente.Controls.Add(this.label19);
            this.gbCliente.Controls.Add(this.cboTipoDocumentoCliente);
            this.gbCliente.Controls.Add(this.label18);
            this.gbCliente.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(24, 165);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(950, 79);
            this.gbCliente.TabIndex = 42;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "DATOS DEL CLIENTE";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.Location = new System.Drawing.Point(725, 39);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarCliente.TabIndex = 13;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(314, 41);
            this.txtApellidoCliente.MaxLength = 50;
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(172, 21);
            this.txtApellidoCliente.TabIndex = 11;
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoCliente_KeyPress);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCliente.Image")));
            this.btnGuardarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCliente.Location = new System.Drawing.Point(842, 39);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(93, 23);
            this.btnGuardarCliente.TabIndex = 14;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(310, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 23);
            this.label22.TabIndex = 4;
            this.label22.Text = "Apellido";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(514, 41);
            this.txtNombreCliente.MaxLength = 50;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(185, 21);
            this.txtNombreCliente.TabIndex = 12;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(510, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 23);
            this.label20.TabIndex = 2;
            this.label20.Text = "Nombre";
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoCliente.Location = new System.Drawing.Point(166, 41);
            this.txtDocumentoCliente.MaxLength = 11;
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(121, 21);
            this.txtDocumentoCliente.TabIndex = 10;
            this.txtDocumentoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumentoCliente_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(162, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 23);
            this.label19.TabIndex = 2;
            this.label19.Text = "N° Documento";
            // 
            // cboTipoDocumentoCliente
            // 
            this.cboTipoDocumentoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTipoDocumentoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocumentoCliente.FormattingEnabled = true;
            this.cboTipoDocumentoCliente.Items.AddRange(new object[] {
            "DNI",
            "RUC"});
            this.cboTipoDocumentoCliente.Location = new System.Drawing.Point(14, 42);
            this.cboTipoDocumentoCliente.Name = "cboTipoDocumentoCliente";
            this.cboTipoDocumentoCliente.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDocumentoCliente.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 23);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tipo Documento";
            // 
            // dgvVenta
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.Location = new System.Drawing.Point(24, 346);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(950, 150);
            this.dgvVenta.TabIndex = 41;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.btnAgregarProducto);
            this.gbProducto.Controls.Add(this.txtCantidad);
            this.gbProducto.Controls.Add(this.txtPrecioUnidad);
            this.gbProducto.Controls.Add(this.txtStock);
            this.gbProducto.Controls.Add(this.txtProductoNombre);
            this.gbProducto.Controls.Add(this.txtProductoCodigo);
            this.gbProducto.Controls.Add(this.label15);
            this.gbProducto.Controls.Add(this.label16);
            this.gbProducto.Controls.Add(this.label14);
            this.gbProducto.Controls.Add(this.btnBuscarProducto);
            this.gbProducto.Controls.Add(this.label13);
            this.gbProducto.Controls.Add(this.Label12);
            this.gbProducto.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.Location = new System.Drawing.Point(24, 250);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(950, 77);
            this.gbProducto.TabIndex = 37;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "DATOS DEL PRODUCTO";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(825, 35);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(110, 25);
            this.btnAgregarProducto.TabIndex = 16;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(577, 39);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(89, 21);
            this.txtCantidad.TabIndex = 19;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioUnidad.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnidad.Location = new System.Drawing.Point(446, 41);
            this.txtPrecioUnidad.Multiline = true;
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.ReadOnly = true;
            this.txtPrecioUnidad.Size = new System.Drawing.Size(99, 20);
            this.txtPrecioUnidad.TabIndex = 18;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Control;
            this.txtStock.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(325, 41);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(90, 20);
            this.txtStock.TabIndex = 16;
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductoNombre.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoNombre.Location = new System.Drawing.Point(131, 41);
            this.txtProductoNombre.Multiline = true;
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.ReadOnly = true;
            this.txtProductoNombre.Size = new System.Drawing.Size(165, 20);
            this.txtProductoNombre.TabIndex = 15;
            // 
            // txtProductoCodigo
            // 
            this.txtProductoCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductoCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductoCodigo.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoCodigo.Location = new System.Drawing.Point(14, 41);
            this.txtProductoCodigo.Multiline = true;
            this.txtProductoCodigo.Name = "txtProductoCodigo";
            this.txtProductoCodigo.ReadOnly = true;
            this.txtProductoCodigo.Size = new System.Drawing.Size(90, 20);
            this.txtProductoCodigo.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(130, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "Nombre";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 23);
            this.label16.TabIndex = 2;
            this.label16.Text = "Código";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(324, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Stock:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.Location = new System.Drawing.Point(702, 36);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(102, 24);
            this.btnBuscarProducto.TabIndex = 15;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(442, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "Precio Unidad:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(573, 24);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(65, 23);
            this.Label12.TabIndex = 10;
            this.Label12.Text = "Cantidad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFerreteriaDireccion);
            this.groupBox2.Controls.Add(this.txtRUC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFerreteria);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 71);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA FERRETERÍA";
            // 
            // txtFerreteriaDireccion
            // 
            this.txtFerreteriaDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtFerreteriaDireccion.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFerreteriaDireccion.Location = new System.Drawing.Point(437, 35);
            this.txtFerreteriaDireccion.Multiline = true;
            this.txtFerreteriaDireccion.Name = "txtFerreteriaDireccion";
            this.txtFerreteriaDireccion.ReadOnly = true;
            this.txtFerreteriaDireccion.Size = new System.Drawing.Size(242, 20);
            this.txtFerreteriaDireccion.TabIndex = 5;
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.SystemColors.Control;
            this.txtRUC.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.Location = new System.Drawing.Point(224, 35);
            this.txtRUC.Multiline = true;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.ReadOnly = true;
            this.txtRUC.Size = new System.Drawing.Size(178, 20);
            this.txtRUC.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Dirección";
            // 
            // txtFerreteria
            // 
            this.txtFerreteria.BackColor = System.Drawing.SystemColors.Control;
            this.txtFerreteria.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFerreteria.Location = new System.Drawing.Point(11, 35);
            this.txtFerreteria.Multiline = true;
            this.txtFerreteria.Name = "txtFerreteria";
            this.txtFerreteria.ReadOnly = true;
            this.txtFerreteria.Size = new System.Drawing.Size(178, 20);
            this.txtFerreteria.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(220, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "RUC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmpleadoID);
            this.groupBox1.Controls.Add(this.txtEmpleadoNombre);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 70);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL EMPLEADO";
            // 
            // txtEmpleadoID
            // 
            this.txtEmpleadoID.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmpleadoID.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoID.Location = new System.Drawing.Point(17, 37);
            this.txtEmpleadoID.Multiline = true;
            this.txtEmpleadoID.Name = "txtEmpleadoID";
            this.txtEmpleadoID.ReadOnly = true;
            this.txtEmpleadoID.Size = new System.Drawing.Size(71, 20);
            this.txtEmpleadoID.TabIndex = 7;
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmpleadoNombre.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(122, 37);
            this.txtEmpleadoNombre.Multiline = true;
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.ReadOnly = true;
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(243, 20);
            this.txtEmpleadoNombre.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(14, 21);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(22, 23);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.BackColor = System.Drawing.Color.White;
            this.lblRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuc.Location = new System.Drawing.Point(790, 17);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(88, 13);
            this.lblRuc.TabIndex = 34;
            this.lblRuc.Text = "20601574862 ";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.BackColor = System.Drawing.Color.White;
            this.lblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.ForeColor = System.Drawing.Color.Red;
            this.lblNroDocumento.Location = new System.Drawing.Point(790, 61);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(86, 13);
            this.lblNroDocumento.TabIndex = 33;
            this.lblNroDocumento.Text = "Autogenerado";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Location = new System.Drawing.Point(729, 56);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(202, 23);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "NRO:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(729, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Documento de Venta";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(729, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "RUC:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.BackColor = System.Drawing.SystemColors.Control;
            this.txtFechaVenta.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVenta.Location = new System.Drawing.Point(202, 38);
            this.txtFechaVenta.Multiline = true;
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.ReadOnly = true;
            this.txtFechaVenta.Size = new System.Drawing.Size(155, 20);
            this.txtFechaVenta.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fecha de Venta";
            // 
            // cboTipoDocumentoVenta
            // 
            this.cboTipoDocumentoVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTipoDocumentoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumentoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocumentoVenta.FormattingEnabled = true;
            this.cboTipoDocumentoVenta.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cboTipoDocumentoVenta.Location = new System.Drawing.Point(19, 36);
            this.cboTipoDocumentoVenta.Name = "cboTipoDocumentoVenta";
            this.cboTipoDocumentoVenta.Size = new System.Drawing.Size(148, 21);
            this.cboTipoDocumentoVenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tipo de Comprobante";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Deposito",
            "Plin",
            "Yape"});
            this.cboTipoPago.Location = new System.Drawing.Point(386, 38);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(147, 21);
            this.cboTipoPago.TabIndex = 2;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarVenta.Image")));
            this.btnCancelarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarVenta.Location = new System.Drawing.Point(804, 536);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(155, 33);
            this.btnCancelarVenta.TabIndex = 18;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFechaVenta);
            this.groupBox3.Controls.Add(this.cboTipoDocumentoVenta);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboTipoPago);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(426, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 70);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DEL DOCUMENTO DE VENTA";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(997, 586);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.lblTotalProductos);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnImprimirTerminar);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnImprimirTerminar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboTipoDocumentoCliente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvVenta;
        internal System.Windows.Forms.GroupBox gbProducto;
        internal System.Windows.Forms.Button btnAgregarProducto;
        internal System.Windows.Forms.NumericUpDown txtCantidad;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtPrecioUnidad;
        internal System.Windows.Forms.TextBox txtStock;
        internal System.Windows.Forms.Button btnBuscarProducto;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtProductoNombre;
        internal System.Windows.Forms.TextBox txtProductoCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFerreteriaDireccion;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFerreteria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmpleadoID;
        private System.Windows.Forms.TextBox txtEmpleadoNombre;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRuc;
        internal System.Windows.Forms.Label lblNroDocumento;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoDocumentoVenta;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnGuardarCliente;
        internal System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox gbCliente;
        internal System.Windows.Forms.TextBox txtApellidoCliente;
        internal System.Windows.Forms.TextBox txtNombreCliente;
        internal System.Windows.Forms.TextBox txtDocumentoCliente;
    }
}