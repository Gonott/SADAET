namespace GUI
{
    partial class Form_AgregarIdioma
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
            this.lblIngreseIdioma = new System.Windows.Forms.Label();
            this.textBoxIdioma = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelControles = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngreseIdioma
            // 
            this.lblIngreseIdioma.AutoSize = true;
            this.lblIngreseIdioma.Location = new System.Drawing.Point(26, 27);
            this.lblIngreseIdioma.Name = "lblIngreseIdioma";
            this.lblIngreseIdioma.Size = new System.Drawing.Size(131, 13);
            this.lblIngreseIdioma.TabIndex = 0;
            this.lblIngreseIdioma.Tag = "21";
            this.lblIngreseIdioma.Text = "Ingrese Nombre de Idioma";
            // 
            // textBoxIdioma
            // 
            this.textBoxIdioma.Location = new System.Drawing.Point(163, 24);
            this.textBoxIdioma.Name = "textBoxIdioma";
            this.textBoxIdioma.Size = new System.Drawing.Size(155, 20);
            this.textBoxIdioma.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelControles
            // 
            this.labelControles.AutoSize = true;
            this.labelControles.Location = new System.Drawing.Point(26, 84);
            this.labelControles.Name = "labelControles";
            this.labelControles.Size = new System.Drawing.Size(110, 13);
            this.labelControles.TabIndex = 3;
            this.labelControles.Tag = "42";
            this.labelControles.Text = "Leyendas del Sistema";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(337, 22);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Tag = "19";
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(530, 269);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(158, 23);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Tag = "32";
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // Form_AgregarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 309);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelControles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxIdioma);
            this.Controls.Add(this.lblIngreseIdioma);
            this.Name = "Form_AgregarIdioma";
            this.Text = "Agregar Idioma";
            this.Load += new System.EventHandler(this.Form_AgregarIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseIdioma;
        private System.Windows.Forms.TextBox textBoxIdioma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelControles;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonAceptar;
    }
}