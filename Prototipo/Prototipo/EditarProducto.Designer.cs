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
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbTipoMedida = new System.Windows.Forms.ComboBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbPrecioU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.lbRegistro = new System.Windows.Forms.Label();
            this.tbRazon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRegistro.SuspendLayout();
            this.pnTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRegistro
            // 
            this.pnRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnRegistro.Controls.Add(this.tbRazon);
            this.pnRegistro.Controls.Add(this.label5);
            this.pnRegistro.Controls.Add(this.btnEditar);
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
            this.pnRegistro.Location = new System.Drawing.Point(26, 43);
            this.pnRegistro.Name = "pnRegistro";
            this.pnRegistro.Size = new System.Drawing.Size(565, 793);
            this.pnRegistro.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(234, 705);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 45);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // cbTipoMedida
            // 
            this.cbTipoMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMedida.FormattingEnabled = true;
            this.cbTipoMedida.Items.AddRange(new object[] {
            "Unidades",
            "Kilogramos"});
            this.cbTipoMedida.Location = new System.Drawing.Point(33, 496);
            this.cbTipoMedida.Name = "cbTipoMedida";
            this.cbTipoMedida.Size = new System.Drawing.Size(495, 30);
            this.cbTipoMedida.TabIndex = 3;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(33, 396);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(495, 28);
            this.tbCantidad.TabIndex = 12;
            // 
            // tbPrecioU
            // 
            this.tbPrecioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioU.Location = new System.Drawing.Point(33, 295);
            this.tbPrecioU.Name = "tbPrecioU";
            this.tbPrecioU.Size = new System.Drawing.Size(495, 28);
            this.tbPrecioU.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio Unitario";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(33, 190);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(495, 28);
            this.tbDescripcion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(33, 86);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(495, 28);
            this.tbCodigo.TabIndex = 5;
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
            // pnTitulo
            // 
            this.pnTitulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnTitulo.Controls.Add(this.lbRegistro);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(563, 32);
            this.pnTitulo.TabIndex = 3;
            // 
            // lbRegistro
            // 
            this.lbRegistro.AutoSize = true;
            this.lbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRegistro.Location = new System.Drawing.Point(3, 0);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(145, 25);
            this.lbRegistro.TabIndex = 1;
            this.lbRegistro.Text = "Editar Producto";
            // 
            // tbRazon
            // 
            this.tbRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRazon.Location = new System.Drawing.Point(33, 587);
            this.tbRazon.Name = "tbRazon";
            this.tbRazon.Size = new System.Drawing.Size(495, 28);
            this.tbRazon.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Razón del cambio";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(231, 877);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 10);
            this.panel1.TabIndex = 15;
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(622, 899);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnRegistro);
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
        private System.Windows.Forms.ComboBox cbTipoMedida;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbPrecioU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.Label lbRegistro;
        private System.Windows.Forms.TextBox tbRazon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}