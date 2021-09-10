namespace GUI
{
    partial class FormPerfilesDeUsuario
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
            this.UsuariosLbl = new System.Windows.Forms.Label();
            this.ListBoxUsuarios = new System.Windows.Forms.ListBox();
            this.TreeViewAutorizaciones = new System.Windows.Forms.TreeView();
            this.AutsUsuarioLbl = new System.Windows.Forms.Label();
            this.DescripcionLbl = new System.Windows.Forms.Label();
            this.PermisosLbl = new System.Windows.Forms.Label();
            this.listBoxPermisos = new System.Windows.Forms.ListBox();
            this.RolesLbl = new System.Windows.Forms.Label();
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.QuitarBtn = new System.Windows.Forms.Button();
            this.DescripcionLbl_ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsuariosLbl
            // 
            this.UsuariosLbl.AutoSize = true;
            this.UsuariosLbl.Location = new System.Drawing.Point(24, 13);
            this.UsuariosLbl.Name = "UsuariosLbl";
            this.UsuariosLbl.Size = new System.Drawing.Size(48, 13);
            this.UsuariosLbl.TabIndex = 0;
            this.UsuariosLbl.Tag = "44";
            this.UsuariosLbl.Text = "Usuarios";
            // 
            // ListBoxUsuarios
            // 
            this.ListBoxUsuarios.FormattingEnabled = true;
            this.ListBoxUsuarios.Location = new System.Drawing.Point(27, 43);
            this.ListBoxUsuarios.Name = "ListBoxUsuarios";
            this.ListBoxUsuarios.Size = new System.Drawing.Size(129, 251);
            this.ListBoxUsuarios.TabIndex = 1;
            this.ListBoxUsuarios.Tag = "0";
            this.ListBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.ListBoxUsuarios_SelectedIndexChanged);
            // 
            // TreeViewAutorizaciones
            // 
            this.TreeViewAutorizaciones.Location = new System.Drawing.Point(162, 42);
            this.TreeViewAutorizaciones.Name = "TreeViewAutorizaciones";
            this.TreeViewAutorizaciones.Size = new System.Drawing.Size(173, 251);
            this.TreeViewAutorizaciones.TabIndex = 2;
            this.TreeViewAutorizaciones.Tag = "0";
            this.TreeViewAutorizaciones.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewAutorizaciones_AfterSelect);
            // 
            // AutsUsuarioLbl
            // 
            this.AutsUsuarioLbl.AutoSize = true;
            this.AutsUsuarioLbl.Location = new System.Drawing.Point(168, 13);
            this.AutsUsuarioLbl.Name = "AutsUsuarioLbl";
            this.AutsUsuarioLbl.Size = new System.Drawing.Size(132, 13);
            this.AutsUsuarioLbl.TabIndex = 3;
            this.AutsUsuarioLbl.Tag = "45";
            this.AutsUsuarioLbl.Text = "Autorizaciones del Usuario";
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(488, 234);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescripcionLbl.TabIndex = 4;
            this.DescripcionLbl.Tag = "22";
            this.DescripcionLbl.Text = "Descripcion";
            // 
            // PermisosLbl
            // 
            this.PermisosLbl.AutoSize = true;
            this.PermisosLbl.Location = new System.Drawing.Point(647, 42);
            this.PermisosLbl.Name = "PermisosLbl";
            this.PermisosLbl.Size = new System.Drawing.Size(49, 13);
            this.PermisosLbl.TabIndex = 3;
            this.PermisosLbl.Tag = "24";
            this.PermisosLbl.Text = "Permisos";
            // 
            // listBoxPermisos
            // 
            this.listBoxPermisos.FormattingEnabled = true;
            this.listBoxPermisos.Location = new System.Drawing.Point(647, 68);
            this.listBoxPermisos.Name = "listBoxPermisos";
            this.listBoxPermisos.Size = new System.Drawing.Size(141, 147);
            this.listBoxPermisos.TabIndex = 2;
            this.listBoxPermisos.Tag = "0";
            this.listBoxPermisos.SelectedIndexChanged += new System.EventHandler(this.listBoxPermisos_SelectedIndexChanged);
            // 
            // RolesLbl
            // 
            this.RolesLbl.AutoSize = true;
            this.RolesLbl.Location = new System.Drawing.Point(488, 43);
            this.RolesLbl.Name = "RolesLbl";
            this.RolesLbl.Size = new System.Drawing.Size(34, 13);
            this.RolesLbl.TabIndex = 1;
            this.RolesLbl.Tag = "23";
            this.RolesLbl.Text = "Roles";
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.Location = new System.Drawing.Point(491, 68);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(141, 147);
            this.listBoxRoles.TabIndex = 0;
            this.listBoxRoles.Tag = "0";
            this.listBoxRoles.SelectedIndexChanged += new System.EventHandler(this.listBoxRoles_SelectedIndexChanged);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(361, 68);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(86, 29);
            this.AgregarBtn.TabIndex = 5;
            this.AgregarBtn.Tag = "19";
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // QuitarBtn
            // 
            this.QuitarBtn.Location = new System.Drawing.Point(361, 186);
            this.QuitarBtn.Name = "QuitarBtn";
            this.QuitarBtn.Size = new System.Drawing.Size(86, 29);
            this.QuitarBtn.TabIndex = 6;
            this.QuitarBtn.Tag = "27";
            this.QuitarBtn.Text = "Quitar";
            this.QuitarBtn.UseVisualStyleBackColor = true;
            this.QuitarBtn.Click += new System.EventHandler(this.QuitarBtn_Click);
            // 
            // DescripcionLbl_
            // 
            this.DescripcionLbl_.AutoSize = true;
            this.DescripcionLbl_.Location = new System.Drawing.Point(491, 265);
            this.DescripcionLbl_.Name = "DescripcionLbl_";
            this.DescripcionLbl_.Size = new System.Drawing.Size(0, 13);
            this.DescripcionLbl_.TabIndex = 7;
            this.DescripcionLbl_.Click += new System.EventHandler(this.DescripcionLbl__Click);
            // 
            // FormPerfilesDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.DescripcionLbl_);
            this.Controls.Add(this.QuitarBtn);
            this.Controls.Add(this.DescripcionLbl);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.PermisosLbl);
            this.Controls.Add(this.listBoxPermisos);
            this.Controls.Add(this.AutsUsuarioLbl);
            this.Controls.Add(this.RolesLbl);
            this.Controls.Add(this.TreeViewAutorizaciones);
            this.Controls.Add(this.listBoxRoles);
            this.Controls.Add(this.ListBoxUsuarios);
            this.Controls.Add(this.UsuariosLbl);
            this.Name = "FormPerfilesDeUsuario";
            this.Text = "Administrar Perfiles de Usuario";
            this.Load += new System.EventHandler(this.FormPerfilesDeUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuariosLbl;
        private System.Windows.Forms.ListBox ListBoxUsuarios;
        private System.Windows.Forms.TreeView TreeViewAutorizaciones;
        private System.Windows.Forms.Label AutsUsuarioLbl;
        private System.Windows.Forms.Label RolesLbl;
        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.ListBox listBoxPermisos;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button QuitarBtn;
        private System.Windows.Forms.Label PermisosLbl;
        private System.Windows.Forms.Label DescripcionLbl;
        private System.Windows.Forms.Label DescripcionLbl_;
    }
}