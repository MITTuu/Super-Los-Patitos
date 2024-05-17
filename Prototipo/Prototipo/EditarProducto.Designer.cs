namespace Prototipo.Prototipo
{
    partial class EditarProducto
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
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.cbTipoMedida = new System.Windows.Forms.ComboBox();
            this.tbPrecioU = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.lbRegistro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lID = new System.Windows.Forms.Label();
            this.pnRegistro.SuspendLayout();
            this.pnTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRegistro
            // 
            this.pnRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnRegistro.Controls.Add(this.lID);
            this.pnRegistro.Controls.Add(this.tbCantidad);
            this.pnRegistro.Controls.Add(this.cbTipoMedida);
            this.pnRegistro.Controls.Add(this.tbPrecioU);
            this.pnRegistro.Controls.Add(this.tbNombre);
            this.pnRegistro.Controls.Add(this.tbCodigo);
            this.pnRegistro.Controls.Add(this.btnEditar);
            this.pnRegistro.Controls.Add(this.label4);
            this.pnRegistro.Controls.Add(this.label3);
            this.pnRegistro.Controls.Add(this.label2);
            this.pnRegistro.Controls.Add(this.label1);
            this.pnRegistro.Controls.Add(this.lbCodigo);
            this.pnRegistro.Controls.Add(this.pnTitulo);
            this.pnRegistro.Location = new System.Drawing.Point(24, 20);
            this.pnRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.pnRegistro.Name = "pnRegistro";
            this.pnRegistro.Size = new System.Drawing.Size(567, 334);
            this.pnRegistro.TabIndex = 3;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(438, 219);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.tbCantidad.MaxLength = 8;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.ReadOnly = true;
            this.tbCantidad.Size = new System.Drawing.Size(96, 24);
            this.tbCantidad.TabIndex = 19;
            this.tbCantidad.Text = "0";
            // 
            // cbTipoMedida
            // 
            this.cbTipoMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMedida.FormattingEnabled = true;
            this.cbTipoMedida.Items.AddRange(new object[] {
            "unidad",
            "kilogramo"});
            this.cbTipoMedida.Location = new System.Drawing.Point(293, 219);
            this.cbTipoMedida.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoMedida.Name = "cbTipoMedida";
            this.cbTipoMedida.Size = new System.Drawing.Size(120, 25);
            this.cbTipoMedida.TabIndex = 18;
            this.cbTipoMedida.SelectedIndexChanged += new System.EventHandler(this.cbTipoMedida_SelectedIndexChanged);
            // 
            // tbPrecioU
            // 
            this.tbPrecioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioU.Location = new System.Drawing.Point(173, 218);
            this.tbPrecioU.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrecioU.MaxLength = 50;
            this.tbPrecioU.Name = "tbPrecioU";
            this.tbPrecioU.Size = new System.Drawing.Size(96, 24);
            this.tbPrecioU.TabIndex = 17;
            this.tbPrecioU.Text = "0";
            this.tbPrecioU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckOnlyDecimalKeyPress);
            this.tbPrecioU.Leave += new System.EventHandler(this.tbPrecioU_Leave);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(23, 134);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.MaxLength = 100;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(511, 24);
            this.tbNombre.TabIndex = 16;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(23, 218);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigo.MaxLength = 50;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(130, 24);
            this.tbCodigo.TabIndex = 15;
            this.tbCodigo.Text = "0";
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckOnlyIntKeyPress);
            this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(210, 271);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(143, 37);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Guardar Cambios";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(20, 184);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(62, 18);
            this.lbCodigo.TabIndex = 4;
            this.lbCodigo.Text = "Código";
            // 
            // pnTitulo
            // 
            this.pnTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnTitulo.Controls.Add(this.lbRegistro);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(565, 26);
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
            this.lbRegistro.Size = new System.Drawing.Size(119, 20);
            this.lbRegistro.TabIndex = 1;
            this.lbRegistro.Text = "Editar Producto";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(173, 713);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 8);
            this.panel1.TabIndex = 15;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lID.Location = new System.Drawing.Point(20, 53);
            this.lID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(61, 18);
            this.lID.TabIndex = 20;
            this.lID.Text = "ID: ###";
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(619, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnRegistro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProducto";
            this.pnRegistro.ResumeLayout(false);
            this.pnRegistro.PerformLayout();
            this.pnTitulo.ResumeLayout(false);
            this.pnTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRegistro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.Label lbRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrecioU;
        private System.Windows.Forms.ComboBox cbTipoMedida;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lID;
    }
}