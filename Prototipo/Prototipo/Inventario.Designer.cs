namespace Prototipo.Prototipo
{
    partial class Inventario
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
            this.pnProductos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.lbRegistro = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrecioU = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.cbTipoMedida = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnRegistro = new System.Windows.Forms.Panel();
            this.pnProductos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnTitulo.SuspendLayout();
            this.pnRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnProductos
            // 
            this.pnProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnProductos.Controls.Add(this.btnBuscar);
            this.pnProductos.Controls.Add(this.textBox1);
            this.pnProductos.Controls.Add(this.panel2);
            this.pnProductos.Location = new System.Drawing.Point(169, 342);
            this.pnProductos.Name = "pnProductos";
            this.pnProductos.Size = new System.Drawing.Size(1414, 394);
            this.pnProductos.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(96, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 204);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Visializar los productos en inventario\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(96, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1111, 28);
            this.textBox1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1213, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 45);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1011, 91);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 45);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnTitulo
            // 
            this.pnTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnTitulo.Controls.Add(this.lbRegistro);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(1412, 32);
            this.pnTitulo.TabIndex = 3;
            // 
            // lbRegistro
            // 
            this.lbRegistro.AutoSize = true;
            this.lbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRegistro.Location = new System.Drawing.Point(3, 0);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(172, 25);
            this.lbRegistro.TabIndex = 1;
            this.lbRegistro.Text = "Registrar Producto";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(29, 49);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(73, 22);
            this.lbCodigo.TabIndex = 4;
            this.lbCodigo.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(33, 86);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(157, 28);
            this.tbCodigo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(281, 86);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(365, 28);
            this.tbDescripcion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(958, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1128, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de medida";
            // 
            // tbPrecioU
            // 
            this.tbPrecioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioU.Location = new System.Drawing.Point(722, 86);
            this.tbPrecioU.Name = "tbPrecioU";
            this.tbPrecioU.Size = new System.Drawing.Size(148, 28);
            this.tbPrecioU.TabIndex = 11;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(962, 84);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(94, 28);
            this.tbCantidad.TabIndex = 12;
            // 
            // cbTipoMedida
            // 
            this.cbTipoMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMedida.FormattingEnabled = true;
            this.cbTipoMedida.Items.AddRange(new object[] {
            "Unidades",
            "Kilogramos"});
            this.cbTipoMedida.Location = new System.Drawing.Point(1133, 83);
            this.cbTipoMedida.Name = "cbTipoMedida";
            this.cbTipoMedida.Size = new System.Drawing.Size(143, 30);
            this.cbTipoMedida.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1297, 67);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 45);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // pnRegistro
            // 
            this.pnRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnRegistro.Controls.Add(this.btnAgregar);
            this.pnRegistro.Controls.Add(this.cbTipoMedida);
            this.pnRegistro.Controls.Add(this.tbCantidad);
            this.pnRegistro.Controls.Add(this.tbPrecioU);
            this.pnRegistro.Controls.Add(this.label4);
            this.pnRegistro.Controls.Add(this.label3);
            this.pnRegistro.Controls.Add(this.label2);
            this.pnRegistro.Controls.Add(this.tbDescripcion);
            this.pnRegistro.Controls.Add(this.label1);
            this.pnRegistro.Controls.Add(this.tbCodigo);
            this.pnRegistro.Controls.Add(this.lbCodigo);
            this.pnRegistro.Controls.Add(this.pnTitulo);
            this.pnRegistro.Location = new System.Drawing.Point(168, 85);
            this.pnRegistro.Name = "pnRegistro";
            this.pnRegistro.Size = new System.Drawing.Size(1414, 141);
            this.pnRegistro.TabIndex = 2;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1750, 800);
            this.Controls.Add(this.pnProductos);
            this.Controls.Add(this.pnRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "AjustesDeInventario";
            this.pnProductos.ResumeLayout(false);
            this.pnProductos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnTitulo.ResumeLayout(false);
            this.pnTitulo.PerformLayout();
            this.pnRegistro.ResumeLayout(false);
            this.pnRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.Label lbRegistro;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrecioU;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.ComboBox cbTipoMedida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnRegistro;
    }
}