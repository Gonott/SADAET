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
using SERVICIOS.ObserverIdioma;

namespace GUI
{
    public partial class ABM_Autorizaciones : Form,IIdiomaObserver

    {
        public ABM_Autorizaciones()
        {
            InitializeComponent();
        }

        Permiso permisotemporal = new Permiso();
        Rol roltemporal = new Rol();
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();


        PermisoBLL permisooperador = new PermisoBLL();
        RolBLL Roloperador = new RolBLL();

        private void ABM_Autorizaciones_Load(object sender, EventArgs e)
        {
            Subject.AgregarObserver(this);
           ActualizarPermisos();
            ActualizarRoles();
           // ComprobarPermisos();
        }

        public void ComprobarPermisos()
        {
            UsuarioBLL usubll = new UsuarioBLL();
            foreach (Control boton in this.Controls)
            {
                if (boton is Button)
                {
                    if (boton.Tag != null)
                    {
                        if (int.Parse(boton.Tag.ToString()) != 0)
                        {

                            boton.Enabled = false;
                            boton.Enabled = usubll.ComprobarPermiso(int.Parse(boton.Tag.ToString()));
                        }
                    }
                }
                else
                {

                }

            }
        }

        public void ActualizarRoles()
        {
            dataGridViewRoles.DataSource = null;
            dataGridViewRoles.DataSource = Roloperador.ListarTodos();
        }

        public void ActualizarPermisos()
        {
            dataGridViewPermisos.DataSource = null;
            dataGridViewPermisos.DataSource = permisooperador.ListarTodos();

        }

        private void dataGridViewRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewRoles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewRoles.Rows[e.RowIndex].Selected = true;
                    roltemporal.Id = int.Parse(dataGridViewRoles.CurrentRow.Cells["Id"].Value.ToString());
                    textBoxNombreRol.Text =  roltemporal.Nombre = dataGridViewRoles.CurrentRow.Cells["Nombre"].Value.ToString();
                    textBoxDescRol.Text =  roltemporal.Descripcion  = dataGridViewRoles.CurrentRow.Cells["Descripcion"].Value.ToString();

                }

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }

        private void dataGridViewPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewPermisos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewPermisos.Rows[e.RowIndex].Selected = true;
                    textBoxIdPermiso.Text = dataGridViewPermisos.CurrentRow.Cells["Id"].Value.ToString();
                    textBoxNombrePermiso.Text = dataGridViewPermisos.CurrentRow.Cells["Nombre"].Value.ToString();
                    textBoxDescPermiso.Text = dataGridViewPermisos.CurrentRow.Cells["Descripcion"].Value.ToString();
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe hacer click dentro de las casillas");
            }
        }


        #region ABM Roles

        public void llenarrol()
        {

            roltemporal.Id = int.Parse(textBoxIdRol.Text);
            roltemporal.Nombre = textBoxNombreRol.Text;
            roltemporal.Descripcion = textBoxDescRol.Text;

        }

        private void AltaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                llenarrol();
                Roloperador.Alta(roltemporal);
                ActualizarRoles();
                
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
                Roloperador.Baja(roltemporal);
                ActualizarRoles();
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
                llenarrol();
                Roloperador.modificar(roltemporal);
                ActualizarRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        #endregion


        #region ABM Permisos


        public void llenarpermiso()
        {
            permisotemporal.Id = int.Parse(textBoxIdPermiso.Text);
            permisotemporal.Nombre = textBoxNombrePermiso.Text;
            permisotemporal.Descripcion = textBoxDescPermiso.Text;
        }
      

        private void AltaPermBtn_Click(object sender, EventArgs e)
        {
            try
            {
                llenarpermiso();
                permisooperador.Alta(permisotemporal);
                ActualizarPermisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BajaPermBtn_Click(object sender, EventArgs e)
        {
            try
            {
                llenarpermiso();
                permisooperador.Baja(permisotemporal);
                ActualizarPermisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ModifPermBtn_Click(object sender, EventArgs e)
        {
            try
            {
                llenarpermiso();
                permisooperador.Modificar(permisotemporal);
                ActualizarPermisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        #endregion

        #region Gestion de Idiomas

        public void Update(Idioma idioma)
        {
            foreach (Control control in this.Controls)
            {
                if(control.Tag != null)
                {
                    if(int.Parse(control.Tag.ToString()) != 0 )
                    {
                        control.Text = gestorDeIdiomas.Traducir(Sesion.ObtenerInstancia.EsteIdioma, int.Parse(control.Tag.ToString()));
                    }
                }
            }
        }

        #endregion


    }
}