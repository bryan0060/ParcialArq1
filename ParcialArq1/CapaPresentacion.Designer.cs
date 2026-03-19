namespace ParcialArq1
{
    partial class CapaPresentacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // lblTipoDoc
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(30, 30);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(115, 15);
            this.lblTipoDoc.TabIndex = 0;
            this.lblTipoDoc.Text = "Tipo de Documento:";
            
            // cbTipoDoc
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Items.AddRange(new object[] { "CC", "TI", "CE" });
            this.cbTipoDoc.Location = new System.Drawing.Point(170, 27);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(121, 23);
            this.cbTipoDoc.TabIndex = 1;

            // lblNroDoc
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(30, 70);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(133, 15);
            this.lblNroDoc.TabIndex = 2;
            this.lblNroDoc.Text = "Número de Documento:";

            // txtNroDoc
            this.txtNroDoc.Location = new System.Drawing.Point(170, 67);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(121, 23);
            this.txtNroDoc.TabIndex = 3;

            // lblIngresos
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(30, 110);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(95, 15);
            this.lblIngresos.TabIndex = 4;
            this.lblIngresos.Text = "Ingresos Totales:";

            // txtIngresos
            this.txtIngresos.Location = new System.Drawing.Point(170, 107);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(121, 23);
            this.txtIngresos.TabIndex = 5;

            // lblEgresos
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Location = new System.Drawing.Point(30, 150);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(91, 15);
            this.lblEgresos.TabIndex = 6;
            this.lblEgresos.Text = "Egresos Totales:";

            // txtEgresos
            this.txtEgresos.Location = new System.Drawing.Point(170, 147);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(121, 23);
            this.txtEgresos.TabIndex = 7;

            // lblMonto
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(30, 190);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(105, 15);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto Solicitado:";

            // txtMonto
            this.txtMonto.Location = new System.Drawing.Point(170, 187);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(121, 23);
            this.txtMonto.TabIndex = 9;

            // lblPlazo
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(30, 230);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(130, 15);
            this.lblPlazo.TabIndex = 10;
            this.lblPlazo.Text = "Plazo Solicitado (Meses):";

            // txtPlazo
            this.txtPlazo.Location = new System.Drawing.Point(170, 227);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(121, 23);
            this.txtPlazo.TabIndex = 11;

            // btnEvaluar
            this.btnEvaluar.Location = new System.Drawing.Point(110, 280);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(120, 40);
            this.btnEvaluar.TabIndex = 12;
            this.btnEvaluar.Text = "Evaluar Crédito";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);

            // CapaPresentacion
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 360);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.lblPlazo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtEgresos);
            this.Controls.Add(this.lblEgresos);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.cbTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Name = "CapaPresentacion";
            this.Text = "Evaluación de Crédito";
            this.Load += new System.EventHandler(this.CapaPresentacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Button btnEvaluar;
    }
}
