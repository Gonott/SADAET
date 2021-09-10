namespace GUI
{
    partial class Form_MarcarConfigurado
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataGridViewSolicitudes = new System.Windows.Forms.DataGridView();
            this.labelSolicitudesPreparadas = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxLegajo = new System.Windows.Forms.TextBox();
            this.textBoxCodSolic = new System.Windows.Forms.TextBox();
            this.buttonPerifericos = new System.Windows.Forms.Button();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodSolicitud = new System.Windows.Forms.Label();
            this.dataGridViewPerifericos = new System.Windows.Forms.DataGridView();
            this.buttonRemito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerifericos)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReporteRemito.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(548, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(490, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataGridViewSolicitudes
            // 
            this.dataGridViewSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitudes.Location = new System.Drawing.Point(21, 38);
            this.dataGridViewSolicitudes.Name = "dataGridViewSolicitudes";
            this.dataGridViewSolicitudes.Size = new System.Drawing.Size(521, 134);
            this.dataGridViewSolicitudes.TabIndex = 1;
            this.dataGridViewSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSolicitudes_CellClick);
            this.dataGridViewSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelSolicitudesPreparadas
            // 
            this.labelSolicitudesPreparadas.AutoSize = true;
            this.labelSolicitudesPreparadas.Location = new System.Drawing.Point(21, 19);
            this.labelSolicitudesPreparadas.Name = "labelSolicitudesPreparadas";
            this.labelSolicitudesPreparadas.Size = new System.Drawing.Size(115, 13);
            this.labelSolicitudesPreparadas.TabIndex = 2;
            this.labelSolicitudesPreparadas.Tag = "29";
            this.labelSolicitudesPreparadas.Text = "Solicitudes Preparadas";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(393, 250);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.ReadOnly = true;
            this.textBoxTelefono.Size = new System.Drawing.Size(131, 20);
            this.textBoxTelefono.TabIndex = 12;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(86, 250);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.ReadOnly = true;
            this.textBoxDireccion.Size = new System.Drawing.Size(245, 20);
            this.textBoxDireccion.TabIndex = 11;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(393, 220);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.ReadOnly = true;
            this.textBoxDNI.Size = new System.Drawing.Size(131, 20);
            this.textBoxDNI.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(199, 220);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(156, 20);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxLegajo
            // 
            this.textBoxLegajo.Location = new System.Drawing.Point(73, 220);
            this.textBoxLegajo.Name = "textBoxLegajo";
            this.textBoxLegajo.ReadOnly = true;
            this.textBoxLegajo.Size = new System.Drawing.Size(64, 20);
            this.textBoxLegajo.TabIndex = 8;
            // 
            // textBoxCodSolic
            // 
            this.textBoxCodSolic.Location = new System.Drawing.Point(118, 188);
            this.textBoxCodSolic.Name = "textBoxCodSolic";
            this.textBoxCodSolic.ReadOnly = true;
            this.textBoxCodSolic.Size = new System.Drawing.Size(75, 20);
            this.textBoxCodSolic.TabIndex = 7;
            // 
            // buttonPerifericos
            // 
            this.buttonPerifericos.Location = new System.Drawing.Point(341, 283);
            this.buttonPerifericos.Name = "buttonPerifericos";
            this.buttonPerifericos.Size = new System.Drawing.Size(196, 24);
            this.buttonPerifericos.TabIndex = 6;
            this.buttonPerifericos.Tag = "19";
            this.buttonPerifericos.Text = "Agregar Perifericos";
            this.buttonPerifericos.UseVisualStyleBackColor = true;
            this.buttonPerifericos.Click += new System.EventHandler(this.buttonPerifericos_Click);
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Location = new System.Drawing.Point(28, 223);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(39, 13);
            this.labelLegajo.TabIndex = 5;
            this.labelLegajo.Tag = "20";
            this.labelLegajo.Text = "Legajo";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(361, 223);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 4;
            this.labelDNI.Text = "DNI";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(338, 253);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 3;
            this.labelTelefono.Tag = "38";
            this.labelTelefono.Text = "Telefono";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(28, 253);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Tag = "37";
            this.labelDireccion.Text = "Direccion";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(149, 223);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Tag = "21";
            this.labelNombre.Text = "Nombre";
            // 
            // labelCodSolicitud
            // 
            this.labelCodSolicitud.AutoSize = true;
            this.labelCodSolicitud.Location = new System.Drawing.Point(28, 192);
            this.labelCodSolicitud.Name = "labelCodSolicitud";
            this.labelCodSolicitud.Size = new System.Drawing.Size(83, 13);
            this.labelCodSolicitud.TabIndex = 0;
            this.labelCodSolicitud.Tag = "36";
            this.labelCodSolicitud.Text = "Codigo Solicitud";
            // 
            // dataGridViewPerifericos
            // 
            this.dataGridViewPerifericos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerifericos.Location = new System.Drawing.Point(21, 337);
            this.dataGridViewPerifericos.Name = "dataGridViewPerifericos";
            this.dataGridViewPerifericos.Size = new System.Drawing.Size(387, 114);
            this.dataGridViewPerifericos.TabIndex = 4;
            // 
            // buttonRemito
            // 
            this.buttonRemito.Location = new System.Drawing.Point(414, 337);
            this.buttonRemito.Name = "buttonRemito";
            this.buttonRemito.Size = new System.Drawing.Size(128, 114);
            this.buttonRemito.TabIndex = 5;
            this.buttonRemito.Tag = "39";
            this.buttonRemito.Text = "Generar Remito";
            this.buttonRemito.UseVisualStyleBackColor = true;
            this.buttonRemito.Click += new System.EventHandler(this.buttonRemito_Click);
            // 
            // Form_MarcarConfigurado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 463);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.buttonRemito);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.dataGridViewPerifericos);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelSolicitudesPreparadas);
            this.Controls.Add(this.textBoxLegajo);
            this.Controls.Add(this.dataGridViewSolicitudes);
            this.Controls.Add(this.textBoxCodSolic);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.buttonPerifericos);
            this.Controls.Add(this.labelCodSolicitud);
            this.Controls.Add(this.labelLegajo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelTelefono);
            this.Name = "Form_MarcarConfigurado";
            this.Text = "Marcar Configurado";
            this.Load += new System.EventHandler(this.Form_MarcarConfigurado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerifericos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridView dataGridViewSolicitudes;
        private System.Windows.Forms.Label labelSolicitudesPreparadas;
        private System.Windows.Forms.Button buttonPerifericos;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodSolicitud;
        private System.Windows.Forms.DataGridView dataGridViewPerifericos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxLegajo;
        private System.Windows.Forms.TextBox textBoxCodSolic;
        private System.Windows.Forms.Button buttonRemito;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
    }
}