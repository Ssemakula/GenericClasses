using System.Security.Cryptography;
using System.Text;

namespace GenericClasses
{
    public static class SecureEncryptMe
    {
        // The encrypt and decrypt have to have either 16 or 32 characters
        public static string SecureEncrypt(string plainText, string encryptionKey = "ThisismySeedText")
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(encryptionKey);
                aesAlg.GenerateIV(); // Generate a random IV for each encryption

                ICryptoTransform encryptor = aesAlg.CreateEncryptor();

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    // Combine IV and ciphertext for storage
                    byte[] iv = aesAlg.IV;
                    byte[] encryptedBytes = msEncrypt.ToArray();
                    byte[] result = new byte[iv.Length + encryptedBytes.Length];
                    Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                    Buffer.BlockCopy(encryptedBytes, 0, result, iv.Length, encryptedBytes.Length);

                    return Convert.ToBase64String(result);
                }
            }
        }

        public static string SecureDecrypt(string cipherText, string encryptionKey = "ThisismySeedText")
        {
            byte[] combined = Convert.FromBase64String(cipherText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(encryptionKey);
                byte[] iv = new byte[aesAlg.BlockSize / 8];
                byte[] encryptedBytes = new byte[combined.Length - iv.Length];

                Buffer.BlockCopy(combined, 0, iv, 0, iv.Length);
                Buffer.BlockCopy(combined, iv.Length, encryptedBytes, 0, encryptedBytes.Length);

                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor();

                using (MemoryStream msDecrypt = new MemoryStream(encryptedBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
