
namespace GUI
{
    partial class Form_ABM_Usuarios
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
            this.ListBoxUsuarios = new System.Windows.Forms.ListBox();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.BajaBtn = new System.Windows.Forms.Button();
            this.AltaBtn = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.nombreRolLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBoxUsuarios
            // 
            this.ListBoxUsuarios.FormattingEnabled = true;
            this.ListBoxUsuarios.Location = new System.Drawing.Point(12, 12);
            this.ListBoxUsuarios.Name = "ListBoxUsuarios";
            this.ListBoxUsuarios.Size = new System.Drawing.Size(129, 160);
            this.ListBoxUsuarios.TabIndex = 2;
            this.ListBoxUsuarios.Tag = "0";
            this.ListBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.ListBoxUsuarios_SelectedIndexChanged);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Location = new System.Drawing.Point(349, 149);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(75, 23);
            this.ModificarBtn.TabIndex = 21;
            this.ModificarBtn.Tag = "28";
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // BajaBtn
            // 
            this.BajaBtn.Location = new System.Drawing.Point(248, 149);
            this.BajaBtn.Name = "BajaBtn";
            this.BajaBtn.Size = new System.Drawing.Size(75, 23);
            this.BajaBtn.TabIndex = 20;
            this.BajaBtn.Tag = "27";
            this.BajaBtn.Text = "Baja";
            this.BajaBtn.UseVisualStyleBackColor = true;
            this.BajaBtn.Click += new System.EventHandler(this.BajaBtn_Click);
            // 
            // AltaBtn
            // 
            this.AltaBtn.Location = new System.Drawing.Point(156, 149);
            this.AltaBtn.Name = "AltaBtn";
            this.AltaBtn.Size = new System.Drawing.Size(75, 23);
            this.AltaBtn.TabIndex = 19;
            this.AltaBtn.Tag = "19";
            this.AltaBtn.Text = "Alta";
            this.AltaBtn.UseVisualStyleBackColor = true;
            this.AltaBtn.Click += new System.EventHandler(this.AltaBtn_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(248, 23);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(176, 20);
            this.textBoxNombre.TabIndex = 22;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(248, 49);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(176, 20);
            this.textBoxPwd.TabIndex = 23;
            // 
            // nombreRolLbl
            // 
            this.nombreRolLbl.AutoSize = true;
            this.nombreRolLbl.Location = new System.Drawing.Point(153, 26);
            this.nombreRolLbl.Name = "nombreRolLbl";
            this.nombreRolLbl.Size = new System.Drawing.Size(47, 13);
            this.nombreRolLbl.TabIndex = 24;
            this.nombreRolLbl.Tag = "21";
            this.nombreRolLbl.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Contraseña:";
            // 
            // Form_ABM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreRolLbl);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.BajaBtn);
            this.Controls.Add(this.AltaBtn);
            this.Controls.Add(this.ListBoxUsuarios);
            this.Name = "Form_ABM_Usuarios";
            this.Text = "Alta Baja y Modificacion de Usuarios";
            this.Load += new System.EventHandler(this.Form_ABM_Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxUsuarios;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button BajaBtn;
        private System.Windows.Forms.Button AltaBtn;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Label nombreRolLbl;
        private System.Windows.Forms.Label label2;
    }
}