using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SERVICIOS;




namespace BLL
{

    public class BackupRestoreBLL
    {

        BackupRestoreDAL mapper = new BackupRestoreDAL();
        BackupRestore backupRestore = new BackupRestore();

        public void Backup()

        {

            try
            {
                mapper.impactarBD(backupRestore.Backup());
            }
            catch (Exception)
            {

                throw;
            }

        }


        public void Restaurar(string fileName)
        {
            try
            {
                mapper.impactarBD(backupRestore.Restore(fileName));
            }
            catch (Exception)
            {

                throw;
            }
            
        }







    }
}
