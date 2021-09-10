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
using SERVICIOS.PerfilesComposite;
using SERVICIOS;
using System.Xml;
using SERVICIOS.ObserverIdioma;

namespace GUI
{
    public partial class FormEdicionDeRoles : Form, IIdiomaObserver
    {
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();

        public FormEdicionDeRoles()
        {
            InitializeComponent();
        }

        RolBLL bllrol = new RolBLL();
        PermisoBLL bllpermiso = new PermisoBLL();

        Rol roltemp = new Rol();
        Permiso permisotemp = new Permiso();


        private void FormEdicionDeRoles_Load(object sender, EventArgs e)
        {
            comboBoxRoles.Items.Clear();
            comboBoxRoles.DataSource = bllrol.ListarTodos();
            comboBoxRoles.DisplayMember = "Nombre";
            //ComprobarPermisos();
            ActualizarGrillaPermisos();
            ActualizarListadoPermisos();

            Subject.AgregarObserver(this);

        }

        public void ComprobarPermisos()
        {
            UsuarioBLL usubll = new UsuarioBLL();
            foreach (Control boton in this.Controls)
            {
                if (boton is Button)
                {
                    boton.Enabled = false;
                    boton.Enabled = usubll.ComprobarPermiso(int.Parse(boton.Tag.ToString()));
                }

            }
        }


        private void ActualizarListadoPermisos()
        {
            try
            {
                ListBoxPermisosRol.DataSource = null;
                ListBoxPermisosRol.DataSource = bllpermiso.ListarPermisosPorRol(roltemp);
                ListBoxPermisosRol.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void ActualizarGrillaPermisos()
        {
            DataGridViewPermisos.DataSource = null;
            DataGridViewPermisos.DataSource = bllpermiso.ListarTodos();
        }

        private void DataGridViewPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridViewPermisos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewPermisos.Rows[e.RowIndex].Selected = true;
                    if (permisotemp == null)
                    {
                        permisotemp = new Permiso();
                    }
                    permisotemp.Id = int.Parse(DataGridViewPermisos.CurrentRow.Cells["Id"].Value.ToString());
                    permisotemp.Nombre = DataGridViewPermisos.CurrentRow.Cells["Nombre"].Value.ToString();

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bllpermiso.AgregarPermisoRol(permisotemp, roltemp);
                roltemp.Autorizaciones.Add(permisotemp);

                ActualizarListadoPermisos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                bllpermiso.DesasignarPermisoRol(permisotemp, roltemp);
                roltemp.Autorizaciones.Remove(permisotemp);

                ActualizarListadoPermisos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            roltemp = (Rol)comboBoxRoles.SelectedItem;
            ActualizarListadoPermisos();
        }

        private void ListBoxPermisosRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            permisotemp = (Permiso)ListBoxPermisosRol.SelectedValue;
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
    }
}
