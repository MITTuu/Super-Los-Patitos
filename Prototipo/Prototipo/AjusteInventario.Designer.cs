namespace Prototipo.Prototipo
{
    partial class AjusteInventario
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
            this.pnRegistro = new System.Windows.Forms.Panel();
            this.nudCantidadAjuste = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.lbRegistro = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGaurdarAjuste = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRazon = new System.Windows.Forms.TextBox();
            this.btEliminarAjuste = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductosAjuste = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAjustes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAjuste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAjuste)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjustes)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRegistro
            // 
            this.pnRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnRegistro.Controls.Add(this.nudCantidadAjuste);
            this.pnRegistro.Controls.Add(this.label4);
            this.pnRegistro.Controls.Add(this.tbBusqueda);
            this.pnRegistro.Controls.Add(this.dgvProductos);
            this.pnRegistro.Controls.Add(this.pnTitulo);
            this.pnRegistro.Controls.Add(this.btnBuscar);
            this.pnRegistro.Controls.Add(this.btnAgregar);
            this.pnRegistro.Location = new System.Drawing.Point(50, 32);
            this.pnRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.pnRegistro.Name = "pnRegistro";
            this.pnRegistro.Size = new System.Drawing.Size(500, 314);
            this.pnRegistro.TabIndex = 7;
            // 
            // nudCantidadAjuste
            // 
            this.nudCantidadAjuste.Location = new System.Drawing.Point(202, 259);
            this.nudCantidadAjuste.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCantidadAjuste.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.nudCantidadAjuste.Name = "nudCantidadAjuste";
            this.nudCantidadAjuste.Size = new System.Drawing.Size(120, 20);
            this.nudCantidadAjuste.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad del ajuste:";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.Location = new System.Drawing.Point(35, 51);
            this.tbBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(343, 24);
            this.tbBusqueda.TabIndex = 9;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProductos.Location = new System.Drawing.Point(35, 103);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(427, 123);
            this.dgvProductos.TabIndex = 11;
            // 
            // pnTitulo
            // 
            this.pnTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnTitulo.Controls.Add(this.lbRegistro);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(498, 26);
            this.pnTitulo.TabIndex = 3;
            // 
            // lbRegistro
            // 
            this.lbRegistro.AutoSize = true;
            this.lbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRegistro.Location = new System.Drawing.Point(2, 0);
            this.lbRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(79, 20);
            this.lbRegistro.TabIndex = 1;
            this.lbRegistro.Text = "Inventario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(398, 44);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 37);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(341, 248);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 37);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar ajuste";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGaurdarAjuste);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbRazon);
            this.panel1.Controls.Add(this.btEliminarAjuste);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvProductosAjuste);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(613, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 574);
            this.panel1.TabIndex = 8;
            // 
            // btnGaurdarAjuste
            // 
            this.btnGaurdarAjuste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGaurdarAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaurdarAjuste.Location = new System.Drawing.Point(192, 507);
            this.btnGaurdarAjuste.Margin = new System.Windows.Forms.Padding(2);
            this.btnGaurdarAjuste.Name = "btnGaurdarAjuste";
            this.btnGaurdarAjuste.Size = new System.Drawing.Size(124, 37);
            this.btnGaurdarAjuste.TabIndex = 14;
            this.btnGaurdarAjuste.Text = "Guardar ajuste";
            this.btnGaurdarAjuste.UseVisualStyleBackColor = false;
            this.btnGaurdarAjuste.Click += new System.EventHandler(this.btnGaurdarAjuste_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 427);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Razón del ajuste";
            // 
            // tbRazon
            // 
            this.tbRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRazon.Location = new System.Drawing.Point(35, 460);
            this.tbRazon.Margin = new System.Windows.Forms.Padding(2);
            this.tbRazon.Name = "tbRazon";
            this.tbRazon.Size = new System.Drawing.Size(427, 24);
            this.tbRazon.TabIndex = 12;
            // 
            // btEliminarAjuste
            // 
            this.btEliminarAjuste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btEliminarAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarAjuste.Location = new System.Drawing.Point(147, 370);
            this.btEliminarAjuste.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminarAjuste.Name = "btEliminarAjuste";
            this.btEliminarAjuste.Size = new System.Drawing.Size(206, 37);
            this.btEliminarAjuste.TabIndex = 12;
            this.btEliminarAjuste.Text = "Eliminar ajuste de producto";
            this.btEliminarAjuste.UseVisualStyleBackColor = false;
            this.btEliminarAjuste.Click += new System.EventHandler(this.btEliminarAjuste_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Productos ajustados";
            // 
            // dgvProductosAjuste
            // 
            this.dgvProductosAjuste.AllowUserToAddRows = false;
            this.dgvProductosAjuste.AllowUserToDeleteRows = false;
            this.dgvProductosAjuste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosAjuste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAjuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProductosAjuste.Location = new System.Drawing.Point(35, 83);
            this.dgvProductosAjuste.MultiSelect = false;
            this.dgvProductosAjuste.Name = "dgvProductosAjuste";
            this.dgvProductosAjuste.ReadOnly = true;
            this.dgvProductosAjuste.RowHeadersVisible = false;
            this.dgvProductosAjuste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosAjuste.Size = new System.Drawing.Size(427, 270);
            this.dgvProductosAjuste.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 26);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Ajuste de Inventario";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvAjustes);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(49, 366);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 241);
            this.panel3.TabIndex = 17;
            // 
            // dgvAjustes
            // 
            this.dgvAjustes.AllowUserToAddRows = false;
            this.dgvAjustes.AllowUserToDeleteRows = false;
            this.dgvAjustes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAjustes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAjustes.Location = new System.Drawing.Point(35, 50);
            this.dgvAjustes.MultiSelect = false;
            this.dgvAjustes.Name = "dgvAjustes";
            this.dgvAjustes.ReadOnly = true;
            this.dgvAjustes.RowHeadersVisible = false;
            this.dgvAjustes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAjustes.Size = new System.Drawing.Size(427, 161);
            this.dgvAjustes.TabIndex = 11;
            this.dgvAjustes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAjustes_CellMouseDoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(498, 26);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Historial de Ajustes";
            // 
            // AjusteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjusteInventario";
            this.Text = "Ajuste de Inventario";
            this.pnRegistro.ResumeLayout(false);
            this.pnRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAjuste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnTitulo.ResumeLayout(false);
            this.pnTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAjuste)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjustes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRegistro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.Label lbRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProductosAjuste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRazon;
        private System.Windows.Forms.Button btEliminarAjuste;
        private System.Windows.Forms.Button btnGaurdarAjuste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudCantidadAjuste;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvAjustes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
    }
}