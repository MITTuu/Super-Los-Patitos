namespace Prototipo.Prototipo
{
    partial class PersonalModificar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.cbTipoI = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.lbTipoI = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbRol = new System.Windows.Forms.Label();
            this.lbContrasenia = new System.Windows.Forms.Label();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(718, 993);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 11);
            this.panel2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(96, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 30);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Buscar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Nombre Completo",
            "Identificación"});
            this.comboBox1.Location = new System.Drawing.Point(608, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 33);
            this.comboBox1.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(837, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 47);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(96, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1508, 196);
            this.panel3.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 75);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hacer un DataGridView para previsualizar los datos\r\nlas coincidencias con lo ingr" +
    "esado, y asi seleccionar\r\nuno para cargar su información.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.cbRol);
            this.panel1.Controls.Add(this.cbTipoI);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.tbTelefono);
            this.panel1.Controls.Add(this.tbContrasenia);
            this.panel1.Controls.Add(this.lbTipoI);
            this.panel1.Controls.Add(this.lbTelefono);
            this.panel1.Controls.Add(this.lbRol);
            this.panel1.Controls.Add(this.lbContrasenia);
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
            this.panel1.Location = new System.Drawing.Point(96, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1508, 681);
            this.panel1.TabIndex = 27;
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "",
            "Administrador de Inventario",
            "Cajero",
            "Contador"});
            this.cbRol.Location = new System.Drawing.Point(50, 552);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(292, 33);
            this.cbRol.TabIndex = 23;
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
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(680, 610);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(137, 52);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(847, 401);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(279, 30);
            this.tbTelefono.TabIndex = 18;
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasenia.Location = new System.Drawing.Point(447, 401);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(279, 30);
            this.tbContrasenia.TabIndex = 17;
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
            this.lbTelefono.Location = new System.Drawing.Point(842, 373);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(89, 25);
            this.lbTelefono.TabIndex = 15;
            this.lbTelefono.Text = "Teléfono";
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRol.Location = new System.Drawing.Point(45, 524);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(40, 25);
            this.lbRol.TabIndex = 14;
            this.lbRol.Text = "Rol";
            // 
            // lbContrasenia
            // 
            this.lbContrasenia.AutoSize = true;
            this.lbContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasenia.Location = new System.Drawing.Point(442, 373);
            this.lbContrasenia.Name = "lbContrasenia";
            this.lbContrasenia.Size = new System.Drawing.Size(114, 25);
            this.lbContrasenia.TabIndex = 13;
            this.lbContrasenia.Text = "Contraseña";
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
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(741, 1012);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 14);
            this.panel4.TabIndex = 24;
            // 
            // PersonalModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1750, 1038);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalModificar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PersonalModificar";
            this.Load += new System.EventHandler(this.PersonalModificar_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.ComboBox cbTipoI;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label lbTipoI;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Label lbContrasenia;
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
        private System.Windows.Forms.Panel panel4;
    }
}