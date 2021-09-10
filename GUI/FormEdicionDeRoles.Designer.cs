namespace GUI
{
    partial class FormEdicionDeRoles
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
            this.RolLbl = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.ListBoxPermisosRol = new System.Windows.Forms.ListBox();
            this.DataGridViewPermisos = new System.Windows.Forms.DataGridView();
            this.PermisosLbl = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // RolLbl
            // 
            this.RolLbl.AutoSize = true;
            this.RolLbl.Location = new System.Drawing.Point(12, 28);
            this.RolLbl.Name = "RolLbl";
            this.RolLbl.Size = new System.Drawing.Size(23, 13);
            this.RolLbl.TabIndex = 0;
            this.RolLbl.Tag = "25";
            this.RolLbl.Text = "Rol";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(41, 25);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(175, 21);
            this.comboBoxRoles.TabIndex = 1;
            this.comboBoxRoles.Tag = "0";
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            // 
            // ListBoxPermisosRol
            // 
            this.ListBoxPermisosRol.FormattingEnabled = true;
            this.ListBoxPermisosRol.Location = new System.Drawing.Point(15, 71);
            this.ListBoxPermisosRol.Name = "ListBoxPermisosRol";
            this.ListBoxPermisosRol.Size = new System.Drawing.Size(201, 290);
            this.ListBoxPermisosRol.TabIndex = 2;
            this.ListBoxPermisosRol.Tag = "0";
            this.ListBoxPermisosRol.SelectedIndexChanged += new System.EventHandler(this.ListBoxPermisosRol_SelectedIndexChanged);
            // 
            // DataGridViewPermisos
            // 
            this.DataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPermisos.Location = new System.Drawing.Point(369, 71);
            this.DataGridViewPermisos.Name = "DataGridViewPermisos";
            this.DataGridViewPermisos.ReadOnly = true;
            this.DataGridViewPermisos.Size = new System.Drawing.Size(419, 290);
            this.DataGridViewPermisos.TabIndex = 3;
            this.DataGridViewPermisos.Tag = "0";
            this.DataGridViewPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPermisos_CellClick);
            // 
            // PermisosLbl
            // 
            this.PermisosLbl.AutoSize = true;
            this.PermisosLbl.Location = new System.Drawing.Point(366, 28);
            this.PermisosLbl.Name = "PermisosLbl";
            this.PermisosLbl.Size = new System.Drawing.Size(49, 13);
            this.PermisosLbl.TabIndex = 4;
            this.PermisosLbl.Tag = "24";
            this.PermisosLbl.Text = "Permisos";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(253, 106);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 34);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Tag = "19";
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Location = new System.Drawing.Point(253, 290);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(75, 34);
            this.BtnQuitar.TabIndex = 6;
            this.BtnQuitar.Tag = "27";
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // FormEdicionDeRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.PermisosLbl);
            this.Controls.Add(this.DataGridViewPermisos);
            this.Controls.Add(this.ListBoxPermisosRol);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.RolLbl);
            this.Name = "FormEdicionDeRoles";
            this.Text = "Edición de Roles";
            this.Load += new System.EventHandler(this.FormEdicionDeRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RolLbl;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.ListBox ListBoxPermisosRol;
        private System.Windows.Forms.DataGridView DataGridViewPermisos;
        private System.Windows.Forms.Label PermisosLbl;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnQuitar;
    }
}