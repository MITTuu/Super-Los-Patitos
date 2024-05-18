namespace Prototipo.Prototipo
{
    partial class PersonalCrear
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
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.cbTipoI = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
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
            this.lbtitulo = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.lbEstado);
            this.panel1.Controls.Add(this.cbRol);
            this.panel1.Controls.Add(this.cbTipoI);
            this.panel1.Controls.Add(this.btnCrear);
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
            this.panel1.Location = new System.Drawing.Point(94, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1508, 630);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.cbRol.Size = new System.Drawing.Size(279, 33);
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
            this.cbTipoI.SelectedIndexChanged += new System.EventHandler(this.cbTipoI_SelectedIndexChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(694, 552);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(104, 47);
            this.btnCrear.TabIndex = 21;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(847, 262);
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
            this.lbTipoI.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(842, 231);
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
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
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
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.Location = new System.Drawing.Point(12, 9);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(288, 38);
            this.lbtitulo.TabIndex = 5;
            this.lbtitulo.Text = "Registrar Personal\r\n";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(842, 373);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(73, 25);
            this.lbEstado.TabIndex = 24;
            this.lbEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "INACTIVO",
            "ACTIVO"});
            this.cbEstado.Location = new System.Drawing.Point(847, 401);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(279, 33);
            this.cbEstado.TabIndex = 25;
            // 
            // PersonalCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1728, 755);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalCrear";
            this.Load += new System.EventHandler(this.PersonalCrear_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox tbIdentificación;
        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.TextBox tbApellido2;
        private System.Windows.Forms.Label lbApellido2;
        private System.Windows.Forms.TextBox tbApellido1;
        private System.Windows.Forms.Label lbApellido1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTipoI;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Label lbContrasenia;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cbTipoI;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}