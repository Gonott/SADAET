
namespace GUI
{
    partial class Form_SolicitarDevolucion
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSolicitudes = new System.Windows.Forms.DataGridView();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipoBindingSource
            // 
            this.EquipoBindingSource.DataSource = typeof(BE.Equipo);
            // 
            // dataGridViewSolicitudes
            // 
            this.dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitudes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            this.dataGridViewSolicitudes.Size = new System.Drawing.Size(886, 203);
            this.dataGridViewSolicitudes.TabIndex = 2;
            this.dataGridViewSolicitudes.Tag = "0";
            this.dataGridViewSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSolicitudes_CellClick);
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(628, 226);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(270, 23);
            this.btnSolicitar.TabIndex = 4;
            this.btnSolicitar.Tag = "41";
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(12, 231);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(123, 13);
            this.lblMotivo.TabIndex = 5;
            this.lblMotivo.Tag = "62";
            this.lblMotivo.Text = "Motivo de la devolución:";
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(141, 228);
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(481, 20);
            this.textBoxMotivo.TabIndex = 6;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DSElementos";
            reportDataSource2.Value = this.EquipoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.OrdenDeRetiro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 263);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(886, 311);
            this.reportViewer1.TabIndex = 7;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Form_SolicitarDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 586);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBoxMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.dataGridViewSolicitudes);
            this.Name = "Form_SolicitarDevolucion";
            this.Text = "Solicitar Devolución de Equipo";
            this.Load += new System.EventHandler(this.Form_SolicitarDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox textBoxMotivo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EquipoBindingSource;
    }
}