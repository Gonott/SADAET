using BE;
using BLL;
using SERVICIOS;
using SERVICIOS.ObserverIdioma;
using SERVICIOS.PerfilesComposite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GUI
{
    public partial class FormPerfilesDeUsuario : Form, IIdiomaObserver
    {
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();
        UsuarioBLL usubll = new UsuarioBLL();
        PermisoBLL permisobll = new PermisoBLL();
        RolBLL rolbll = new RolBLL();
        
        Usuario usuarioTemporal = new Usuario();
        //Rol rolTemporal = new Rol();
        //Permiso permisoTemporal = new Permiso();
        Autorizacion autorizacionTemporal;


        public FormPerfilesDeUsuario()
        {
            InitializeComponent();
        }

        private void FormPerfilesDeUsuario_Load(object sender, EventArgs e)
        {
            //ComprobarPermisos();
            LlenarListBoxUsuarios();
            LlenarListBoxPermisos();
            LlenarListBoxRoles();
            LlenarTreeView(Sesion.ObtenerInstancia.EsteUsuario);
            Subject.AgregarObserver(this);

        }


        


        public void ComprobarPermisos()
        {
            foreach (Control boton in this.Controls)
            {
                if (boton is Button)
                {
                     boton.Enabled = false;
                     boton.Enabled = usubll.ComprobarPermiso(int.Parse(boton.Tag.ToString()));
                }
               
            }
        }

      


        private void LlenarTreeView(Usuario usu)
        {
            
            TreeViewAutorizaciones.Nodes.Clear();
            
            foreach  (Autorizacion aut in usu.Autorizaciones)
            {
                funcionRecursiva(aut);
            }
            TreeViewAutorizaciones.ExpandAll();

        }

        private void funcionRecursiva(Autorizacion aut,TreeNode NodoPadre = null, TreeNode EsteNodo = null)
        {
            if (aut.GetType() == typeof(Permiso))
            { //si entra aca es por que es permiso
                if (NodoPadre == null)
                {//si entra aca es por que es permiso suelto
                    EsteNodo = new TreeNode();
                    EsteNodo.Tag = aut;
                    EsteNodo.Text = aut.Nombre;
                    EsteNodo.Name = aut.Nombre; //si pincha aca es por que debo sacar el null de la firma
                    TreeViewAutorizaciones.Nodes.Add(EsteNodo);
                    
                }
                else
                {//si entra aca es por que es permiso que pertenece a un rol
                    EsteNodo = new TreeNode();
                    EsteNodo.Tag = aut;
                    EsteNodo.Text = aut.Nombre;
                    EsteNodo.Name = aut.Nombre;
                    NodoPadre.Nodes.Add(EsteNodo);
                    
                }  
            }
            else
            { //si entra aca es por que se trata de un Rol
                EsteNodo = new TreeNode();
                EsteNodo.Tag = aut;
                EsteNodo.Name = aut.Nombre;
                EsteNodo.Text = aut.Nombre;
                TreeViewAutorizaciones.Nodes.Add(EsteNodo);
                foreach (Autorizacion permi in aut.GetChilds())
                {
                    funcionRecursiva(permi,EsteNodo);
                }
                
            }

        }


        private void LlenarListBoxUsuarios()
        {
            ListBoxUsuarios.Items.Clear();
            ListBoxUsuarios.DataSource = usubll.ListarUsuarios();
            ListBoxUsuarios.DisplayMember = "NombreUsuario";

        }

        private void LlenarListBoxRoles()
        {
            listBoxRoles.Items.Clear();
            listBoxRoles.DataSource = rolbll.ListarTodos();
            listBoxRoles.DisplayMember = "Nombre";
        }

      

        private void ActualizarUsuario() 
        {
            usuarioTemporal.Autorizaciones.Clear();
            usuarioTemporal = (Usuario)ListBoxUsuarios.SelectedItem;
            usubll.CargarPerfil(usuarioTemporal);
            LlenarTreeView(usuarioTemporal);
  
        }


        private void LlenarListBoxPermisos()
        {
            listBoxPermisos.Items.Clear();
            listBoxPermisos.DataSource = permisobll.ListarTodos();
            listBoxPermisos.DisplayMember = "Nombre";
        }


        #region Eventos

        private void listBoxPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            autorizacionTemporal = (Permiso)listBoxPermisos.SelectedItem;
            DescripcionLbl_.Text = autorizacionTemporal.Descripcion;
            
        }

        private void ListBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarUsuario(); //podria simplificar esto mas adelante integrando ActualizarUSuario();

        }

        private void listBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            autorizacionTemporal = (Rol)listBoxRoles.SelectedItem;
            DescripcionLbl_.Text = autorizacionTemporal.Descripcion;
        }



       

        private void TreeViewAutorizaciones_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag.GetType() == typeof(Permiso))
            {
                autorizacionTemporal = (Permiso)e.Node.Tag;
                
            }
            if (e.Node.Tag.GetType() == typeof(Rol))
            {
                autorizacionTemporal = (Rol)e.Node.Tag;
            }

        }

        #endregion

        #region Acciones

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (autorizacionTemporal.GetType() == typeof(Permiso))
                {
                    permisobll.AgregarPermisoUsuario((Permiso)autorizacionTemporal, usuarioTemporal);
                    LlenarTreeView(usuarioTemporal);
                    MessageBox.Show("Listo, se agregó el permiso " + autorizacionTemporal.Nombre + " a " + usuarioTemporal.NombreUsuario);
                }
                if (autorizacionTemporal.GetType() == typeof(Rol))
                {
                    rolbll.AgregarRolAUsuario((Rol)autorizacionTemporal, usuarioTemporal);
                    LlenarTreeView(usuarioTemporal);
                    MessageBox.Show("Listo, se agregó el Rol " + autorizacionTemporal.Nombre + " a " + usuarioTemporal.NombreUsuario);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es posible que el usuario ya tenga esa autorización" + ex.Message);
            }
        }


        #endregion

        private void QuitarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (autorizacionTemporal.GetType() == typeof(Permiso))
                {
                    permisobll.DesasignarPermisoUsuario((Permiso)autorizacionTemporal, usuarioTemporal);
                    LlenarTreeView(usuarioTemporal);
                    MessageBox.Show("Listo, se removió el permiso " + autorizacionTemporal.Nombre + " de " + usuarioTemporal.NombreUsuario);
                }
                if (autorizacionTemporal.GetType() == typeof(Rol))
                {
                    rolbll.DesasignarRolDeUsuario((Rol)autorizacionTemporal, usuarioTemporal);
                    LlenarTreeView(usuarioTemporal);
                    MessageBox.Show("Listo, se removió el Rol " + autorizacionTemporal.Nombre + " de " + usuarioTemporal.NombreUsuario);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es posible que el usuario ya no tenga esa autorización" + ex.Message);
            }
        }

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

        private void DescripcionLbl__Click(object sender, EventArgs e)
        {

        }
    }
    
}
