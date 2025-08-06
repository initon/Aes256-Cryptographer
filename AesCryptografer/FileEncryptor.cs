using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AesCryptografer
{
    class FileEncryptor
    {

        public static bool EncryptFile(string inputFile, string outputFile, string password)
        {
            byte[] salt = new byte[32];
            string hash_password = GetHashString(password);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(hash_password);

            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.KeySize = 256;
                    aesAlg.BlockSize = 128;
                    aesAlg.Padding = PaddingMode.PKCS7;

                    var key = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);

                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

                    using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                    using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                    {
                        fsOutput.Write(salt, 0, salt.Length);

                        using (CryptoStream cs = new CryptoStream(fsOutput, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            byte[] buffer = new byte[10485760]; // 10MB buffer
                            int bytesRead;
                            while ((bytesRead = fsInput.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cs.Write(buffer, 0, bytesRead);
                            }
                            cs.Dispose();
                        }
                        fsOutput.Dispose();
                        fsInput.Dispose();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в процессе шифрования: " + ex.Message);
                return false;
            }
        }

        public static bool DecryptFile(string inputFile, string outputFile, string password)
        {
            byte[] salt = new byte[32];
            string hash_password = GetHashString(password);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(hash_password);

            try
            {
                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                {
                    fsInput.Read(salt, 0, salt.Length);

                    using (Aes aesAlg = Aes.Create())
                    {
                        aesAlg.KeySize = 256;
                        aesAlg.BlockSize = 128;
                        aesAlg.Padding = PaddingMode.PKCS7;

                        var key = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);

                        aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                        aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);

                        using (CryptoStream cs = new CryptoStream(fsInput, aesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                        using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                        {
                            byte[] buffer = new byte[10485760]; // 10MB buffer
                            int bytesRead;
                            while ((bytesRead = cs.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                fsOutput.Write(buffer, 0, bytesRead);
                            }
                            fsOutput.Dispose();
                            cs.Dispose();
                        }
                    }
                    fsInput.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в процессе шифрования: " + ex.Message);
                return false;
            }
        }

        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("x2"));

            return sb.ToString();
        }

    }
}
