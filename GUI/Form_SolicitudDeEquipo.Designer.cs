namespace GUI
{
    partial class Form_SolicitudDeEquipo
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
            this.labelEmpleados = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSolicitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.AutoSize = true;
            this.labelEmpleados.Location = new System.Drawing.Point(12, 25);
            this.labelEmpleados.Name = "labelEmpleados";
            this.labelEmpleados.Size = new System.Drawing.Size(62, 13);
            this.labelEmpleados.TabIndex = 0;
            this.labelEmpleados.Tag = "40";
            this.labelEmpleados.Text = "Empleados:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 200);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(622, 84);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(124, 92);
            this.btnSolicitar.TabIndex = 3;
            this.btnSolicitar.Tag = "41";
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // Form_SolicitudDeEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 257);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelEmpleados);
            this.Name = "Form_SolicitudDeEquipo";
            this.Text = "Solicitud de Equipo";
            this.Load += new System.EventHandler(this.Form_SolicitudDeEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpleados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSolicitar;
    }
}