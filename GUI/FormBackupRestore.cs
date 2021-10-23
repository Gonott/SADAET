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

namespace GUI
{
    public partial class FormBackupRestore : Form
    {

        string fileName = null;
        BackupRestore gestorBackupRestore = new BackupRestore();


        public FormBackupRestore()
        {
            InitializeComponent();
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

