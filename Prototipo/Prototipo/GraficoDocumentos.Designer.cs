namespace Prototipo.Prototipo
{
    partial class GraficoDocumentos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(29, 56);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(638, 429);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(166, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Distribución de tipos de documentos creados";
            // 
            // GraficoDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(693, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraficoDocumentos";
            this.Text = "GraficoDocumentos";
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Label label1;
    }
}