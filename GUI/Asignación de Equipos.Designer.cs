namespace GUI
{
    partial class Asignación_de_Equipos
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
            this.buscarEquipoBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dataGridViewSolicitudes = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // SolicitudesLbl
            // 
            this.SolicitudesLbl.AutoSize = true;
            this.SolicitudesLbl.Location = new System.Drawing.Point(9, 11);
            this.SolicitudesLbl.Name = "SolicitudesLbl";
            this.SolicitudesLbl.Size = new System.Drawing.Size(58, 13);
            this.SolicitudesLbl.TabIndex = 0;
            this.SolicitudesLbl.Tag = "29";
            this.SolicitudesLbl.Text = "Solicitudes";
            // 
            // buscarEquipoBtn
            // 
            this.buscarEquipoBtn.Location = new System.Drawing.Point(12, 221);
            this.buscarEquipoBtn.Name = "buscarEquipoBtn";
            this.buscarEquipoBtn.Size = new System.Drawing.Size(149, 37);
            this.buscarEquipoBtn.TabIndex = 2;
            this.buscarEquipoBtn.Tag = "30";
            this.buscarEquipoBtn.Text = "Buscar Equipo";
            this.buscarEquipoBtn.UseVisualStyleBackColor = true;
            this.buscarEquipoBtn.Click += new System.EventHandler(this.buscarEquipoBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(167, 221);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(356, 80);
            this.treeView1.TabIndex = 4;
            this.treeView1.Tag = "0";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(529, 221);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(101, 80);
            this.btnAsignar.TabIndex = 5;
            this.btnAsignar.Tag = "31";
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dataGridViewSolicitudes
            // 
            this.dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitudes.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            this.dataGridViewSolicitudes.Size = new System.Drawing.Size(618, 150);
            this.dataGridViewSolicitudes.TabIndex = 1;
            this.dataGridViewSolicitudes.Tag = "0";
            this.dataGridViewSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSolicitudes_CellClick);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(12, 268);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(149, 33);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Tag = "6";
            this.buttonBuscar.Text = "Buscar Componentes";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // Asignación_de_Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 321);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.buscarEquipoBtn);
            this.Controls.Add(this.dataGridViewSolicitudes);
            this.Controls.Add(this.SolicitudesLbl);
            this.Name = "Asignación_de_Equipos";
            this.Text = "Asignación de Equipos";
            this.Load += new System.EventHandler(this.Asignación_de_Equipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SolicitudesLbl;
        private System.Windows.Forms.Button buscarEquipoBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Button buttonBuscar;
    }
}