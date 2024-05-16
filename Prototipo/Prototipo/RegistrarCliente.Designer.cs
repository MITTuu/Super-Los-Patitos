namespace Prototipo.Prototipo
{
    partial class RegistrarCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoI = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lbTipoI = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.tbIdentificación = new System.Windows.Forms.TextBox();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.tbApellido2 = new System.Windows.Forms.TextBox();
            this.lbApellido2 = new System.Windows.Forms.Label();
            this.tbApellido1 = new System.Windows.Forms.TextBox();
            this.lbApellido1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTipoI);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.tbTelefono);
            this.panel1.Controls.Add(this.lbTipoI);
            this.panel1.Controls.Add(this.lbTelefono);
            this.panel1.Controls.Add(this.tbCorreo);
            this.panel1.Controls.Add(this.lbCorreo);
            this.panel1.Controls.Add(this.tbIdentificación);
            this.panel1.Controls.Add(this.lbIdentificacion);
            this.panel1.Controls.Add(this.tbApellido2);
            this.panel1.Controls.Add(this.lbApellido2);
            this.panel1.Controls.Add(this.tbApellido1);
            this.panel1.Controls.Add(this.lbApellido1);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 630);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Registrar cliente";
            // 
            // cbTipoI
            // 
            this.cbTipoI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoI.FormattingEnabled = true;
            this.cbTipoI.Items.AddRange(new object[] {
            "",
            "Cédula Física",
            "Cédula Jurídica",
            "Cédula Dímex",
            "Nite"});
            this.cbTipoI.Location = new System.Drawing.Point(447, 259);
            this.cbTipoI.Name = "cbTipoI";
            this.cbTipoI.Size = new System.Drawing.Size(279, 33);
            this.cbTipoI.TabIndex = 22;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(520, 549);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(126, 57);
            this.btnCrear.TabIndex = 21;
            this.btnCrear.Text = "Registrar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(447, 401);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(279, 30);
            this.tbTelefono.TabIndex = 18;
            // 
            // lbTipoI
            // 
            this.lbTipoI.AutoSize = true;
            this.lbTipoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoI.Location = new System.Drawing.Point(442, 231);
            this.lbTipoI.Name = "lbTipoI";
            this.lbTipoI.Size = new System.Drawing.Size(195, 25);
            this.lbTipoI.TabIndex = 16;
            this.lbTipoI.Text = "Tipo de identificación";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(442, 373);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(89, 25);
            this.lbTelefono.TabIndex = 15;
            this.lbTelefono.Text = "Teléfono";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(47, 401);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(279, 30);
            this.tbCorreo.TabIndex = 12;
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(44, 373);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(72, 25);
            this.lbCorreo.TabIndex = 11;
            this.lbCorreo.Text = "Correo";
            // 
            // tbIdentificación
            // 
            this.tbIdentificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdentificación.Location = new System.Drawing.Point(47, 259);
            this.tbIdentificación.Name = "tbIdentificación";
            this.tbIdentificación.Size = new System.Drawing.Size(279, 30);
            this.tbIdentificación.TabIndex = 10;
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentificacion.Location = new System.Drawing.Point(45, 231);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(125, 25);
            this.lbIdentificacion.TabIndex = 9;
            this.lbIdentificacion.Text = "Identificación";
            // 
            // tbApellido2
            // 
            this.tbApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido2.Location = new System.Drawing.Point(847, 117);
            this.tbApellido2.Name = "tbApellido2";
            this.tbApellido2.Size = new System.Drawing.Size(279, 30);
            this.tbApellido2.TabIndex = 8;
            // 
            // lbApellido2
            // 
            this.lbApellido2.AutoSize = true;
            this.lbApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido2.Location = new System.Drawing.Point(842, 89);
            this.lbApellido2.Name = "lbApellido2";
            this.lbApellido2.Size = new System.Drawing.Size(167, 25);
            this.lbApellido2.TabIndex = 7;
            this.lbApellido2.Text = "Segundo Apellido";
            // 
            // tbApellido1
            // 
            this.tbApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido1.Location = new System.Drawing.Point(447, 117);
            this.tbApellido1.Name = "tbApellido1";
            this.tbApellido1.Size = new System.Drawing.Size(279, 30);
            this.tbApellido1.TabIndex = 6;
            // 
            // lbApellido1
            // 
            this.lbApellido1.AutoSize = true;
            this.lbApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido1.Location = new System.Drawing.Point(442, 89);
            this.lbApellido1.Name = "lbApellido1";
            this.lbApellido1.Size = new System.Drawing.Size(143, 25);
            this.lbApellido1.TabIndex = 5;
            this.lbApellido1.Text = "Primer Apellido";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(47, 117);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(279, 30);
            this.tbNombre.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(45, 89);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(81, 25);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1217, 657);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarCliente_FormClosing);
            this.Load += new System.EventHandler(this.RegistrarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoI;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lbTipoI;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox tbIdentificación;
        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.TextBox tbApellido2;
        private System.Windows.Forms.Label lbApellido2;
        private System.Windows.Forms.TextBox tbApellido1;
        private System.Windows.Forms.Label lbApellido1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
    }
}