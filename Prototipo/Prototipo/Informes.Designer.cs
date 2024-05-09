namespace Prototipo.Prototipo
{
    partial class Informes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbFechaIni = new System.Windows.Forms.Label();
            this.tbFechaIni = new System.Windows.Forms.TextBox();
            this.tbFechaFin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pnGraficos = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelecFecha = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnGraficos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSelecFecha);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.tbFechaFin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbFechaIni);
            this.panel1.Controls.Add(this.lbFechaIni);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(218, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 282);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lbTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 30);
            this.panel2.TabIndex = 1;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Location = new System.Drawing.Point(3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(174, 22);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Reporte de Facturas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 28);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbFechaIni
            // 
            this.lbFechaIni.AutoSize = true;
            this.lbFechaIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaIni.Location = new System.Drawing.Point(595, 138);
            this.lbFechaIni.Name = "lbFechaIni";
            this.lbFechaIni.Size = new System.Drawing.Size(141, 22);
            this.lbFechaIni.TabIndex = 3;
            this.lbFechaIni.Text = "Fecha de incio";
            // 
            // tbFechaIni
            // 
            this.tbFechaIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaIni.Location = new System.Drawing.Point(599, 163);
            this.tbFechaIni.Name = "tbFechaIni";
            this.tbFechaIni.Size = new System.Drawing.Size(137, 28);
            this.tbFechaIni.TabIndex = 4;
            // 
            // tbFechaFin
            // 
            this.tbFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFechaFin.Location = new System.Drawing.Point(846, 163);
            this.tbFechaFin.Name = "tbFechaFin";
            this.tbFechaFin.Size = new System.Drawing.Size(137, 28);
            this.tbFechaFin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(842, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha final";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(1075, 138);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(178, 55);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar Informe";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pnGraficos
            // 
            this.pnGraficos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGraficos.Controls.Add(this.label3);
            this.pnGraficos.Controls.Add(this.panel3);
            this.pnGraficos.Controls.Add(this.panel4);
            this.pnGraficos.Location = new System.Drawing.Point(217, 363);
            this.pnGraficos.Name = "pnGraficos";
            this.pnGraficos.Size = new System.Drawing.Size(1314, 697);
            this.pnGraficos.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1312, 30);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gráficos";
            // 
            // btnSelecFecha
            // 
            this.btnSelecFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelecFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecFecha.Location = new System.Drawing.Point(359, 59);
            this.btnSelecFecha.Name = "btnSelecFecha";
            this.btnSelecFecha.Size = new System.Drawing.Size(194, 63);
            this.btnSelecFecha.TabIndex = 7;
            this.btnSelecFecha.Text = "Seleccionar Fecha";
            this.btnSelecFecha.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(818, 1066);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 24);
            this.panel5.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(273, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 669);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gráfico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo";
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1750, 1102);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnGraficos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informes";
            this.Text = "Informes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnGraficos.ResumeLayout(false);
            this.pnGraficos.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox tbFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFechaIni;
        private System.Windows.Forms.Label lbFechaIni;
        private System.Windows.Forms.Panel pnGraficos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelecFecha;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}