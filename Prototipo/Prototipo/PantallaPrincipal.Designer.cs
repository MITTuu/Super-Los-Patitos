﻿namespace Prototipo.Prototipo
{
    partial class PantallaPrincipal
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
            this.pnOpciones = new System.Windows.Forms.Panel();
            this.pnInformes = new System.Windows.Forms.Panel();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnReporteFac = new System.Windows.Forms.Button();
            this.lbInformes = new System.Windows.Forms.Label();
            this.pnGestionInventario = new System.Windows.Forms.Panel();
            this.btAjusteInventario = new System.Windows.Forms.Button();
            this.btnAjustesI = new System.Windows.Forms.Button();
            this.lbGestionInventario = new System.Windows.Forms.Label();
            this.pnFacturacion = new System.Windows.Forms.Panel();
            this.btnNC = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.lbFacturacion = new System.Windows.Forms.Label();
            this.pnControlPersonal = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lbControlPersonal = new System.Windows.Forms.Label();
            this.pnCuerpo = new System.Windows.Forms.Panel();
            this.pnVentana = new System.Windows.Forms.Panel();
            this.pnEncabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCS = new System.Windows.Forms.Button();
            this.pnOpciones.SuspendLayout();
            this.pnInformes.SuspendLayout();
            this.pnGestionInventario.SuspendLayout();
            this.pnFacturacion.SuspendLayout();
            this.pnControlPersonal.SuspendLayout();
            this.pnCuerpo.SuspendLayout();
            this.pnEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnOpciones
            // 
            this.pnOpciones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnOpciones.Controls.Add(this.pnInformes);
            this.pnOpciones.Controls.Add(this.pnGestionInventario);
            this.pnOpciones.Controls.Add(this.pnFacturacion);
            this.pnOpciones.Controls.Add(this.pnControlPersonal);
            this.pnOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnOpciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnOpciones.Name = "pnOpciones";
            this.pnOpciones.Size = new System.Drawing.Size(329, 692);
            this.pnOpciones.TabIndex = 0;
            // 
            // pnInformes
            // 
            this.pnInformes.Controls.Add(this.btnGraficos);
            this.pnInformes.Controls.Add(this.btnReporteFac);
            this.pnInformes.Controls.Add(this.lbInformes);
            this.pnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInformes.Location = new System.Drawing.Point(0, 510);
            this.pnInformes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnInformes.Name = "pnInformes";
            this.pnInformes.Size = new System.Drawing.Size(329, 170);
            this.pnInformes.TabIndex = 3;
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGraficos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.Location = new System.Drawing.Point(4, 96);
            this.btnGraficos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(323, 50);
            this.btnGraficos.TabIndex = 6;
            this.btnGraficos.Text = "Gráficos";
            this.btnGraficos.UseVisualStyleBackColor = false;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // btnReporteFac
            // 
            this.btnReporteFac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReporteFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteFac.Location = new System.Drawing.Point(3, 42);
            this.btnReporteFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteFac.Name = "btnReporteFac";
            this.btnReporteFac.Size = new System.Drawing.Size(323, 50);
            this.btnReporteFac.TabIndex = 5;
            this.btnReporteFac.Text = "Reportería";
            this.btnReporteFac.UseVisualStyleBackColor = false;
            this.btnReporteFac.Click += new System.EventHandler(this.btnReporteFac_Click);
            // 
            // lbInformes
            // 
            this.lbInformes.AutoSize = true;
            this.lbInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformes.Location = new System.Drawing.Point(11, 10);
            this.lbInformes.Name = "lbInformes";
            this.lbInformes.Size = new System.Drawing.Size(106, 29);
            this.lbInformes.TabIndex = 0;
            this.lbInformes.Text = "Informes";
            // 
            // pnGestionInventario
            // 
            this.pnGestionInventario.Controls.Add(this.btAjusteInventario);
            this.pnGestionInventario.Controls.Add(this.btnAjustesI);
            this.pnGestionInventario.Controls.Add(this.lbGestionInventario);
            this.pnGestionInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGestionInventario.Location = new System.Drawing.Point(0, 340);
            this.pnGestionInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnGestionInventario.Name = "pnGestionInventario";
            this.pnGestionInventario.Size = new System.Drawing.Size(329, 170);
            this.pnGestionInventario.TabIndex = 2;
            // 
            // btAjusteInventario
            // 
            this.btAjusteInventario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btAjusteInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjusteInventario.Location = new System.Drawing.Point(3, 97);
            this.btAjusteInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAjusteInventario.Name = "btAjusteInventario";
            this.btAjusteInventario.Size = new System.Drawing.Size(323, 50);
            this.btAjusteInventario.TabIndex = 5;
            this.btAjusteInventario.Text = "Ajuste de Inventario";
            this.btAjusteInventario.UseVisualStyleBackColor = false;
            this.btAjusteInventario.Click += new System.EventHandler(this.btAjusteInventario_Click);
            // 
            // btnAjustesI
            // 
            this.btnAjustesI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAjustesI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustesI.Location = new System.Drawing.Point(3, 42);
            this.btnAjustesI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjustesI.Name = "btnAjustesI";
            this.btnAjustesI.Size = new System.Drawing.Size(323, 50);
            this.btnAjustesI.TabIndex = 4;
            this.btnAjustesI.Text = "Inventario";
            this.btnAjustesI.UseVisualStyleBackColor = false;
            this.btnAjustesI.Click += new System.EventHandler(this.btnAjustesI_Click);
            // 
            // lbGestionInventario
            // 
            this.lbGestionInventario.AutoSize = true;
            this.lbGestionInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGestionInventario.Location = new System.Drawing.Point(11, 10);
            this.lbGestionInventario.Name = "lbGestionInventario";
            this.lbGestionInventario.Size = new System.Drawing.Size(240, 29);
            this.lbGestionInventario.TabIndex = 0;
            this.lbGestionInventario.Text = "Gestión de inventario";
            // 
            // pnFacturacion
            // 
            this.pnFacturacion.Controls.Add(this.btnNC);
            this.pnFacturacion.Controls.Add(this.btnFacturar);
            this.pnFacturacion.Controls.Add(this.lbFacturacion);
            this.pnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFacturacion.Location = new System.Drawing.Point(0, 170);
            this.pnFacturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnFacturacion.Name = "pnFacturacion";
            this.pnFacturacion.Size = new System.Drawing.Size(329, 170);
            this.pnFacturacion.TabIndex = 1;
            // 
            // btnNC
            // 
            this.btnNC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNC.Location = new System.Drawing.Point(4, 106);
            this.btnNC.Margin = new System.Windows.Forms.Padding(4);
            this.btnNC.Name = "btnNC";
            this.btnNC.Size = new System.Drawing.Size(323, 46);
            this.btnNC.TabIndex = 3;
            this.btnNC.Text = "Notas de crédito";
            this.btnNC.UseVisualStyleBackColor = false;
            this.btnNC.Click += new System.EventHandler(this.btnNC_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(3, 50);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(323, 50);
            this.btnFacturar.TabIndex = 2;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // lbFacturacion
            // 
            this.lbFacturacion.AutoSize = true;
            this.lbFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturacion.Location = new System.Drawing.Point(11, 10);
            this.lbFacturacion.Name = "lbFacturacion";
            this.lbFacturacion.Size = new System.Drawing.Size(138, 29);
            this.lbFacturacion.TabIndex = 0;
            this.lbFacturacion.Text = "Facturación";
            // 
            // pnControlPersonal
            // 
            this.pnControlPersonal.Controls.Add(this.btnModificar);
            this.pnControlPersonal.Controls.Add(this.btnCrear);
            this.pnControlPersonal.Controls.Add(this.lbControlPersonal);
            this.pnControlPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControlPersonal.Location = new System.Drawing.Point(0, 0);
            this.pnControlPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnControlPersonal.Name = "pnControlPersonal";
            this.pnControlPersonal.Size = new System.Drawing.Size(329, 170);
            this.pnControlPersonal.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(3, 113);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(323, 50);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(0, 60);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(325, 47);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lbControlPersonal
            // 
            this.lbControlPersonal.AutoSize = true;
            this.lbControlPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControlPersonal.Location = new System.Drawing.Point(11, 10);
            this.lbControlPersonal.Name = "lbControlPersonal";
            this.lbControlPersonal.Size = new System.Drawing.Size(265, 32);
            this.lbControlPersonal.TabIndex = 0;
            this.lbControlPersonal.Text = "Control de Personal";
            this.lbControlPersonal.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnCuerpo
            // 
            this.pnCuerpo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnCuerpo.Controls.Add(this.pnVentana);
            this.pnCuerpo.Controls.Add(this.pnOpciones);
            this.pnCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCuerpo.Location = new System.Drawing.Point(0, 139);
            this.pnCuerpo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCuerpo.Name = "pnCuerpo";
            this.pnCuerpo.Size = new System.Drawing.Size(1235, 692);
            this.pnCuerpo.TabIndex = 1;
            this.pnCuerpo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnVentana
            // 
            this.pnVentana.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnVentana.Location = new System.Drawing.Point(329, 0);
            this.pnVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnVentana.Name = "pnVentana";
            this.pnVentana.Size = new System.Drawing.Size(906, 692);
            this.pnVentana.TabIndex = 1;
            this.pnVentana.Paint += new System.Windows.Forms.PaintEventHandler(this.pnVentana_Paint);
            // 
            // pnEncabezado
            // 
            this.pnEncabezado.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnEncabezado.Controls.Add(this.pictureBox1);
            this.pnEncabezado.Controls.Add(this.lbBienvenido);
            this.pnEncabezado.Controls.Add(this.panel3);
            this.pnEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnEncabezado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnEncabezado.Name = "pnEncabezado";
            this.pnEncabezado.Size = new System.Drawing.Size(1235, 139);
            this.pnEncabezado.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prototipo.Properties.Resources.SP_120_;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 146);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBienvenido.Location = new System.Drawing.Point(165, 25);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(165, 32);
            this.lbBienvenido.TabIndex = 4;
            this.lbBienvenido.Text = "¡Bienvenido";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCS);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(982, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 139);
            this.panel3.TabIndex = 3;
            // 
            // btnCS
            // 
            this.btnCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCS.Image = global::Prototipo.Properties.Resources._4213459_common_door_exit_logout_out_signout_115411__1_;
            this.btnCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCS.Location = new System.Drawing.Point(45, 12);
            this.btnCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(195, 53);
            this.btnCS.TabIndex = 0;
            this.btnCS.Text = "Cerrar Sesión";
            this.btnCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCS.UseCompatibleTextRendering = true;
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1235, 831);
            this.Controls.Add(this.pnCuerpo);
            this.Controls.Add(this.pnEncabezado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PantallaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.pnOpciones.ResumeLayout(false);
            this.pnInformes.ResumeLayout(false);
            this.pnInformes.PerformLayout();
            this.pnGestionInventario.ResumeLayout(false);
            this.pnGestionInventario.PerformLayout();
            this.pnFacturacion.ResumeLayout(false);
            this.pnFacturacion.PerformLayout();
            this.pnControlPersonal.ResumeLayout(false);
            this.pnControlPersonal.PerformLayout();
            this.pnCuerpo.ResumeLayout(false);
            this.pnEncabezado.ResumeLayout(false);
            this.pnEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnOpciones;
        private System.Windows.Forms.Panel pnCuerpo;
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Panel pnControlPersonal;
        private System.Windows.Forms.Label lbControlPersonal;
        private System.Windows.Forms.Panel pnEncabezado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.Panel pnGestionInventario;
        private System.Windows.Forms.Label lbGestionInventario;
        private System.Windows.Forms.Panel pnFacturacion;
        private System.Windows.Forms.Label lbFacturacion;
        private System.Windows.Forms.Panel pnInformes;
        private System.Windows.Forms.Label lbInformes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel pnVentana;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnAjustesI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReporteFac;
        private System.Windows.Forms.Button btAjusteInventario;
        private System.Windows.Forms.Button btnNC;
        private System.Windows.Forms.Button btnGraficos;
    }
}