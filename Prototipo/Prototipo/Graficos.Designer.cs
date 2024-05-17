namespace Prototipo.Prototipo
{
    partial class Graficos
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
            this.pnGraficos = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pVisualizadorGraficos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGrafico1 = new System.Windows.Forms.Button();
            this.pnGraficos.SuspendLayout();
            this.pVisualizadorGraficos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnGraficos
            // 
            this.pnGraficos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGraficos.Controls.Add(this.btnGrafico1);
            this.pnGraficos.Controls.Add(this.label3);
            this.pnGraficos.Controls.Add(this.pVisualizadorGraficos);
            this.pnGraficos.Controls.Add(this.panel4);
            this.pnGraficos.Location = new System.Drawing.Point(30, 22);
            this.pnGraficos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnGraficos.Name = "pnGraficos";
            this.pnGraficos.Size = new System.Drawing.Size(986, 567);
            this.pnGraficos.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo";
            // 
            // pVisualizadorGraficos
            // 
            this.pVisualizadorGraficos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pVisualizadorGraficos.Controls.Add(this.label2);
            this.pVisualizadorGraficos.Location = new System.Drawing.Point(205, 22);
            this.pVisualizadorGraficos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pVisualizadorGraficos.Name = "pVisualizadorGraficos";
            this.pVisualizadorGraficos.Size = new System.Drawing.Size(781, 544);
            this.pVisualizadorGraficos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gráfico";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 24);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gráficos";
            // 
            // btnGrafico1
            // 
            this.btnGrafico1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGrafico1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico1.Location = new System.Drawing.Point(5, 39);
            this.btnGrafico1.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafico1.Name = "btnGrafico1";
            this.btnGrafico1.Size = new System.Drawing.Size(196, 41);
            this.btnGrafico1.TabIndex = 7;
            this.btnGrafico1.Text = "Ventas";
            this.btnGrafico1.UseVisualStyleBackColor = false;
            this.btnGrafico1.Click += new System.EventHandler(this.btnGrafico1_Click);
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1053, 627);
            this.Controls.Add(this.pnGraficos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Graficos";
            this.Text = "Graficos";
            this.pnGraficos.ResumeLayout(false);
            this.pnGraficos.PerformLayout();
            this.pVisualizadorGraficos.ResumeLayout(false);
            this.pVisualizadorGraficos.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnGraficos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pVisualizadorGraficos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGrafico1;
    }
}