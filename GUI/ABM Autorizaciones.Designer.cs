namespace GUI
{
    partial class ABM_Autorizaciones
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
            this.RolesLbl = new System.Windows.Forms.Label();
            this.PermisosLbl = new System.Windows.Forms.Label();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.dataGridViewPermisos = new System.Windows.Forms.DataGridView();
            this.idPermLbl = new System.Windows.Forms.Label();
            this.nombrePermLbl = new System.Windows.Forms.Label();
            this.descripcionPermLbl = new System.Windows.Forms.Label();
            this.descripcionRolLbl = new System.Windows.Forms.Label();
            this.nombreRolLbl = new System.Windows.Forms.Label();
            this.textBoxNombreRol = new System.Windows.Forms.TextBox();
            this.textBoxDescRol = new System.Windows.Forms.TextBox();
            this.textBoxIdPermiso = new System.Windows.Forms.TextBox();
            this.textBoxNombrePermiso = new System.Windows.Forms.TextBox();
            this.textBoxDescPermiso = new System.Windows.Forms.TextBox();
            this.AltaBtn = new System.Windows.Forms.Button();
            this.BajaBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.ModifPermBtn = new System.Windows.Forms.Button();
            this.BajaPermBtn = new System.Windows.Forms.Button();
            this.AltaPermBtn = new System.Windows.Forms.Button();
            this.idPermLbl1 = new System.Windows.Forms.Label();
            this.textBoxIdRol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // RolesLbl
            // 
            this.RolesLbl.AutoSize = true;
            this.RolesLbl.Location = new System.Drawing.Point(12, 16);
            this.RolesLbl.Name = "RolesLbl";
            this.RolesLbl.Size = new System.Drawing.Size(34, 13);
            this.RolesLbl.TabIndex = 0;
            this.RolesLbl.Tag = "23";
            this.RolesLbl.Text = "Roles";
            // 
            // PermisosLbl
            // 
            this.PermisosLbl.AutoSize = true;
            this.PermisosLbl.Location = new System.Drawing.Point(423, 16);
            this.PermisosLbl.Name = "PermisosLbl";
            this.PermisosLbl.Size = new System.Drawing.Size(49, 13);
            this.PermisosLbl.TabIndex = 1;
            this.PermisosLbl.Tag = "24";
            this.PermisosLbl.Text = "Permisos";
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.ReadOnly = true;
            this.dataGridViewRoles.Size = new System.Drawing.Size(394, 150);
            this.dataGridViewRoles.TabIndex = 2;
            this.dataGridViewRoles.Tag = "0";
            this.dataGridViewRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoles_CellClick);
            // 
            // dataGridViewPermisos
            // 
            this.dataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermisos.Location = new System.Drawing.Point(426, 44);
            this.dataGridViewPermisos.Name = "dataGridViewPermisos";
            this.dataGridViewPermisos.ReadOnly = true;
            this.dataGridViewPermisos.Size = new System.Drawing.Size(394, 150);
            this.dataGridViewPermisos.TabIndex = 3;
            this.dataGridViewPermisos.Tag = "0";
            this.dataGridViewPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermisos_CellClick);
            // 
            // idPermLbl
            // 
            this.idPermLbl.AutoSize = true;
            this.idPermLbl.Location = new System.Drawing.Point(423, 214);
            this.idPermLbl.Name = "idPermLbl";
            this.idPermLbl.Size = new System.Drawing.Size(16, 13);
            this.idPermLbl.TabIndex = 4;
            this.idPermLbl.Tag = "20";
            this.idPermLbl.Text = "Id";
            // 
            // nombrePermLbl
            // 
            this.nombrePermLbl.AutoSize = true;
            this.nombrePermLbl.Location = new System.Drawing.Point(423, 241);
            this.nombrePermLbl.Name = "nombrePermLbl";
            this.nombrePermLbl.Size = new System.Drawing.Size(44, 13);
            this.nombrePermLbl.TabIndex = 5;
            this.nombrePermLbl.Tag = "21";
            this.nombrePermLbl.Text = "Nombre";
            // 
            // descripcionPermLbl
            // 
            this.descripcionPermLbl.AutoSize = true;
            this.descripcionPermLbl.Location = new System.Drawing.Point(423, 268);
            this.descripcionPermLbl.Name = "descripcionPermLbl";
            this.descripcionPermLbl.Size = new System.Drawing.Size(63, 13);
            this.descripcionPermLbl.TabIndex = 6;
            this.descripcionPermLbl.Tag = "22";
            this.descripcionPermLbl.Text = "Descripcion";
            // 
            // descripcionRolLbl
            // 
            this.descripcionRolLbl.AutoSize = true;
            this.descripcionRolLbl.Location = new System.Drawing.Point(9, 268);
            this.descripcionRolLbl.Name = "descripcionRolLbl";
            this.descripcionRolLbl.Size = new System.Drawing.Size(63, 13);
            this.descripcionRolLbl.TabIndex = 9;
            this.descripcionRolLbl.Tag = "22";
            this.descripcionRolLbl.Text = "Descripcion";
            // 
            // nombreRolLbl
            // 
            this.nombreRolLbl.AutoSize = true;
            this.nombreRolLbl.Location = new System.Drawing.Point(9, 238);
            this.nombreRolLbl.Name = "nombreRolLbl";
            this.nombreRolLbl.Size = new System.Drawing.Size(44, 13);
            this.nombreRolLbl.TabIndex = 8;
            this.nombreRolLbl.Tag = "21";
            this.nombreRolLbl.Text = "Nombre";
            // 
            // textBoxNombreRol
            // 
            this.textBoxNombreRol.Location = new System.Drawing.Point(75, 238);
            this.textBoxNombreRol.Name = "textBoxNombreRol";
            this.textBoxNombreRol.Size = new System.Drawing.Size(331, 20);
            this.textBoxNombreRol.TabIndex = 11;
            // 
            // textBoxDescRol
            // 
            this.textBoxDescRol.Location = new System.Drawing.Point(75, 265);
            this.textBoxDescRol.Name = "textBoxDescRol";
            this.textBoxDescRol.Size = new System.Drawing.Size(331, 20);
            this.textBoxDescRol.TabIndex = 12;
            // 
            // textBoxIdPermiso
            // 
            this.textBoxIdPermiso.Location = new System.Drawing.Point(489, 211);
            this.textBoxIdPermiso.Name = "textBoxIdPermiso";
            this.textBoxIdPermiso.Size = new System.Drawing.Size(331, 20);
            this.textBoxIdPermiso.TabIndex = 13;
            // 
            // textBoxNombrePermiso
            // 
            this.textBoxNombrePermiso.Location = new System.Drawing.Point(489, 238);
            this.textBoxNombrePermiso.Name = "textBoxNombrePermiso";
            this.textBoxNombrePermiso.Size = new System.Drawing.Size(331, 20);
            this.textBoxNombrePermiso.TabIndex = 14;
            // 
            // textBoxDescPermiso
            // 
            this.textBoxDescPermiso.Location = new System.Drawing.Point(489, 265);
            this.textBoxDescPermiso.Name = "textBoxDescPermiso";
            this.textBoxDescPermiso.Size = new System.Drawing.Size(331, 20);
            this.textBoxDescPermiso.TabIndex = 15;
            // 
            // AltaBtn
            // 
            this.AltaBtn.Location = new System.Drawing.Point(75, 296);
            this.AltaBtn.Name = "AltaBtn";
            this.AltaBtn.Size = new System.Drawing.Size(75, 23);
            this.AltaBtn.TabIndex = 16;
            this.AltaBtn.Tag = "19";
            this.AltaBtn.Text = "Alta";
            this.AltaBtn.UseVisualStyleBackColor = true;
            this.AltaBtn.Click += new System.EventHandler(this.AltaBtn_Click);
            // 
            // BajaBtn
            // 
            this.BajaBtn.Location = new System.Drawing.Point(156, 296);
            this.BajaBtn.Name = "BajaBtn";
            this.BajaBtn.Size = new System.Drawing.Size(75, 23);
            this.BajaBtn.TabIndex = 17;
            this.BajaBtn.Tag = "27";
            this.BajaBtn.Text = "Baja";
            this.BajaBtn.UseVisualStyleBackColor = true;
            this.BajaBtn.Click += new System.EventHandler(this.BajaBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Location = new System.Drawing.Point(237, 296);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(75, 23);
            this.ModificarBtn.TabIndex = 18;
            this.ModificarBtn.Tag = "28";
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // ModifPermBtn
            // 
            this.ModifPermBtn.Location = new System.Drawing.Point(651, 296);
            this.ModifPermBtn.Name = "ModifPermBtn";
            this.ModifPermBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifPermBtn.TabIndex = 21;
            this.ModifPermBtn.Tag = "28";
            this.ModifPermBtn.Text = "Modificar";
            this.ModifPermBtn.UseVisualStyleBackColor = true;
            this.ModifPermBtn.Click += new System.EventHandler(this.ModifPermBtn_Click);
            // 
            // BajaPermBtn
            // 
            this.BajaPermBtn.Location = new System.Drawing.Point(570, 296);
            this.BajaPermBtn.Name = "BajaPermBtn";
            this.BajaPermBtn.Size = new System.Drawing.Size(75, 23);
            this.BajaPermBtn.TabIndex = 20;
            this.BajaPermBtn.Tag = "27";
            this.BajaPermBtn.Text = "Baja";
            this.BajaPermBtn.UseVisualStyleBackColor = true;
            this.BajaPermBtn.Click += new System.EventHandler(this.BajaPermBtn_Click);
            // 
            // AltaPermBtn
            // 
            this.AltaPermBtn.Location = new System.Drawing.Point(489, 296);
            this.AltaPermBtn.Name = "AltaPermBtn";
            this.AltaPermBtn.Size = new System.Drawing.Size(75, 23);
            this.AltaPermBtn.TabIndex = 19;
            this.AltaPermBtn.Tag = "19";
            this.AltaPermBtn.Text = "Alta";
            this.AltaPermBtn.UseVisualStyleBackColor = true;
            this.AltaPermBtn.Click += new System.EventHandler(this.AltaPermBtn_Click);
            // 
            // idPermLbl1
            // 
            this.idPermLbl1.AutoSize = true;
            this.idPermLbl1.Location = new System.Drawing.Point(30, 214);
            this.idPermLbl1.Name = "idPermLbl1";
            this.idPermLbl1.Size = new System.Drawing.Size(16, 13);
            this.idPermLbl1.TabIndex = 22;
            this.idPermLbl1.Tag = "20";
            this.idPermLbl1.Text = "Id";
            // 
            // textBoxIdRol
            // 
            this.textBoxIdRol.Location = new System.Drawing.Point(75, 211);
            this.textBoxIdRol.Name = "textBoxIdRol";
            this.textBoxIdRol.Size = new System.Drawing.Size(331, 20);
            this.textBoxIdRol.TabIndex = 23;
            // 
            // ABM_Autorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 331);
            this.Controls.Add(this.textBoxIdRol);
            this.Controls.Add(this.idPermLbl1);
            this.Controls.Add(this.ModifPermBtn);
            this.Controls.Add(this.BajaPermBtn);
            this.Controls.Add(this.AltaPermBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.BajaBtn);
            this.Controls.Add(this.AltaBtn);
            this.Controls.Add(this.textBoxDescPermiso);
            this.Controls.Add(this.textBoxNombrePermiso);
            this.Controls.Add(this.textBoxIdPermiso);
            this.Controls.Add(this.textBoxDescRol);
            this.Controls.Add(this.textBoxNombreRol);
            this.Controls.Add(this.descripcionRolLbl);
            this.Controls.Add(this.nombreRolLbl);
            this.Controls.Add(this.descripcionPermLbl);
            this.Controls.Add(this.nombrePermLbl);
            this.Controls.Add(this.idPermLbl);
            this.Controls.Add(this.dataGridViewPermisos);
            this.Controls.Add(this.dataGridViewRoles);
            this.Controls.Add(this.PermisosLbl);
            this.Controls.Add(this.RolesLbl);
            this.Name = "ABM_Autorizaciones";
            this.Text = "ABM Autorizaciones";
            this.Load += new System.EventHandler(this.ABM_Autorizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RolesLbl;
        private System.Windows.Forms.Label PermisosLbl;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.DataGridView dataGridViewPermisos;
        private System.Windows.Forms.Label idPermLbl;
        private System.Windows.Forms.Label nombrePermLbl;
        private System.Windows.Forms.Label descripcionPermLbl;
        private System.Windows.Forms.Label descripcionRolLbl;
        private System.Windows.Forms.Label nombreRolLbl;
        private System.Windows.Forms.TextBox textBoxNombreRol;
        private System.Windows.Forms.TextBox textBoxDescRol;
        private System.Windows.Forms.TextBox textBoxIdPermiso;
        private System.Windows.Forms.TextBox textBoxNombrePermiso;
        private System.Windows.Forms.TextBox textBoxDescPermiso;
        private System.Windows.Forms.Button AltaBtn;
        private System.Windows.Forms.Button BajaBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button ModifPermBtn;
        private System.Windows.Forms.Button BajaPermBtn;
        private System.Windows.Forms.Button AltaPermBtn;
        private System.Windows.Forms.Label idPermLbl1;
        private System.Windows.Forms.TextBox textBoxIdRol;
    }
}