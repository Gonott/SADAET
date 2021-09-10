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
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosYDevolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedirRetiroDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adondicionarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesGeneradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarRemitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.búsquedaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectorInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoEgresoDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoEgresoDeComponentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recomendacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarEquipoEspecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.pedidosYDevolucionesToolStripMenuItem,
            this.gestiónDePedidosToolStripMenuItem,
            this.entregasYToolStripMenuItem,
            this.sectorInventarioToolStripMenuItem,
            this.recomendacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem1});
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.logInToolStripMenuItem.Text = "Usuario";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Iniciar Sesion";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem1
            // 
            this.salirDelSistemaToolStripMenuItem1.Name = "salirDelSistemaToolStripMenuItem1";
            this.salirDelSistemaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
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
            this.pedidosYDevolucionesToolStripMenuItem.Text = "Gestión de Pedidos";
            // 
            // solicitarEquipoToolStripMenuItem
            // 
            this.solicitarEquipoToolStripMenuItem.Enabled = false;
            this.solicitarEquipoToolStripMenuItem.Name = "solicitarEquipoToolStripMenuItem";
            this.solicitarEquipoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.solicitarEquipoToolStripMenuItem.Text = "Solicitar Equipo";
            // 
            // pedirRetiroDeEquipoToolStripMenuItem
            // 
            this.pedirRetiroDeEquipoToolStripMenuItem.Enabled = false;
            this.pedirRetiroDeEquipoToolStripMenuItem.Name = "pedirRetiroDeEquipoToolStripMenuItem";
            this.pedirRetiroDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pedirRetiroDeEquipoToolStripMenuItem.Text = "Solicitar Retiro de Equipo";
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
            this.gestiónDePedidosToolStripMenuItem.Text = "Gestión Técnica";
            this.gestiónDePedidosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDePedidosToolStripMenuItem_Click);
            // 
            // asignarEquipoToolStripMenuItem
            // 
            this.asignarEquipoToolStripMenuItem.Enabled = false;
            this.asignarEquipoToolStripMenuItem.Name = "asignarEquipoToolStripMenuItem";
            this.asignarEquipoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.asignarEquipoToolStripMenuItem.Text = "Asignar Equipos";
            // 
            // adondicionarEquipoToolStripMenuItem
            // 
            this.adondicionarEquipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesGeneradasToolStripMenuItem,
            this.generarRemitosToolStripMenuItem});
            this.adondicionarEquipoToolStripMenuItem.Enabled = false;
            this.adondicionarEquipoToolStripMenuItem.Name = "adondicionarEquipoToolStripMenuItem";
            this.adondicionarEquipoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.adondicionarEquipoToolStripMenuItem.Text = "Acondicionar Equipos";
            // 
            // ordenesGeneradasToolStripMenuItem
            // 
            this.ordenesGeneradasToolStripMenuItem.Enabled = false;
            this.ordenesGeneradasToolStripMenuItem.Name = "ordenesGeneradasToolStripMenuItem";
            this.ordenesGeneradasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ordenesGeneradasToolStripMenuItem.Text = "Ordenes Generadas";
            // 
            // generarRemitosToolStripMenuItem
            // 
            this.generarRemitosToolStripMenuItem.Enabled = false;
            this.generarRemitosToolStripMenuItem.Name = "generarRemitosToolStripMenuItem";
            this.generarRemitosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.generarRemitosToolStripMenuItem.Text = "Generar Remitos";
            // 
            // entregasYToolStripMenuItem
            // 
            this.entregasYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.búsquedaDeToolStripMenuItem});
            this.entregasYToolStripMenuItem.Enabled = false;
            this.entregasYToolStripMenuItem.Name = "entregasYToolStripMenuItem";
            this.entregasYToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.entregasYToolStripMenuItem.Text = "Gestión Legal";
            this.entregasYToolStripMenuItem.Click += new System.EventHandler(this.entregasYToolStripMenuItem_Click);
            // 
            // búsquedaDeToolStripMenuItem
            // 
            this.búsquedaDeToolStripMenuItem.Enabled = false;
            this.búsquedaDeToolStripMenuItem.Name = "búsquedaDeToolStripMenuItem";
            this.búsquedaDeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.búsquedaDeToolStripMenuItem.Text = "Confeccionar Comodato";
            this.búsquedaDeToolStripMenuItem.Click += new System.EventHandler(this.búsquedaDeToolStripMenuItem_Click);
            // 
            // sectorInventarioToolStripMenuItem
            // 
            this.sectorInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoEgresoDeEquipoToolStripMenuItem,
            this.ingresoEgresoDeComponentesToolStripMenuItem});
            this.sectorInventarioToolStripMenuItem.Enabled = false;
            this.sectorInventarioToolStripMenuItem.Name = "sectorInventarioToolStripMenuItem";
            this.sectorInventarioToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.sectorInventarioToolStripMenuItem.Text = "Envíos y Retiros";
            this.sectorInventarioToolStripMenuItem.Click += new System.EventHandler(this.sectorInventarioToolStripMenuItem_Click);
            // 
            // ingresoEgresoDeEquipoToolStripMenuItem
            // 
            this.ingresoEgresoDeEquipoToolStripMenuItem.Enabled = false;
            this.ingresoEgresoDeEquipoToolStripMenuItem.Name = "ingresoEgresoDeEquipoToolStripMenuItem";
            this.ingresoEgresoDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresoEgresoDeEquipoToolStripMenuItem.Text = "Marcar Entregados";
            // 
            // ingresoEgresoDeComponentesToolStripMenuItem
            // 
            this.ingresoEgresoDeComponentesToolStripMenuItem.Enabled = false;
            this.ingresoEgresoDeComponentesToolStripMenuItem.Name = "ingresoEgresoDeComponentesToolStripMenuItem";
            this.ingresoEgresoDeComponentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresoEgresoDeComponentesToolStripMenuItem.Text = "Equipos a Retirar";
            // 
            // recomendacionesToolStripMenuItem
            // 
            this.recomendacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraDeEquiposToolStripMenuItem});
            this.recomendacionesToolStripMenuItem.Enabled = false;
            this.recomendacionesToolStripMenuItem.Name = "recomendacionesToolStripMenuItem";
            this.recomendacionesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.recomendacionesToolStripMenuItem.Text = "Logística";
            // 
            // compraDeEquiposToolStripMenuItem
            // 
            this.compraDeEquiposToolStripMenuItem.Enabled = false;
            this.compraDeEquiposToolStripMenuItem.Name = "compraDeEquiposToolStripMenuItem";
            this.compraDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.compraDeEquiposToolStripMenuItem.Text = "Solicitudes de Adquicisiones";
            // 
            // configurarEquipoEspecialToolStripMenuItem
            // 
            this.configurarEquipoEspecialToolStripMenuItem.Enabled = false;
            this.configurarEquipoEspecialToolStripMenuItem.Name = "configurarEquipoEspecialToolStripMenuItem";
            this.configurarEquipoEspecialToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.configurarEquipoEspecialToolStripMenuItem.Text = "Configurar Equipo Especial";
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
        public System.Windows.Forms.ToolStripMenuItem recomendacionesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem compraDeEquiposToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem ordenesGeneradasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem generarRemitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarEquipoEspecialToolStripMenuItem;
    }
}

