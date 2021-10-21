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

namespace GUI
{
    public partial class Form_ABM_Usuarios : Form
    {
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();
        UsuarioBLL usubll = new UsuarioBLL();
        Usuario usuarioTemporal = new Usuario();
        Encriptador criptografo = new Encriptador();



        public Form_ABM_Usuarios()
        {
            InitializeComponent();
        }

        private void Form_ABM_Usuarios_Load(object sender, EventArgs e)
        {
            LlenarListBoxUsuarios();
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
