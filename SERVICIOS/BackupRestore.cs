using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public class BackupRestore
    {
        
        


        public string  Backup()
        {
            String s = DateTime.Now.ToString();
            s = s.Replace("/", "-").Replace(":", ".");
            s = "USE MASTER BACKUP DATABASE SADAET TO DISK = 'C:\\BackupRestoreSADAET\\" + s + ".bak'"; 
            return s;
        }

        public string Restore(String Directorio)
        {
         
            String S = "USE MASTER" + Environment.NewLine;
            S += "ALTER DATABASE SADAET SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + Environment.NewLine;
            S += "DROP DATABASE SADAET" + Environment.NewLine;
            S += "RESTORE DATABASE SADAET FROM DISK = '" + Directorio + "' WITH REPLACE;";
            return S;
       
        }



    }
}
