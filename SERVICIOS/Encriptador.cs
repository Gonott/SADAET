using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Security.Cryptography;
using System.IO;

namespace SERVICIOS
{
    public class Encriptador
    {
        
        

        #region HASH SHA256
        public string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        #endregion



        #region Encriptado y Desencriptado de Datos sensibles
        

        //Funcion creadora del Algoritmo Rijndael con seteo de clave

        private RijndaelManaged ObtenerAlgoritmoRijndael()
        {
            RijndaelManaged rijndael = new RijndaelManaged();
            rijndael.KeySize = 256;
            rijndael.BlockSize = 256; //usar 128 para compatibilidad con AES
            rijndael.Padding = PaddingMode.ISO10126;
            rijndael.Mode = CipherMode.CBC;
            rijndael.Key = UTF8Encoding.UTF8.GetBytes("qwertyuiopasdfgh");
            //La clave tiene que ser de 16 caracteres, ya que estamos tratando con 256 bits.
            return rijndael;
        }


        //Funcion Encriptadora
        public string EncriptarDatoSensible(string dato)
        {
            RijndaelManaged criptografo = ObtenerAlgoritmoRijndael();
            ICryptoTransform t = criptografo.CreateEncryptor();

            byte[] textoEnBytes = Encoding.UTF8.GetBytes(dato);
            byte[] result = t.TransformFinalBlock(textoEnBytes, 0, textoEnBytes.Length);
            return Convert.ToBase64String(result);
        }


         // Funcion Desencriptadora
        public string DesEncriptarDatoSensible(string txtCifrado)
        {
            RijndaelManaged criptografo = ObtenerAlgoritmoRijndael();
            ICryptoTransform t = criptografo.CreateDecryptor();
            byte[] cipherTextBytes = Convert.FromBase64String(txtCifrado);
            byte[] bytestextoplano = new byte[cipherTextBytes.Length];
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, t, CryptoStreamMode.Read);
            int decryptedByteCount = cryptoStream.Read(bytestextoplano, 0, bytestextoplano.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(bytestextoplano, 0, decryptedByteCount);

        }


        #endregion


    }
}
