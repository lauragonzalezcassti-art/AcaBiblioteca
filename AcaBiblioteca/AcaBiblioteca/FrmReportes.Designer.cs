
namespace AcaBiblioteca
{
    partial class FrmReportes
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvReportes;

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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(30, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reportes de biblioteca";

            // lblTipoReporte
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Location = new System.Drawing.Point(32, 85);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(96, 13);
            this.lblTipoReporte.TabIndex = 1;
            this.lblTipoReporte.Text = "Tipo de reporte:";

            // cmbTipoReporte
            this.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Location = new System.Drawing.Point(140, 82);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(250, 21);
            this.cmbTipoReporte.TabIndex = 2;

            // btnGenerar
            this.btnGenerar.Location = new System.Drawing.Point(410, 80);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 28);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(535, 80);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 28);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // dgvReportes
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(30, 135);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.Size = new System.Drawing.Size(740, 280);
            this.dgvReportes.TabIndex = 5;

            // FrmReportes
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbTipoReporte);
            this.Controls.Add(this.lblTipoReporte);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
