
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
            this.dataGridViewEstados = new System.Windows.Forms.DataGridView();
            this.LabelHistorico = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstados)).BeginInit();
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
            this.dataGridViewSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSolicitudes_CellClick);
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
            // dataGridViewEstados
            // 
            this.dataGridViewEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstados.Location = new System.Drawing.Point(12, 228);
            this.dataGridViewEstados.Name = "dataGridViewEstados";
            this.dataGridViewEstados.Size = new System.Drawing.Size(754, 178);
            this.dataGridViewEstados.TabIndex = 4;
            // 
            // LabelHistorico
            // 
            this.LabelHistorico.AutoSize = true;
            this.LabelHistorico.Location = new System.Drawing.Point(15, 209);
            this.LabelHistorico.Name = "LabelHistorico";
            this.LabelHistorico.Size = new System.Drawing.Size(104, 13);
            this.LabelHistorico.TabIndex = 5;
            this.LabelHistorico.Text = "Historico de Estados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver Estado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormControl_de_Cambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelHistorico);
            this.Controls.Add(this.dataGridViewEstados);
            this.Controls.Add(this.SolicitudesLbl);
            this.Controls.Add(this.dataGridViewSolicitudes);
            this.Name = "FormControl_de_Cambios";
            this.Text = "Control de Cambios de Estado (Solicitudes)";
            this.Load += new System.EventHandler(this.FormControl_de_Cambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Label SolicitudesLbl;
        private System.Windows.Forms.DataGridView dataGridViewEstados;
        private System.Windows.Forms.Label LabelHistorico;
        private System.Windows.Forms.Button button1;
    }
}