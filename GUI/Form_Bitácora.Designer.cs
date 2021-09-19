
namespace GUI
{
    partial class Form_Bitácora
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
            this.listViewEventos = new System.Windows.Forms.ListView();
            this.AplicarBtn = new System.Windows.Forms.Button();
            this.checkBoxUsuario = new System.Windows.Forms.CheckBox();
            this.checkBoxfecha = new System.Windows.Forms.CheckBox();
            this.checkBoxActividad = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelDesde = new System.Windows.Forms.Label();
            this.labelHasta = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewEventos
            // 
            this.listViewEventos.HideSelection = false;
            this.listViewEventos.Location = new System.Drawing.Point(12, 12);
            this.listViewEventos.Name = "listViewEventos";
            this.listViewEventos.Size = new System.Drawing.Size(872, 282);
            this.listViewEventos.TabIndex = 0;
            this.listViewEventos.UseCompatibleStateImageBehavior = false;
            // 
            // AplicarBtn
            // 
            this.AplicarBtn.Location = new System.Drawing.Point(1075, 176);
            this.AplicarBtn.Name = "AplicarBtn";
            this.AplicarBtn.Size = new System.Drawing.Size(109, 23);
            this.AplicarBtn.TabIndex = 4;
            this.AplicarBtn.Tag = "32";
            this.AplicarBtn.Text = "Aplicar";
            this.AplicarBtn.UseVisualStyleBackColor = true;
            this.AplicarBtn.Click += new System.EventHandler(this.AplicarBtn_Click);
            // 
            // checkBoxUsuario
            // 
            this.checkBoxUsuario.AutoSize = true;
            this.checkBoxUsuario.Location = new System.Drawing.Point(902, 17);
            this.checkBoxUsuario.Name = "checkBoxUsuario";
            this.checkBoxUsuario.Size = new System.Drawing.Size(62, 17);
            this.checkBoxUsuario.TabIndex = 5;
            this.checkBoxUsuario.Text = "Usuario";
            this.checkBoxUsuario.UseVisualStyleBackColor = true;
            this.checkBoxUsuario.CheckedChanged += new System.EventHandler(this.checkBoxUsuario_CheckedChanged);
            // 
            // checkBoxfecha
            // 
            this.checkBoxfecha.AutoSize = true;
            this.checkBoxfecha.Location = new System.Drawing.Point(903, 46);
            this.checkBoxfecha.Name = "checkBoxfecha";
            this.checkBoxfecha.Size = new System.Drawing.Size(56, 17);
            this.checkBoxfecha.TabIndex = 6;
            this.checkBoxfecha.Text = "Fecha";
            this.checkBoxfecha.UseVisualStyleBackColor = true;
            this.checkBoxfecha.CheckedChanged += new System.EventHandler(this.checkBoxfecha_CheckedChanged);
            // 
            // checkBoxActividad
            // 
            this.checkBoxActividad.AutoSize = true;
            this.checkBoxActividad.Location = new System.Drawing.Point(903, 133);
            this.checkBoxActividad.Name = "checkBoxActividad";
            this.checkBoxActividad.Size = new System.Drawing.Size(92, 17);
            this.checkBoxActividad.TabIndex = 7;
            this.checkBoxActividad.Text = "Palabra Clave";
            this.checkBoxActividad.UseVisualStyleBackColor = true;
            this.checkBoxActividad.CheckedChanged += new System.EventHandler(this.checkBoxActividad_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(984, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(984, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Location = new System.Drawing.Point(940, 73);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(38, 13);
            this.labelDesde.TabIndex = 10;
            this.labelDesde.Text = "Desde";
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Location = new System.Drawing.Point(940, 99);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(35, 13);
            this.labelHasta.TabIndex = 11;
            this.labelHasta.Text = "Hasta";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1011, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(984, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Form_Bitácora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 311);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxActividad);
            this.Controls.Add(this.checkBoxfecha);
            this.Controls.Add(this.checkBoxUsuario);
            this.Controls.Add(this.AplicarBtn);
            this.Controls.Add(this.listViewEventos);
            this.Name = "Form_Bitácora";
            this.Text = "Registro de Eventos";
            this.Load += new System.EventHandler(this.Form_Bitácora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEventos;
        private System.Windows.Forms.Button AplicarBtn;
        private System.Windows.Forms.CheckBox checkBoxUsuario;
        private System.Windows.Forms.CheckBox checkBoxfecha;
        private System.Windows.Forms.CheckBox checkBoxActividad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}