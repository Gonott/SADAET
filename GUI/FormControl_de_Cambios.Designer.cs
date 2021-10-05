
namespace GUI
{
    partial class FormControl_de_Cambios
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
            this.dataGridViewSolicitudes = new System.Windows.Forms.DataGridView();
            this.SolicitudesLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSolicitudes
            // 
            this.dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitudes.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            this.dataGridViewSolicitudes.Size = new System.Drawing.Size(754, 150);
            this.dataGridViewSolicitudes.TabIndex = 2;
            this.dataGridViewSolicitudes.Tag = "0";
            // 
            // SolicitudesLbl
            // 
            this.SolicitudesLbl.AutoSize = true;
            this.SolicitudesLbl.Location = new System.Drawing.Point(12, 24);
            this.SolicitudesLbl.Name = "SolicitudesLbl";
            this.SolicitudesLbl.Size = new System.Drawing.Size(58, 13);
            this.SolicitudesLbl.TabIndex = 3;
            this.SolicitudesLbl.Tag = "29";
            this.SolicitudesLbl.Text = "Solicitudes";
            // 
            // FormControl_de_Cambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.SolicitudesLbl);
            this.Controls.Add(this.dataGridViewSolicitudes);
            this.Name = "FormControl_de_Cambios";
            this.Text = "FormControl_de_Cambios";
            this.Load += new System.EventHandler(this.FormControl_de_Cambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Label SolicitudesLbl;
    }
}