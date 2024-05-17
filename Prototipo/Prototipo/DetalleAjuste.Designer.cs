namespace Prototipo.Prototipo
{
    partial class DetalleAjuste
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductosAjuste = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lRazon = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.lResponsable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAjuste)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lResponsable);
            this.panel1.Controls.Add(this.lFecha);
            this.panel1.Controls.Add(this.lRazon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvProductosAjuste);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 533);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Productos ajustados";
            // 
            // dgvProductosAjuste
            // 
            this.dgvProductosAjuste.AllowUserToAddRows = false;
            this.dgvProductosAjuste.AllowUserToDeleteRows = false;
            this.dgvProductosAjuste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosAjuste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAjuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProductosAjuste.Location = new System.Drawing.Point(35, 179);
            this.dgvProductosAjuste.MultiSelect = false;
            this.dgvProductosAjuste.Name = "dgvProductosAjuste";
            this.dgvProductosAjuste.ReadOnly = true;
            this.dgvProductosAjuste.RowHeadersVisible = false;
            this.dgvProductosAjuste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosAjuste.Size = new System.Drawing.Size(427, 321);
            this.dgvProductosAjuste.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 26);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalles del Ajuste";
            // 
            // lRazon
            // 
            this.lRazon.AutoSize = true;
            this.lRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRazon.Location = new System.Drawing.Point(32, 99);
            this.lRazon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRazon.Name = "lRazon";
            this.lRazon.Size = new System.Drawing.Size(134, 18);
            this.lRazon.TabIndex = 13;
            this.lRazon.Text = "Razón del ajuste";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecha.Location = new System.Drawing.Point(32, 49);
            this.lFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(141, 16);
            this.lFecha.TabIndex = 14;
            this.lFecha.Text = "Creación: dd/mm/yyyy";
            // 
            // lResponsable
            // 
            this.lResponsable.AutoSize = true;
            this.lResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResponsable.Location = new System.Drawing.Point(32, 74);
            this.lResponsable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lResponsable.Name = "lResponsable";
            this.lResponsable.Size = new System.Drawing.Size(158, 16);
            this.lResponsable.TabIndex = 15;
            this.lResponsable.Text = "Hecho por: Responsable";
            // 
            // DetalleAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 633);
            this.Controls.Add(this.panel1);
            this.Name = "DetalleAjuste";
            this.Text = "DetalleAjuste";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAjuste)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductosAjuste;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lResponsable;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lRazon;
    }
}