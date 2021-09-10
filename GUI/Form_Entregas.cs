using BE;
using BLL;
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
using SERVICIOS.ObserverIdioma;

namespace GUI
{
    public partial class Form_Entregas : Form, IIdiomaObserver
    {
        SolicitudBLL bllSolicitud = new SolicitudBLL();
        Solicitud solicitudTemporal = new Solicitud();
        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();





        public Form_Entregas()
        {
            InitializeComponent();
        }

        private void Form_Entregas_Load(object sender, EventArgs e)
        {
            RefrescarSolicitudes();
            Subject.AgregarObserver(this);
        }


        public void RefrescarSolicitudes()
        {
            try
            {
                dataGridView1.DataSource = bllSolicitud.ListarPorEstado(Estado.CorreoInterno);
                dataGridView2.DataSource = bllSolicitud.ListarPorEstado(Estado.Entregado);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.ReadOnly = true;
                dataGridView2.ReadOnly = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bllSolicitud.CambiarEstado(solicitudTemporal, Estado.Entregado);
                RefrescarSolicitudes();
                
            }
            catch (Exception)
            {

                throw;
            }


            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    if (solicitudTemporal == null)
                    {
                        solicitudTemporal = new Solicitud();
                    }
                    solicitudTemporal.CodPedido = int.Parse(dataGridView1.CurrentRow.Cells["CodPedido"].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Debe hacer click en alguna solicitud.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
