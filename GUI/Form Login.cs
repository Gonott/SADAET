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
using SERVICIOS.DigitosVerificador;

namespace GUI
{
    public partial class Form_Login : Form
    {

        public FormPrincipal FormParent;

        UsuarioBLL usubll = new UsuarioBLL();
        DigitosVerificadores gestorDVs = new DigitosVerificadores();

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
            Sesion.ObtenerInstancia.EsteUsuario = usr;
            AvisoBLL avisobll = new AvisoBLL();


            try
            {
                if (usubll.ComprobarUsuario(Sesion.ObtenerInstancia.EsteUsuario) == true)
                {
                    MessageBox.Show("¡Bienvenido!");


                    if (DigitosVerificadores.ValidarBBDD() == true)
                    {
                        ComprobarPermisos();
                    }
                    else
                    {
                        if (!usubll.EncontrarRol(101))
                        {
                            MessageBox.Show("No te puedo dejar entrar al sistema", "Lo Siento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        avisobll.CrearAviso(101, "DB Corrupta", DigitosVerificadores.RegistrosCorruptos());
                    }

                    //si es admin, dejar entrar al sistema pero ir a buscar la tabla Avisos a ver que onda. o buchonear.
                    if (usubll.EncontrarRol(101)) //101 corresponde a ID de Administrador
                    {
                        ComprobarPermisos();
                        if (avisobll.VerMisAvisos(101).Count >= 1)
                        {
                            MessageBox.Show("La base de datos está corrupta.", "BD Corrupta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.FormParent.LanzarAvisos(101);
                        }
                    }   
                    FormParent.UsarioToolStripMenuItem.Enabled = true;
                    FormParent.LogInToolStripMenu.Enabled = false;
                    FormParent.salirDelSistemaToolStripMenuItem1.Enabled = true;
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



        public void ComprobarPermisos()
        {
            foreach (ToolStripMenuItem item in FormParent.menuStrip1.Items)
            {
                item.Enabled = false;
                item.Enabled = usubll.ComprobarPermiso(int.Parse(item.Tag.ToString()));
                if (item.DropDown.Items.Count > 0)
                {
                    foreach (ToolStripMenuItem subitem in item.DropDown.Items)
                    {
                        subitem.Enabled = false;
                        subitem.Enabled = usubll.ComprobarPermiso(int.Parse(subitem.Tag.ToString()));
                    }
                }
            }
            
        }






    }
}
