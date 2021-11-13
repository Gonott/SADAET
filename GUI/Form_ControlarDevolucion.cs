using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using SERVICIOS;

namespace GUI
{
    public partial class Form_ControlarDevolucion : Form
    {

        DevolucionBLL devBLL = new DevolucionBLL();
        Devolución estaDevolucion;
        List<Devolución> devoluciones = new List<Devolución>();
        Solicitud solicitudAsociada = new Solicitud();
        AvisoBLL avisobll = new AvisoBLL();


        public Form_ControlarDevolucion()
        {
            InitializeComponent();
        }

        private void Form_ControlarDevolucion_Load(object sender, EventArgs e)
        {
            devoluciones = devBLL.VerDevoluciones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {   estaDevolucion = new Devolución();
                estaDevolucion.NroOrden = int.Parse(textBox1.Text);
                foreach (Devolución dev in devoluciones)
                {
                    if (estaDevolucion.NroOrden == dev.NroOrden)
                    {
                        estaDevolucion = dev;
                    }
                }

                solicitudAsociada = devBLL.ObtenerSolicitudAsociada(estaDevolucion);
                VerSolicitud(solicitudAsociada);
              
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void VerSolicitud(Solicitud sol)
        {
            textBox2.Text = 
                sol.CodPedido + Environment.NewLine 
                + "A Nombre de: " + sol.empleado.Nombre + Environment.NewLine 
                + "Dirección: " + sol.empleado.Dirección + Environment.NewLine
                + "Fecha de Solicitud: " + sol.Fecha.ToString() + Environment.NewLine 
                + "Estado Actual: " + sol.estado.ToString();
        }

    

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Elemento elemento = new Elemento();
                elemento.CodInventario = int.Parse(textBox4.Text);
                switch (comboBox1.SelectedItem)
                {
                    case ("Buen Estado"):
                        elemento.condicion = Condición.BuenEstado;
                        break;
                    case ("Dañado"):
                        elemento.condicion = Condición.Dañado;
                        break;
                }
                foreach (Elemento item in solicitudAsociada.Perifericos)
                {
                    if (elemento.CodInventario == item.CodInventario)
                    {
                        elemento.Descripcion = item.Descripcion;
                        estaDevolucion.elementos.Add(elemento);
                        textBox3.Text += elemento.CodInventario.ToString() + " " + elemento.condicion.ToString() + "  " + elemento.Descripcion +  Environment.NewLine ;
                    }
                }

                if (elemento.CodInventario == solicitudAsociada.equipo.CodInventario)
                {
                    elemento.Descripcion = solicitudAsociada.equipo.Descripcion;
                    estaDevolucion.elementos.Add(elemento);
                    textBox3.Text += elemento.CodInventario.ToString() + " " + elemento.condicion.ToString() + "  " + elemento.Descripcion + Environment.NewLine;
                }
                
            }
            catch (Exception ex )
            {
                MessageBox.Show("Debe ingresar un codigo válido" + Environment.NewLine + ex.Message);
                
            }

            
        }

        private void btnControlar_Click(object sender, EventArgs e)
        {
            ControladorBLL controlador = new ControladorBLL(estaDevolucion, solicitudAsociada);
            if(controlador.ControlarCompletitud() == true)
            {
                MessageBox.Show("Elementos Completos");
            }
            else
            {
                MessageBox.Show("Elementos incompletos, faltan " + controlador.Faltantes.Count + " elementos.");
                avisobll.CrearAviso(106, "Elementos Incompletos en devolución", "Se necesita ir a buscar los elementos faltantes de la orden nro: " + estaDevolucion.NroOrden);

            }

            if (controlador.ControlarCondiciones() == true)
            {
                MessageBox.Show("Los elementos han sido recibidos como se entregaron");
            }
            else
            {
                MessageBox.Show(" Hay " + controlador.Dañados.Count + " elementos dañados, se está dando aviso a Contaduría para reclamar el seguro.");
                avisobll.CrearAviso(105, "Elementos dañados en devolución", "Se necesita reclamar la garantía en los elementos dañados de la orden nro: " + estaDevolucion.NroOrden);

            }
        }
    }
}
