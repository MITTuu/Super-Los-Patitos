namespace Prototipo.Prototipo
{
    partial class NotasDeCredito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVDocumentos = new System.Windows.Forms.DataGridView();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnInfDoc = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbTipoDoc = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbResponsable = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnNT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDocumentos)).BeginInit();
            this.pnInfDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDocumentos
            // 
            this.DGVDocumentos.AllowUserToAddRows = false;
            this.DGVDocumentos.AllowUserToDeleteRows = false;
            this.DGVDocumentos.AllowUserToResizeColumns = false;
            this.DGVDocumentos.AllowUserToResizeRows = false;
            this.DGVDocumentos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDocumentos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDocumentos.Location = new System.Drawing.Point(78, 81);
            this.DGVDocumentos.Name = "DGVDocumentos";
            this.DGVDocumentos.ReadOnly = true;
            this.DGVDocumentos.RowHeadersWidth = 51;
            this.DGVDocumentos.RowTemplate.Height = 24;
            this.DGVDocumentos.Size = new System.Drawing.Size(1585, 283);
            this.DGVDocumentos.TabIndex = 0;
            this.DGVDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDocumentos_CellClick);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(73, 26);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(195, 29);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Notas de Crédito";
            // 
            // pnInfDoc
            // 
            this.pnInfDoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnInfDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInfDoc.Controls.Add(this.lbTotal);
            this.pnInfDoc.Controls.Add(this.lbResponsable);
            this.pnInfDoc.Controls.Add(this.lbCliente);
            this.pnInfDoc.Controls.Add(this.lbTipoDoc);
            this.pnInfDoc.Controls.Add(this.lbFecha);
            this.pnInfDoc.Location = new System.Drawing.Point(78, 426);
            this.pnInfDoc.Name = "pnInfDoc";
            this.pnInfDoc.Size = new System.Drawing.Size(1585, 121);
            this.pnInfDoc.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(779, 654);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 10);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información del documento seleccionado";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(7, 63);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(163, 22);
            this.lbFecha.TabIndex = 0;
            this.lbFecha.Text = "Fecha de creación:";
            // 
            // lbTipoDoc
            // 
            this.lbTipoDoc.AutoSize = true;
            this.lbTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoDoc.Location = new System.Drawing.Point(5, 10);
            this.lbTipoDoc.Name = "lbTipoDoc";
            this.lbTipoDoc.Size = new System.Drawing.Size(169, 22);
            this.lbTipoDoc.TabIndex = 1;
            this.lbTipoDoc.Text = "Tipo de documento:";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(721, 63);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(71, 22);
            this.lbCliente.TabIndex = 2;
            this.lbCliente.Text = "Cliente:";
            // 
            // lbResponsable
            // 
            this.lbResponsable.AutoSize = true;
            this.lbResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResponsable.Location = new System.Drawing.Point(382, 63);
            this.lbResponsable.Name = "lbResponsable";
            this.lbResponsable.Size = new System.Drawing.Size(127, 22);
            this.lbResponsable.TabIndex = 3;
            this.lbResponsable.Text = "Facturado por:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(995, 63);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(121, 22);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total pagado:";
            // 
            // btnNT
            // 
            this.btnNT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNT.Location = new System.Drawing.Point(744, 605);
            this.btnNT.Name = "btnNT";
            this.btnNT.Size = new System.Drawing.Size(258, 43);
            this.btnNT.TabIndex = 9;
            this.btnNT.Text = "Aplicar Nota de Crédito";
            this.btnNT.UseVisualStyleBackColor = false;
            this.btnNT.Click += new System.EventHandler(this.btnNT_Click);
            // 
            // NotasDeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1750, 676);
            this.Controls.Add(this.btnNT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnInfDoc);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.DGVDocumentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasDeCredito";
            this.Text = "NotasDeCredito";
            this.Load += new System.EventHandler(this.NotasDeCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDocumentos)).EndInit();
            this.pnInfDoc.ResumeLayout(false);
            this.pnInfDoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDocumentos;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel pnInfDoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTipoDoc;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbResponsable;
        private System.Windows.Forms.Button btnNT;
    }
}