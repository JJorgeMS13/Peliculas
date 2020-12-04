using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PatronMvc.Models.Dao
{
   public static class SeguridadSistema
   {


        //Metodo para Encriptar una cadena
        public static byte[] EncriptarStringToBytes_Aes(string cadena, byte [] key, byte[] IV)
        {
            if (cadena == null || cadena.Length <= 0)
                throw new ArgumentException("Cadena");
            if (key == null || key.Length <= 0)
                throw new ArgumentException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentException("Key");
            byte[] encriptado;
            
            //Crea un objeto Aes con la especificacion de key y IV
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                //Crea un cifrador para realizar la transformación de la secuencia.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key,aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt,encryptor,CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Escribe todos los datos a Stream.
                            swEncrypt.Write(cadena);
                        }
                        encriptado = msEncrypt.ToArray();
                    }
                }
            }
            return encriptado;
        }


        //Metodo para Desencriptar una cadena con  Aes

        public static string DesencriptarStringDeByte_Aes( byte [] textEncriptado, byte[] Key, byte[] IV)
        {
            //Checar parametros
            if (textEncriptado == null || textEncriptado.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            //Se crea para guardar el texto desencriptado
            string cadena = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                //Cree un descifrado para realizar la transformación de la secuencia.
                ICryptoTransform descriptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDescriptor = new MemoryStream(textEncriptado))
                {
                    using (CryptoStream csDescriptor = new CryptoStream(msDescriptor,descriptor,CryptoStreamMode.Read))
                    {
                        using (StreamReader srDescriptor = new StreamReader(csDescriptor))
                        {
                            cadena = srDescriptor.ReadToEnd();
                        }
                    }
                }
            }
            return cadena;
        }
   }
}
