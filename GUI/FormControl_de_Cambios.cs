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

namespace GUI
{
    public partial class FormControl_de_Cambios : Form
    {
        SolicitudBLL solicitudBLL = new SolicitudBLL();
        Solicitud solicitudTemporal = new Solicitud();
        List<Solicitud> solicitudes = new List<Solicitud>();


        public FormControl_de_Cambios()
        {
            InitializeComponent();
        }

        private void FormControl_de_Cambios_Load(object sender, EventArgs e)
        {
            ActualizarSolicitudes();
        }


        public void ActualizarSolicitudes()
        {
            solicitudes = solicitudBLL.ListarSolicitudes();
            dataGridViewSolicitudes.DataSource = solicitudes;
            dataGridViewSolicitudes.ReadOnly = true;
            dataGridViewSolicitudes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }





    }
}
