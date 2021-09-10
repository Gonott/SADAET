namespace GUI
{
    partial class Form_ComodatoLegal
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
            this.labelSolicitudes = new System.Windows.Forms.Label();
            this.dataGridViewSolicitudes = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonAutorizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSolicitudes
            // 
            this.labelSolicitudes.AutoSize = true;
            this.labelSolicitudes.Location = new System.Drawing.Point(13, 9);
            this.labelSolicitudes.Name = "labelSolicitudes";
            this.labelSolicitudes.Size = new System.Drawing.Size(58, 13);
            this.labelSolicitudes.TabIndex = 0;
            this.labelSolicitudes.Tag = "29";
            this.labelSolicitudes.Text = "Solicitudes";
            // 
            // dataGridViewSolicitudes
            // 
            this.dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitudes.Location = new System.Drawing.Point(16, 32);
            this.dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            this.dataGridViewSolicitudes.Size = new System.Drawing.Size(476, 118);
            this.dataGridViewSolicitudes.TabIndex = 1;
            this.dataGridViewSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSolicitudes_CellClick);
            this.dataGridViewSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSolicitudes_CellContentClick);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReporteComodato.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 156);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(643, 282);
            this.reportViewer1.TabIndex = 2;
            // 
            // buttonAutorizar
            // 
            this.buttonAutorizar.Location = new System.Drawing.Point(498, 32);
            this.buttonAutorizar.Name = "buttonAutorizar";
            this.buttonAutorizar.Size = new System.Drawing.Size(160, 118);
            this.buttonAutorizar.TabIndex = 3;
            this.buttonAutorizar.Tag = "33";
            this.buttonAutorizar.Text = "Autorizar Préstamo";
            this.buttonAutorizar.UseVisualStyleBackColor = true;
            this.buttonAutorizar.Click += new System.EventHandler(this.buttonAutorizar_Click);
            // 
            // Form_ComodatoLegal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.buttonAutorizar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dataGridViewSolicitudes);
            this.Controls.Add(this.labelSolicitudes);
            this.Name = "Form_ComodatoLegal";
            this.Text = "Comodato Legal";
            this.Load += new System.EventHandler(this.Form_ComodatoLegal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSolicitudes;
        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonAutorizar;
    }
}