using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;




namespace SERVICIOS
{
    /// <summary>
    /// Esta clase es la que va a cumplir con A02 Serialización, recibe los objetos que se desean serializar y llama a un generador mail
   
    /// </summary>
    public class Serializador
    {

        public void Serializar(Exception ex)
        {
            ExepcionSerializada excep = new ExepcionSerializada(ex);

          
            //esto para tirarlo a un path Filestream
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ExcepcionNoControlada.xml" ;
            System.IO.FileStream file = System.IO.File.Create(path);

            //esto para memorystream
            //System.IO.MemoryStream stream = new System.IO.MemoryStream();
            //luego hay que mandarlo por mail de alguna manera

            //crear el Serializer
            XmlSerializer x = new XmlSerializer(excep.GetType());
            

            XmlTextWriter xmltextWriter = new XmlTextWriter(file, System.Text.Encoding.UTF8);
            x.Serialize(xmltextWriter, excep);
            xmltextWriter.Close();


            Process.Start("Outlook.exe","/a \"" + path + "\"");
        }





    }
}
