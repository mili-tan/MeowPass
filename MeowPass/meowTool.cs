using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MeowPass
{
    class MeowTool
    {
        private static byte[] Iv = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        public static string MyMD5Crypto(string str)
        {
            byte[] md5Byte = new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(str.Trim()));
            return BitConverter.ToString(md5Byte).Replace("-", "");
        }
        public static string MySHACrypto(string str)
        {
            byte[] shaByte = new SHA1CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(str.Trim()));
            return BitConverter.ToString(shaByte).Replace("-", "");
        }
        public static string MyDESCrypto(string str, string key)
        {
            string encryptKeyall = Convert.ToString(key);
            if (encryptKeyall.Length < 9)
            {
                while (!(encryptKeyall.Length < 9))
                {
                    encryptKeyall += encryptKeyall;
                }
            }
            string encryptKey = encryptKeyall.Substring(0, 8);
            byte[] strs = Encoding.Unicode.GetBytes(str);
            byte[] keys = Encoding.UTF8.GetBytes(encryptKey); ;

            DESCryptoServiceProvider desC = new DESCryptoServiceProvider();
            MemoryStream mStream = new MemoryStream();

            ICryptoTransform transForm = desC.CreateEncryptor(keys, Iv);
            CryptoStream cStream = new CryptoStream(mStream, transForm, CryptoStreamMode.Write);
            cStream.Write(strs, 0, strs.Length);
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.ToArray());
        }
        public static string MyTripleDESCrypto(string str, string key)
        {
            string encryptKeyall = Convert.ToString(key);
            if (encryptKeyall.Length < 17)
            {
                while (!(encryptKeyall.Length < 17))
                {
                    encryptKeyall += encryptKeyall;
                }
            }
            string encryptKey = encryptKeyall.Substring(0, 16);
            byte[] strs = Encoding.Unicode.GetBytes(str);
            byte[] keys = Encoding.ASCII.GetBytes(encryptKey); ;

            TripleDESCryptoServiceProvider tdesC = new TripleDESCryptoServiceProvider();
            tdesC.Key = keys;//key的长度必须为16位或24位，否则报错“指定键的大小对于此算法无效。”
            tdesC.Mode = CipherMode.ECB;
            ICryptoTransform cryp = tdesC.CreateEncryptor();

            return Convert.ToBase64String(cryp.TransformFinalBlock(strs, 0, strs.Length));
        }
    }
}
