namespace GUI
{
    partial class Form_BuscarComponentes
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
            this.SolicitudesLbl = new System.Windows.Forms.Label();
            this.dataGridViewSolicitudes = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // SolicitudesLbl
            // 
            this.SolicitudesLbl.AutoSize = true;
            this.SolicitudesLbl.Location = new System.Drawing.Point(12, 9);
            this.SolicitudesLbl.Name = "SolicitudesLbl";
            this.SolicitudesLbl.Size = new System.Drawing.Size(58, 13);
            this.SolicitudesLbl.TabIndex = 1;
            this.SolicitudesLbl.Tag = "29";
            this.SolicitudesLbl.Text = "Solicitudes";
            // 
            // dataGridViewSolicitudes
            // 
            this.dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitudes.Location = new System.Drawing.Point(15, 36);
            this.dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            this.dataGridViewSolicitudes.Size = new System.Drawing.Size(660, 150);
            this.dataGridViewSolicitudes.TabIndex = 2;
            this.dataGridViewSolicitudes.Tag = "0";
            this.dataGridViewSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSolicitudes_CellClick);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(15, 192);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(149, 33);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Tag = "6";
            this.buttonBuscar.Text = "Buscar Componentes";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ComponentesAdecuados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 231);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(660, 228);
            this.reportViewer1.TabIndex = 4;
            // 
            // Form_BuscarComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 465);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.dataGridViewSolicitudes);
            this.Controls.Add(this.SolicitudesLbl);
            this.Name = "Form_BuscarComponentes";
            this.Text = "Buscar Componentes";
            this.Load += new System.EventHandler(this.Form_BuscarComponentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SolicitudesLbl;
        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Button buttonBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}