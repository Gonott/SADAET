
namespace GUI
{
    partial class Form_Devoluciones
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
            this.dataGridViewDevoluciones = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AplicarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDevoluciones
            // 
            this.dataGridViewDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevoluciones.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewDevoluciones.Name = "dataGridViewDevoluciones";
            this.dataGridViewDevoluciones.Size = new System.Drawing.Size(472, 168);
            this.dataGridViewDevoluciones.TabIndex = 0;
            this.dataGridViewDevoluciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevoluciones_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // AplicarBtn
            // 
            this.AplicarBtn.Location = new System.Drawing.Point(504, 143);
            this.AplicarBtn.Name = "AplicarBtn";
            this.AplicarBtn.Size = new System.Drawing.Size(200, 54);
            this.AplicarBtn.TabIndex = 4;
            this.AplicarBtn.Tag = "32";
            this.AplicarBtn.Text = "Aplicar";
            this.AplicarBtn.UseVisualStyleBackColor = true;
            this.AplicarBtn.Click += new System.EventHandler(this.AplicarBtn_Click);
            // 
            // Form_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 227);
            this.Controls.Add(this.AplicarBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridViewDevoluciones);
            this.Name = "Form_Devoluciones";
            this.Text = "Form_Devoluciones";
            this.Load += new System.EventHandler(this.Form_Devoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDevoluciones;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AplicarBtn;
    }
}