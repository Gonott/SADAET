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
using BE;
using SERVICIOS;
using SERVICIOS.ServiciosDAL;
using SERVICIOS.ObserverIdioma;

namespace GUI
{
    public partial class Form_ABM_Usuarios : Form, IIdiomaObserver
    {
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();
        UsuarioBLL usubll = new UsuarioBLL();
        Usuario usuarioTemporal = new Usuario();
        Encriptador criptografo = new Encriptador();



        public void Update(Idioma idioma)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null)
                {
                    if (int.Parse(control.Tag.ToString()) != 0)
                    {
                        control.Text = gestorDeIdiomas.Traducir(Sesion.ObtenerInstancia.EsteIdioma, int.Parse(control.Tag.ToString()));
                    }
                }
            }
        }

        public Form_ABM_Usuarios()
        {
            InitializeComponent();
        }

        private void Form_ABM_Usuarios_Load(object sender, EventArgs e)
        {
            LlenarListBoxUsuarios();
            Subject.AgregarObserver(this);
        }



        private void LlenarListBoxUsuarios()
        {
            ListBoxUsuarios.Items.Clear();
            ListBoxUsuarios.DataSource = usubll.ListarUsuarios();
            ListBoxUsuarios.DisplayMember = "NombreUsuario";

        }


        private void ListBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuarioTemporal = (Usuario)ListBoxUsuarios.SelectedItem;
            textBoxNombre.Text = usuarioTemporal.NombreUsuario;
            textBoxPwd.Text = usuarioTemporal.Contraseña;
        }

        private void AltaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioTemporal.NombreUsuario = textBoxNombre.Text;
                usuarioTemporal.Contraseña = criptografo.GetSHA256(textBoxPwd.Text);
                usubll.Alta(usuarioTemporal);
                textBoxNombre.Text = "";
                textBoxPwd.Text = "";
                LlenarListBoxUsuarios();

                MessageBox.Show("Usuario Agregado");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void BajaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                usubll.Baja(usuarioTemporal);
                textBoxNombre.Text = "";
                textBoxPwd.Text = "";
                LlenarListBoxUsuarios();

                MessageBox.Show("Usuario eliminado");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message); 
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioTemporal.NombreUsuario = textBoxNombre.Text;
                usuarioTemporal.Contraseña = criptografo.GetSHA256(textBoxPwd.Text);
                usubll.Modificar(usuarioTemporal);
                textBoxNombre.Text = "";
                textBoxPwd.Text = "";
                LlenarListBoxUsuarios();
                MessageBox.Show("Listo, se ha modificado el usuario");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
