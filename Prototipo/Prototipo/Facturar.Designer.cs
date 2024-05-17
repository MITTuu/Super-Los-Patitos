namespace Prototipo.Prototipo
{
    partial class Facturar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnFacturar = new System.Windows.Forms.Panel();
            this.lbTU = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProdSel = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbBuscarPor = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbFacturar = new System.Windows.Forms.Label();
            this.pnDetalle = new System.Windows.Forms.Panel();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.lbCantProd = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbImpuesto = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbTotales = new System.Windows.Forms.Label();
            this.DGVFactura = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbNumDoc = new System.Windows.Forms.Label();
            this.lbCajero = new System.Windows.Forms.Label();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superPatitosDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pnFacturar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superPatitosDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFacturar
            // 
            this.pnFacturar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnFacturar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFacturar.Controls.Add(this.lbTU);
            this.pnFacturar.Controls.Add(this.btnAgregar);
            this.pnFacturar.Controls.Add(this.DGVProductos);
            this.pnFacturar.Controls.Add(this.panel2);
            this.pnFacturar.Controls.Add(this.label4);
            this.pnFacturar.Controls.Add(this.tbProdSel);
            this.pnFacturar.Controls.Add(this.tbCantidad);
            this.pnFacturar.Controls.Add(this.label3);
            this.pnFacturar.Controls.Add(this.cbBuscarPor);
            this.pnFacturar.Controls.Add(this.lbProducto);
            this.pnFacturar.Controls.Add(this.lbBuscarPor);
            this.pnFacturar.Controls.Add(this.btnBuscarProducto);
            this.pnFacturar.Controls.Add(this.tbProducto);
            this.pnFacturar.Controls.Add(this.panel3);
            this.pnFacturar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnFacturar.Location = new System.Drawing.Point(39, 31);
            this.pnFacturar.Name = "pnFacturar";
            this.pnFacturar.Size = new System.Drawing.Size(718, 751);
            this.pnFacturar.TabIndex = 0;
            // 
            // lbTU
            // 
            this.lbTU.AutoSize = true;
            this.lbTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTU.Location = new System.Drawing.Point(463, 316);
            this.lbTU.Name = "lbTU";
            this.lbTU.Size = new System.Drawing.Size(0, 22);
            this.lbTU.TabIndex = 22;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(602, 308);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 39);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DGVProductos
            // 
            this.DGVProductos.AllowUserToAddRows = false;
            this.DGVProductos.AllowUserToDeleteRows = false;
            this.DGVProductos.AllowUserToResizeColumns = false;
            this.DGVProductos.AllowUserToResizeRows = false;
            this.DGVProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVProductos.Location = new System.Drawing.Point(0, 369);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.ReadOnly = true;
            this.DGVProductos.RowHeadersWidth = 51;
            this.DGVProductos.RowTemplate.Height = 24;
            this.DGVProductos.Size = new System.Drawing.Size(716, 380);
            this.DGVProductos.TabIndex = 0;
            this.DGVProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellClick);
            this.DGVProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbUsuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbTipo);
            this.panel2.Controls.Add(this.cbTipoDoc);
            this.panel2.Controls.Add(this.btnBuscarCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 143);
            this.panel2.TabIndex = 19;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(8, 90);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(290, 28);
            this.tbUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cédula del cliente:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTipo.Location = new System.Drawing.Point(4, 18);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(51, 22);
            this.lbTipo.TabIndex = 5;
            this.lbTipo.Text = "Tipo:";
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Items.AddRange(new object[] {
            "Factura",
            "Tiquete"});
            this.cbTipoDoc.Location = new System.Drawing.Point(82, 15);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(202, 30);
            this.cbTipoDoc.TabIndex = 7;
            this.cbTipoDoc.SelectedValueChanged += new System.EventHandler(this.cbTipoDoc_SelectedValueChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarCliente.Location = new System.Drawing.Point(345, 83);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(103, 43);
            this.btnBuscarCliente.TabIndex = 8;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(4, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Producto Seleccionado:";
            // 
            // tbProdSel
            // 
            this.tbProdSel.Enabled = false;
            this.tbProdSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdSel.Location = new System.Drawing.Point(8, 313);
            this.tbProdSel.Name = "tbProdSel";
            this.tbProdSel.Size = new System.Drawing.Size(290, 28);
            this.tbProdSel.TabIndex = 17;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(345, 313);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(83, 28);
            this.tbCantidad.TabIndex = 16;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(341, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad:";
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Items.AddRange(new object[] {
            "Nombre",
            "Código"});
            this.cbBuscarPor.Location = new System.Drawing.Point(345, 221);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(190, 30);
            this.cbBuscarPor.TabIndex = 14;
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbProducto.Location = new System.Drawing.Point(4, 198);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(87, 22);
            this.lbProducto.TabIndex = 13;
            this.lbProducto.Text = "Producto:";
            // 
            // lbBuscarPor
            // 
            this.lbBuscarPor.AutoSize = true;
            this.lbBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarPor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBuscarPor.Location = new System.Drawing.Point(341, 196);
            this.lbBuscarPor.Name = "lbBuscarPor";
            this.lbBuscarPor.Size = new System.Drawing.Size(102, 22);
            this.lbBuscarPor.TabIndex = 10;
            this.lbBuscarPor.Text = "Buscar por:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarProducto.Location = new System.Drawing.Point(602, 216);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(102, 39);
            this.btnBuscarProducto.TabIndex = 9;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // tbProducto
            // 
            this.tbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProducto.Location = new System.Drawing.Point(8, 223);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(290, 28);
            this.tbProducto.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.lbFacturar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(716, 33);
            this.panel3.TabIndex = 0;
            // 
            // lbFacturar
            // 
            this.lbFacturar.AutoSize = true;
            this.lbFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFacturar.Location = new System.Drawing.Point(3, 0);
            this.lbFacturar.Name = "lbFacturar";
            this.lbFacturar.Size = new System.Drawing.Size(179, 29);
            this.lbFacturar.TabIndex = 0;
            this.lbFacturar.Text = "Datos a facturar";
            // 
            // pnDetalle
            // 
            this.pnDetalle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDetalle.Controls.Add(this.btnFacturar);
            this.pnDetalle.Controls.Add(this.lbCantProd);
            this.pnDetalle.Controls.Add(this.lbTotal);
            this.pnDetalle.Controls.Add(this.lbImpuesto);
            this.pnDetalle.Controls.Add(this.lbSubtotal);
            this.pnDetalle.Controls.Add(this.lbTotales);
            this.pnDetalle.Controls.Add(this.DGVFactura);
            this.pnDetalle.Controls.Add(this.panel6);
            this.pnDetalle.Controls.Add(this.panel4);
            this.pnDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnDetalle.Location = new System.Drawing.Point(804, 31);
            this.pnDetalle.Name = "pnDetalle";
            this.pnDetalle.Size = new System.Drawing.Size(878, 751);
            this.pnDetalle.TabIndex = 1;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFacturar.Location = new System.Drawing.Point(743, 682);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(102, 39);
            this.btnFacturar.TabIndex = 23;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // lbCantProd
            // 
            this.lbCantProd.AutoSize = true;
            this.lbCantProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCantProd.Location = new System.Drawing.Point(49, 645);
            this.lbCantProd.Name = "lbCantProd";
            this.lbCantProd.Size = new System.Drawing.Size(196, 22);
            this.lbCantProd.TabIndex = 20;
            this.lbCantProd.Text = "Cantidad de productos:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotal.Location = new System.Drawing.Point(49, 682);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(56, 22);
            this.lbTotal.TabIndex = 19;
            this.lbTotal.Text = "Total:";
            // 
            // lbImpuesto
            // 
            this.lbImpuesto.AutoSize = true;
            this.lbImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpuesto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbImpuesto.Location = new System.Drawing.Point(49, 611);
            this.lbImpuesto.Name = "lbImpuesto";
            this.lbImpuesto.Size = new System.Drawing.Size(87, 22);
            this.lbImpuesto.TabIndex = 18;
            this.lbImpuesto.Text = "Impuesto:";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSubtotal.Location = new System.Drawing.Point(49, 573);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(81, 22);
            this.lbSubtotal.TabIndex = 17;
            this.lbSubtotal.Text = "Subtotal:";
            // 
            // lbTotales
            // 
            this.lbTotales.AutoSize = true;
            this.lbTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotales.Location = new System.Drawing.Point(6, 536);
            this.lbTotales.Name = "lbTotales";
            this.lbTotales.Size = new System.Drawing.Size(56, 22);
            this.lbTotales.TabIndex = 16;
            this.lbTotales.Text = "Total:";
            // 
            // DGVFactura
            // 
            this.DGVFactura.AllowUserToAddRows = false;
            this.DGVFactura.AllowUserToDeleteRows = false;
            this.DGVFactura.AllowUserToResizeColumns = false;
            this.DGVFactura.AllowUserToResizeRows = false;
            this.DGVFactura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Producto,
            this.PrecioUnitario,
            this.Cantidad,
            this.Subtotal,
            this.Impuesto,
            this.Total});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVFactura.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVFactura.Location = new System.Drawing.Point(-2, 156);
            this.DGVFactura.Name = "DGVFactura";
            this.DGVFactura.RowHeadersWidth = 51;
            this.DGVFactura.RowTemplate.Height = 24;
            this.DGVFactura.Size = new System.Drawing.Size(878, 349);
            this.DGVFactura.TabIndex = 15;
            this.DGVFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFactura_CellDoubleClick);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            this.idProducto.Visible = false;
            this.idProducto.Width = 125;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 111;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 157;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 111;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 105;
            // 
            // Impuesto
            // 
            this.Impuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.MinimumWidth = 6;
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.Width = 111;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 80;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.lbNumDoc);
            this.panel6.Controls.Add(this.lbCajero);
            this.panel6.Controls.Add(this.lbIdentificacion);
            this.panel6.Controls.Add(this.lbCliente);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(876, 130);
            this.panel6.TabIndex = 14;
            // 
            // lbNumDoc
            // 
            this.lbNumDoc.AutoSize = true;
            this.lbNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumDoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNumDoc.Location = new System.Drawing.Point(667, 14);
            this.lbNumDoc.Name = "lbNumDoc";
            this.lbNumDoc.Size = new System.Drawing.Size(145, 25);
            this.lbNumDoc.TabIndex = 16;
            this.lbNumDoc.Text = "N° Documento:";
            // 
            // lbCajero
            // 
            this.lbCajero.AutoSize = true;
            this.lbCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCajero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCajero.Location = new System.Drawing.Point(3, 7);
            this.lbCajero.Name = "lbCajero";
            this.lbCajero.Size = new System.Drawing.Size(139, 25);
            this.lbCajero.TabIndex = 15;
            this.lbCajero.Text = "Facturado por:";
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbIdentificacion.Location = new System.Drawing.Point(3, 94);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(131, 25);
            this.lbIdentificacion.TabIndex = 14;
            this.lbIdentificacion.Text = "Identificación:\r\n";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCliente.Location = new System.Drawing.Point(3, 51);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(79, 25);
            this.lbCliente.TabIndex = 13;
            this.lbCliente.Text = "Cliente:\r\n";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(876, 33);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalles de la factura";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(797, 788);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 22);
            this.panel5.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 100);
            this.panel1.TabIndex = 13;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(403, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cliente:\r\n";
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1771, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnDetalle);
            this.Controls.Add(this.pnFacturar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturar";
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.Facturar_Load);
            this.pnFacturar.ResumeLayout(false);
            this.pnFacturar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnDetalle.ResumeLayout(false);
            this.pnDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superPatitosDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFacturar;
        private System.Windows.Forms.Panel pnDetalle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lbBuscarPor;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.Label lbCajero;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.DataGridView DGVProductos;
        private System.Windows.Forms.BindingSource superPatitosDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProdSel;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbTU;
        private System.Windows.Forms.DataGridView DGVFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lbImpuesto;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbTotales;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbCantProd;
        private System.Windows.Forms.Label lbNumDoc;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label label5;
    }
}