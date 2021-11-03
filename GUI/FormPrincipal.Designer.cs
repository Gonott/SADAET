namespace GUI
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UsarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogInToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosYDevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedirRetiroDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adondicionarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarEquipoEspecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectorInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoEgresoDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoEgresoDeComponentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarAutorizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMAutorizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarIdiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupYRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitosVerificadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsarioToolStripMenuItem,
            this.pedidosYDevolucionesToolStripMenuItem,
            this.gestiónDePedidosToolStripMenuItem,
            this.entregasYToolStripMenuItem,
            this.sectorInventarioToolStripMenuItem,
            this.perfilesToolStripMenuItem,
            this.idiomasToolStripMenuItem,
            this.auditoríaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Tag = "0";
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UsarioToolStripMenuItem
            // 
            this.UsarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogInToolStripMenu,
            this.salirDelSistemaToolStripMenuItem1});
            this.UsarioToolStripMenuItem.Name = "UsarioToolStripMenuItem";
            this.UsarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.UsarioToolStripMenuItem.Tag = "0";
            this.UsarioToolStripMenuItem.Text = "Usuario";
            this.UsarioToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // LogInToolStripMenu
            // 
            this.LogInToolStripMenu.Name = "LogInToolStripMenu";
            this.LogInToolStripMenu.Size = new System.Drawing.Size(143, 22);
            this.LogInToolStripMenu.Tag = "0";
            this.LogInToolStripMenu.Text = "Iniciar Sesion";
            this.LogInToolStripMenu.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem1
            // 
            this.salirDelSistemaToolStripMenuItem1.Name = "salirDelSistemaToolStripMenuItem1";
            this.salirDelSistemaToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.salirDelSistemaToolStripMenuItem1.Tag = "0";
            this.salirDelSistemaToolStripMenuItem1.Text = "Cerrar Sesion";
            this.salirDelSistemaToolStripMenuItem1.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem1_Click);
            // 
            // pedidosYDevolucionesToolStripMenuItem
            // 
            this.pedidosYDevolucionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarEquipoToolStripMenuItem,
            this.pedirRetiroDeEquipoToolStripMenuItem});
            this.pedidosYDevolucionesToolStripMenuItem.Enabled = false;
            this.pedidosYDevolucionesToolStripMenuItem.Name = "pedidosYDevolucionesToolStripMenuItem";
            this.pedidosYDevolucionesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.pedidosYDevolucionesToolStripMenuItem.Tag = "1";
            this.pedidosYDevolucionesToolStripMenuItem.Text = "Gestión de Pedidos";
            this.pedidosYDevolucionesToolStripMenuItem.Click += new System.EventHandler(this.pedidosYDevolucionesToolStripMenuItem_Click);
            // 
            // solicitarEquipoToolStripMenuItem
            // 
            this.solicitarEquipoToolStripMenuItem.Enabled = false;
            this.solicitarEquipoToolStripMenuItem.Name = "solicitarEquipoToolStripMenuItem";
            this.solicitarEquipoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.solicitarEquipoToolStripMenuItem.Tag = "2";
            this.solicitarEquipoToolStripMenuItem.Text = "Solicitar Equipo";
            this.solicitarEquipoToolStripMenuItem.Click += new System.EventHandler(this.solicitarEquipoToolStripMenuItem_Click);
            // 
            // pedirRetiroDeEquipoToolStripMenuItem
            // 
            this.pedirRetiroDeEquipoToolStripMenuItem.Enabled = false;
            this.pedirRetiroDeEquipoToolStripMenuItem.Name = "pedirRetiroDeEquipoToolStripMenuItem";
            this.pedirRetiroDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pedirRetiroDeEquipoToolStripMenuItem.Tag = "3";
            this.pedirRetiroDeEquipoToolStripMenuItem.Text = "Solicitar Retiro de Equipo";
            this.pedirRetiroDeEquipoToolStripMenuItem.Click += new System.EventHandler(this.pedirRetiroDeEquipoToolStripMenuItem_Click);
            // 
            // gestiónDePedidosToolStripMenuItem
            // 
            this.gestiónDePedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarEquipoToolStripMenuItem,
            this.adondicionarEquipoToolStripMenuItem,
            this.configurarEquipoEspecialToolStripMenuItem});
            this.gestiónDePedidosToolStripMenuItem.Enabled = false;
            this.gestiónDePedidosToolStripMenuItem.Name = "gestiónDePedidosToolStripMenuItem";
            this.gestiónDePedidosToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.gestiónDePedidosToolStripMenuItem.Tag = "4";
            this.gestiónDePedidosToolStripMenuItem.Text = "Gestión Técnica";
            this.gestiónDePedidosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDePedidosToolStripMenuItem_Click);
            // 
            // asignarEquipoToolStripMenuItem
            // 
            this.asignarEquipoToolStripMenuItem.Enabled = false;
            this.asignarEquipoToolStripMenuItem.Name = "asignarEquipoToolStripMenuItem";
            this.asignarEquipoToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.asignarEquipoToolStripMenuItem.Tag = "5";
            this.asignarEquipoToolStripMenuItem.Text = "Asignar Equipos";
            this.asignarEquipoToolStripMenuItem.Click += new System.EventHandler(this.asignarEquipoToolStripMenuItem_Click);
            // 
            // adondicionarEquipoToolStripMenuItem
            // 
            this.adondicionarEquipoToolStripMenuItem.Enabled = false;
            this.adondicionarEquipoToolStripMenuItem.Name = "adondicionarEquipoToolStripMenuItem";
            this.adondicionarEquipoToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.adondicionarEquipoToolStripMenuItem.Tag = "6";
            this.adondicionarEquipoToolStripMenuItem.Text = "Buscar Componentes";
            this.adondicionarEquipoToolStripMenuItem.Click += new System.EventHandler(this.adondicionarEquipoToolStripMenuItem_Click);
            // 
            // configurarEquipoEspecialToolStripMenuItem
            // 
            this.configurarEquipoEspecialToolStripMenuItem.Enabled = false;
            this.configurarEquipoEspecialToolStripMenuItem.Name = "configurarEquipoEspecialToolStripMenuItem";
            this.configurarEquipoEspecialToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.configurarEquipoEspecialToolStripMenuItem.Tag = "7";
            this.configurarEquipoEspecialToolStripMenuItem.Text = "Marcar Equipos Configurados";
            this.configurarEquipoEspecialToolStripMenuItem.Click += new System.EventHandler(this.configurarEquipoEspecialToolStripMenuItem_Click);
            // 
            // entregasYToolStripMenuItem
            // 
            this.entregasYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.búsquedaDeToolStripMenuItem});
            this.entregasYToolStripMenuItem.Enabled = false;
            this.entregasYToolStripMenuItem.Name = "entregasYToolStripMenuItem";
            this.entregasYToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.entregasYToolStripMenuItem.Tag = "8";
            this.entregasYToolStripMenuItem.Text = "Gestión Legal";
            this.entregasYToolStripMenuItem.Click += new System.EventHandler(this.entregasYToolStripMenuItem_Click);
            // 
            // búsquedaDeToolStripMenuItem
            // 
            this.búsquedaDeToolStripMenuItem.Enabled = false;
            this.búsquedaDeToolStripMenuItem.Name = "búsquedaDeToolStripMenuItem";
            this.búsquedaDeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.búsquedaDeToolStripMenuItem.Tag = "9";
            this.búsquedaDeToolStripMenuItem.Text = "Emitir Comodato";
            this.búsquedaDeToolStripMenuItem.Click += new System.EventHandler(this.búsquedaDeToolStripMenuItem_Click);
            // 
            // sectorInventarioToolStripMenuItem
            // 
            this.sectorInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoEgresoDeEquipoToolStripMenuItem,
            this.ingresoEgresoDeComponentesToolStripMenuItem});
            this.sectorInventarioToolStripMenuItem.Enabled = false;
            this.sectorInventarioToolStripMenuItem.Name = "sectorInventarioToolStripMenuItem";
            this.sectorInventarioToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sectorInventarioToolStripMenuItem.Tag = "10";
            this.sectorInventarioToolStripMenuItem.Text = "Correo";
            this.sectorInventarioToolStripMenuItem.Click += new System.EventHandler(this.sectorInventarioToolStripMenuItem_Click);
            // 
            // ingresoEgresoDeEquipoToolStripMenuItem
            // 
            this.ingresoEgresoDeEquipoToolStripMenuItem.Enabled = false;
            this.ingresoEgresoDeEquipoToolStripMenuItem.Name = "ingresoEgresoDeEquipoToolStripMenuItem";
            this.ingresoEgresoDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresoEgresoDeEquipoToolStripMenuItem.Tag = "11";
            this.ingresoEgresoDeEquipoToolStripMenuItem.Text = "Equipos Entregados";
            this.ingresoEgresoDeEquipoToolStripMenuItem.Click += new System.EventHandler(this.ingresoEgresoDeEquipoToolStripMenuItem_Click);
            // 
            // ingresoEgresoDeComponentesToolStripMenuItem
            // 
            this.ingresoEgresoDeComponentesToolStripMenuItem.Enabled = false;
            this.ingresoEgresoDeComponentesToolStripMenuItem.Name = "ingresoEgresoDeComponentesToolStripMenuItem";
            this.ingresoEgresoDeComponentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresoEgresoDeComponentesToolStripMenuItem.Tag = "12";
            this.ingresoEgresoDeComponentesToolStripMenuItem.Text = "Equipos a Retirar";
            this.ingresoEgresoDeComponentesToolStripMenuItem.Click += new System.EventHandler(this.ingresoEgresoDeComponentesToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPerfilesToolStripMenuItem,
            this.administrarAutorizacionesToolStripMenuItem,
            this.aBMAutorizacionesToolStripMenuItem,
            this.aBMUsuariosToolStripMenuItem});
            this.perfilesToolStripMenuItem.Enabled = false;
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.perfilesToolStripMenuItem.Tag = "13";
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            // 
            // administrarPerfilesToolStripMenuItem
            // 
            this.administrarPerfilesToolStripMenuItem.Enabled = false;
            this.administrarPerfilesToolStripMenuItem.Name = "administrarPerfilesToolStripMenuItem";
            this.administrarPerfilesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.administrarPerfilesToolStripMenuItem.Tag = "14";
            this.administrarPerfilesToolStripMenuItem.Text = "Administrar Perfiles";
            this.administrarPerfilesToolStripMenuItem.Click += new System.EventHandler(this.administrarPerfilesToolStripMenuItem_Click);
            // 
            // administrarAutorizacionesToolStripMenuItem
            // 
            this.administrarAutorizacionesToolStripMenuItem.Enabled = false;
            this.administrarAutorizacionesToolStripMenuItem.Name = "administrarAutorizacionesToolStripMenuItem";
            this.administrarAutorizacionesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.administrarAutorizacionesToolStripMenuItem.Tag = "15";
            this.administrarAutorizacionesToolStripMenuItem.Text = "Administrar Roles";
            this.administrarAutorizacionesToolStripMenuItem.Click += new System.EventHandler(this.administrarAutorizacionesToolStripMenuItem_Click);
            // 
            // aBMAutorizacionesToolStripMenuItem
            // 
            this.aBMAutorizacionesToolStripMenuItem.Enabled = false;
            this.aBMAutorizacionesToolStripMenuItem.Name = "aBMAutorizacionesToolStripMenuItem";
            this.aBMAutorizacionesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aBMAutorizacionesToolStripMenuItem.Tag = "16";
            this.aBMAutorizacionesToolStripMenuItem.Text = "ABM Autorizaciones";
            this.aBMAutorizacionesToolStripMenuItem.Click += new System.EventHandler(this.aBMAutorizacionesToolStripMenuItem_Click);
            // 
            // aBMUsuariosToolStripMenuItem
            // 
            this.aBMUsuariosToolStripMenuItem.Enabled = false;
            this.aBMUsuariosToolStripMenuItem.Name = "aBMUsuariosToolStripMenuItem";
            this.aBMUsuariosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aBMUsuariosToolStripMenuItem.Tag = "46";
            this.aBMUsuariosToolStripMenuItem.Text = "ABM Usuarios";
            this.aBMUsuariosToolStripMenuItem.Click += new System.EventHandler(this.aBMUsuariosToolStripMenuItem_Click);
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarIdiomaToolStripMenuItem,
            this.agregarIdiomasToolStripMenuItem});
            this.idiomasToolStripMenuItem.Enabled = false;
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.idiomasToolStripMenuItem.Tag = "17";
            this.idiomasToolStripMenuItem.Text = "Idiomas";
            this.idiomasToolStripMenuItem.Click += new System.EventHandler(this.idiomasToolStripMenuItem_Click);
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.Enabled = false;
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cambiarIdiomaToolStripMenuItem.Tag = "18";
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            this.cambiarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.cambiarIdiomaToolStripMenuItem_Click);
            // 
            // agregarIdiomasToolStripMenuItem
            // 
            this.agregarIdiomasToolStripMenuItem.Enabled = false;
            this.agregarIdiomasToolStripMenuItem.Name = "agregarIdiomasToolStripMenuItem";
            this.agregarIdiomasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.agregarIdiomasToolStripMenuItem.Tag = "19";
            this.agregarIdiomasToolStripMenuItem.Text = "Agregar Idiomas";
            this.agregarIdiomasToolStripMenuItem.Click += new System.EventHandler(this.agregarIdiomasToolStripMenuItem_Click);
            // 
            // auditoríaToolStripMenuItem
            // 
            this.auditoríaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitacoraToolStripMenuItem,
            this.controlDeCambiosToolStripMenuItem,
            this.backupYRestoreToolStripMenuItem,
            this.digitosVerificadoresToolStripMenuItem});
            this.auditoríaToolStripMenuItem.Enabled = false;
            this.auditoríaToolStripMenuItem.Name = "auditoríaToolStripMenuItem";
            this.auditoríaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.auditoríaToolStripMenuItem.Tag = "47";
            this.auditoríaToolStripMenuItem.Text = "Auditoría";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Enabled = false;
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.bitacoraToolStripMenuItem.Tag = "48";
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // controlDeCambiosToolStripMenuItem
            // 
            this.controlDeCambiosToolStripMenuItem.Enabled = false;
            this.controlDeCambiosToolStripMenuItem.Name = "controlDeCambiosToolStripMenuItem";
            this.controlDeCambiosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.controlDeCambiosToolStripMenuItem.Tag = "49";
            this.controlDeCambiosToolStripMenuItem.Text = "Control de Cambios";
            this.controlDeCambiosToolStripMenuItem.Click += new System.EventHandler(this.controlDeCambiosToolStripMenuItem_Click);
            // 
            // backupYRestoreToolStripMenuItem
            // 
            this.backupYRestoreToolStripMenuItem.Enabled = false;
            this.backupYRestoreToolStripMenuItem.Name = "backupYRestoreToolStripMenuItem";
            this.backupYRestoreToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.backupYRestoreToolStripMenuItem.Tag = "50";
            this.backupYRestoreToolStripMenuItem.Text = "Backup y Restore";
            this.backupYRestoreToolStripMenuItem.Click += new System.EventHandler(this.backupYRestoreToolStripMenuItem_Click);
            // 
            // digitosVerificadoresToolStripMenuItem
            // 
            this.digitosVerificadoresToolStripMenuItem.Enabled = false;
            this.digitosVerificadoresToolStripMenuItem.Name = "digitosVerificadoresToolStripMenuItem";
            this.digitosVerificadoresToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.digitosVerificadoresToolStripMenuItem.Tag = "51";
            this.digitosVerificadoresToolStripMenuItem.Text = "Digitos Verificadores";
            this.digitosVerificadoresToolStripMenuItem.Click += new System.EventHandler(this.digitosVerificadoresToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "SADAET";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem pedidosYDevolucionesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestiónDePedidosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem entregasYToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem búsquedaDeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sectorInventarioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ingresoEgresoDeEquipoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ingresoEgresoDeComponentesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem solicitarEquipoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pedirRetiroDeEquipoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem asignarEquipoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adondicionarEquipoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem UsarioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem LogInToolStripMenu;
        public System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configurarEquipoEspecialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarAutorizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMAutorizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarIdiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupYRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitosVerificadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMUsuariosToolStripMenuItem;
    }
}

