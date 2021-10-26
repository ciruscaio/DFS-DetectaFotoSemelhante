using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.IO.Compression;

namespace Util
{
    /// <summary>
    /// Classe utilitária com o objetivo de Criptografar dados.
    /// </summary>
    public class Criptografia
    {
        public Criptografia()
        { }

        /// <summary>
        /// Decriptografa uma string criptografada com o algoritmo Base64
        /// </summary>
        /// <param name="valor">string criptografado</param>
        /// <returns>string decriptografada (texto plen)</returns>
        public static string Base64_Decriptar(string valor)
        {
            return Convert.ToBase64String(new System.Text.ASCIIEncoding().GetBytes(valor));
        }

        /// <summary>
        /// Criptografa uma string utilizando o algoritmo Base64
        /// </summary>
        /// <param name="valor">string decriptografada (texto plen)</param>
        /// <returns>string criptografado</returns>
        public static string Base64_Encriptar(string valor)
        {
            return new System.Text.ASCIIEncoding().GetString(Convert.FromBase64String(valor));
        }

        /// <summary>
        /// Criptografa uma string utilizando o algoritmo MD5
        /// </summary>
        /// <param name="Valor">string decriptografada (texto plen)</param>
        /// <returns>string criptografado</returns>
        /// <remarks>MD5 não pode ser descriptografado</remarks>
        public static string criptoMD5(string valor)
        {

            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(valor);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public static string Compacta(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            MemoryStream ms = new MemoryStream();
            using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0;
            MemoryStream outStream = new MemoryStream();

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            byte[] gzBuffer = new byte[compressed.Length + 4];
            System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return Convert.ToBase64String(gzBuffer);
        }

        public static string Descompacta(string compressedText)
        {
            byte[] gzBuffer = Convert.FromBase64String(compressedText);
            using (MemoryStream ms = new MemoryStream())
            {
                int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

                byte[] buffer = new byte[msgLength];

                ms.Position = 0;
                using (GZipStream zip = new GZipStream(ms, CompressionMode.Decompress))
                {
                    zip.Read(buffer, 0, buffer.Length);
                }
                return Encoding.UTF8.GetString(buffer);
            }
        }


        const string EXP_Senha = "E!09#x*&aTe$";

        public static string EXP_Encriptar(string Valor)
        {

            byte[] Results;

            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();

            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(EXP_Senha));

            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            TDESAlgorithm.Key = TDESKey;

            TDESAlgorithm.Mode = CipherMode.ECB;

            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            byte[] DataToEncrypt = UTF8.GetBytes(Valor);

            try
            {

                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();

                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);

            }

            finally
            {

                TDESAlgorithm.Clear();

                HashProvider.Clear();

            }

            return Convert.ToBase64String(Results);

        }

        public static string EXP_Decriptar(string Valor)
        {

            byte[] Results;

            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();

            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(EXP_Senha));

            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            TDESAlgorithm.Key = TDESKey;

            TDESAlgorithm.Mode = CipherMode.ECB;

            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            byte[] DataToDecrypt = Convert.FromBase64String(Valor);

            try
            {

                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();

                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);

            }

            finally
            {

                TDESAlgorithm.Clear();

                HashProvider.Clear();

            }

            return UTF8.GetString(Results);

        }
    }
}
