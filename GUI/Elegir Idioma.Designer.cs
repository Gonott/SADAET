namespace GUI
{
    partial class Elegir_Idioma
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
            this.IdiomaLbl = new System.Windows.Forms.Label();
            this.comboBoxIdiomas = new System.Windows.Forms.ComboBox();
            this.AplicarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdiomaLbl
            // 
            this.IdiomaLbl.AutoSize = true;
            this.IdiomaLbl.Location = new System.Drawing.Point(28, 20);
            this.IdiomaLbl.Name = "IdiomaLbl";
            this.IdiomaLbl.Size = new System.Drawing.Size(109, 13);
            this.IdiomaLbl.TabIndex = 1;
            this.IdiomaLbl.Tag = "17";
            this.IdiomaLbl.Text = "Seleccione un Idioma";
            // 
            // comboBoxIdiomas
            // 
            this.comboBoxIdiomas.FormattingEnabled = true;
            this.comboBoxIdiomas.Location = new System.Drawing.Point(31, 47);
            this.comboBoxIdiomas.Name = "comboBoxIdiomas";
            this.comboBoxIdiomas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdiomas.TabIndex = 2;
            this.comboBoxIdiomas.Tag = "0";
            // 
            // AplicarBtn
            // 
            this.AplicarBtn.Location = new System.Drawing.Point(158, 45);
            this.AplicarBtn.Name = "AplicarBtn";
            this.AplicarBtn.Size = new System.Drawing.Size(75, 23);
            this.AplicarBtn.TabIndex = 3;
            this.AplicarBtn.Tag = "32";
            this.AplicarBtn.Text = "Aplicar";
            this.AplicarBtn.UseVisualStyleBackColor = true;
            this.AplicarBtn.Click += new System.EventHandler(this.AplicarBtn_Click);
            // 
            // Elegir_Idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 101);
            this.Controls.Add(this.AplicarBtn);
            this.Controls.Add(this.comboBoxIdiomas);
            this.Controls.Add(this.IdiomaLbl);
            this.Name = "Elegir_Idioma";
            this.Text = "Elegir Idioma";
            this.Load += new System.EventHandler(this.Elegir_Idioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdiomaLbl;
        private System.Windows.Forms.ComboBox comboBoxIdiomas;
        private System.Windows.Forms.Button AplicarBtn;
    }
}