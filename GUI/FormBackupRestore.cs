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
using SERVICIOS.ServiciosDAL;
using SERVICIOS.ObserverIdioma;


namespace GUI
{
    public partial class FormBackupRestore : Form, IIdiomaObserver
    {

        string fileName = null;
        BackupRestore gestorBackupRestore = new BackupRestore();


        public FormBackupRestore()
        {
            InitializeComponent();
        }


        GestorIdiomasBLL gestorDeIdiomas = new GestorIdiomasBLL();


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



        private void FormBackupRestore_Load(object sender, EventArgs e)
        {

        }

        private void backupBtn_Click(object sender, EventArgs e)
        {

            try
            {
                gestorBackupRestore.Backup();
                MessageBox.Show("**Backup exitoso**");
            }
            catch (Exception ex)
            {
                MessageBox.Show("**Fallo el intento de Backup**" +Environment.NewLine + " Excepción: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                String fileName = openFileDialog1.FileName;
                String extension = System.IO.Path.GetExtension(fileName);
                if (".bak".Equals(extension))
                {
                    try
                    {
                        gestorBackupRestore.Restore(openFileDialog1.FileName);
                        MessageBox.Show("**Restore exitoso**");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("**Fallo el intento de Restauración**" + Environment.NewLine + " Excepción: " + ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("**Seleccione un archivo .BAK**");
                }
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\BackupRestoreSADAET\\";
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName; // capturo el string de directorio + filename
            textBox1.Text = fileName;
        }
    }
}

