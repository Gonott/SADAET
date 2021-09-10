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
using BLL;
using SERVICIOS;
using System.Runtime.CompilerServices;

namespace GUI
{
    public partial class Form_Login : Form
    {

        public FormPrincipal FormParent;
        
        UsuarioBLL usubll = new UsuarioBLL();

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            Encriptador _criptografo = new Encriptador();
            usr.NombreUsuario = TxtUsuario.Text;
            usr.Contraseña = _criptografo.GetSHA256(TxtPassword.Text);
            


            try
            {
                if (usubll.ComprobarUsuario(usr) == true)
                {
                    MessageBox.Show("¡Bienvenido!");
                    FormParent.logInToolStripMenuItem.Enabled = false;
                    FormParent.logOutToolStripMenuItem.Enabled = true;
                    usubll.IniciarSesion();
                    //Aca se van a comprobar los permisos del usuario cuando se haga la Gestion de permisos
                    //Sesion.ObtenerInstancia.EsteUsuario.Autorizaciones = bllpermiso.LlenarUsuario(Sesion.Instancia.EsteUsuario);
                    //ComprobarPermisos(Sesion.ObtenerInstancia.EsteUsuario);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
