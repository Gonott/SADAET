using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERVICIOS;
using BLL;
using System.Xml;
using SERVICIOS.ObserverIdioma;
using System.Security.Cryptography.X509Certificates;

namespace GUI
{
    public partial class FormPrincipal : Form, IIdiomaObserver

    {
        Form_Login FormAut = new Form_Login();
        public List<Object> ControlesForm = new List<object>();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        GestorIdiomasBLL gestoridiomas = new GestorIdiomasBLL();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void gestiónDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void búsquedaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ComodatoLegal formComodato = new Form_ComodatoLegal();
            formComodato.MdiParent = this;
            formComodato.Show();
        }

        private void sectorInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Idioma idioma_ = new Idioma();
            Sesion.ObtenerInstancia.EsteIdioma = idioma_;
            Subject.AgregarObserver(this);


        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormAut.IsDisposed)
            {
                FormAut = new Form_Login();
            }
            
            FormAut.MdiParent = this;
            FormAut.FormParent = this;
            FormAut.Show();


        }

        private void salirDelSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            SalirDelSistema();

        }


        public void SalirDelSistema()
        {
            try
            {
                foreach (ToolStripItem item in this.menuStrip1.Items)
                {
                    item.Enabled = false;
                }
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }

                this.UsarioToolStripMenuItem.Enabled = true;
                this.LogInToolStripMenu.Enabled = true;
                usuarioBLL.CerrarSesion();

            }
            catch (Exception)
            {
                MessageBox.Show("Ya has cerrado sesion");

            }
        }

        private void entregasYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarAutorizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEdicionDeRoles formRoles = new FormEdicionDeRoles();
            formRoles.MdiParent = this;
            formRoles.Show();   
        }

        private void administrarPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerfilesDeUsuario formperfiles = new FormPerfilesDeUsuario();
            formperfiles.MdiParent = this;
            formperfiles.Show();
            
        }

        private void aBMAutorizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Autorizaciones formABMautorizaciones = new ABM_Autorizaciones();
            formABMautorizaciones.MdiParent = this;
            formABMautorizaciones.Show();
        }




        private void asignarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignación_de_Equipos formAsignacion = new Asignación_de_Equipos();
            formAsignacion.MdiParent = this;
            formAsignacion.Show();
        }

        private void solicitarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SolicitudDeEquipo formSolicitud = new Form_SolicitudDeEquipo();
            formSolicitud.MdiParent = this;
            formSolicitud.Show();
        }


        

#region Gestion de Idioma

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elegir_Idioma formElegirIdioma = new Elegir_Idioma();
            formElegirIdioma.MdiParent = this;
            formElegirIdioma.Show();
        }


        public void Update(Idioma idioma)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.Tag != null) //siempre verifico primero que sea null, si verifico que sea 0 antes, rompe
                {
                    if (int.Parse(item.Tag.ToString()) != 0)
                    {
                        item.Text = gestoridiomas.Traducir(Sesion.ObtenerInstancia.EsteIdioma, int.Parse(item.Tag.ToString()));
                        
                        if (item.DropDown.Items.Count > 0) //aca vamos a ir a traducir los subitems si es que tiene
                        {
                            foreach (ToolStripMenuItem subitem in item.DropDown.Items)
                            {
                                subitem.Text = gestoridiomas.Traducir(Sesion.ObtenerInstancia.EsteIdioma, int.Parse(subitem.Tag.ToString()));
                            }
                        }

                    }
                }
                else
                {

                }
                
            }
        }


        private void agregarIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AgregarIdioma formagregaridioma = new Form_AgregarIdioma();
            formagregaridioma.MdiParent = this;
            formagregaridioma.Show();
        }






        #endregion

        private void pedidosYDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresoEgresoDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Entregas formEntregados = new Form_Entregas();
            formEntregados.MdiParent = this;
            formEntregados.Show();
        }

        private void configurarEquipoEspecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MarcarConfigurado formConfigurados = new Form_MarcarConfigurado();
            formConfigurados.MdiParent = this;
            formConfigurados.Show();
        }

        private void adondicionarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarComponentes formBuscarComp = new Form_BuscarComponentes();
            formBuscarComp.MdiParent = this;
            formBuscarComp.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Bitácora formBitacora = new Form_Bitácora();
            formBitacora.MdiParent = this;
            formBitacora.Show();
        }

        private void controlDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControl_de_Cambios formControlCambios = new FormControl_de_Cambios();
            formControlCambios.MdiParent = this;
            formControlCambios.Show();
        }

        private void backupYRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBackupRestore formBackup = new FormBackupRestore();
            formBackup.formpadre = this;
            formBackup.MdiParent = this;
            formBackup.Show();
        }

        private void digitosVerificadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDigitosVerificadores formDV = new FormDigitosVerificadores();
            formDV.MdiParent = this;
            formDV.Show();
        }

        private void aBMUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABM_Usuarios formUsuarios = new Form_ABM_Usuarios();
            formUsuarios.MdiParent = this;
            formUsuarios.Show();
        }

        private void ingresoEgresoDeComponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Retiros formRetiros = new Form_Retiros();
            formRetiros.MdiParent = this;
            formRetiros.Show();

        }

        private void pedirRetiroDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SolicitarDevolucion formdevs = new Form_SolicitarDevolucion();
            formdevs.MdiParent = this;
            formdevs.Show();
        }

        private void controlarDevoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ControlarDevolucion formControlar = new Form_ControlarDevolucion();
            formControlar.MdiParent = this;
            formControlar.Show();
        }



        public void LanzarAvisos(int idRol)
        {
            FormAvisos formAvisos = new FormAvisos(idRol);
            formAvisos.MdiParent = this;
            formAvisos.Show();

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Devoluciones formDevos = new Form_Devoluciones();
            formDevos.MdiParent = this;
            formDevos.FormParent = this;
            formDevos.Show();
        }

        private void verAvisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            LanzarAvisos(105);
        }

       

        private void ayudaEnLineaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sadaet-ayuda.netlify.app/");
        }
    }
}
