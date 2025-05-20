using System.IO;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ThreatLocker.Framework.Extensions;

namespace ThreatLocker.Framework.Utils
{
    public class Crypto
    {
        public static string RSAEncrypt(string data)
        {
            var encoder = new UnicodeEncoding();
            var rsa = new RSACryptoServiceProvider(4096);
            rsa.FromXmlString(System.IO.File.ReadAllText("C:\\ThreatLocker\\Encryption\\publickey.xml"));
            var dataToEncrypt = encoder.GetBytes(data);
            var encryptedByteArray = rsa.Encrypt(dataToEncrypt, false).ToArray();
            var length = encryptedByteArray.Count();
            var item = 0;
            var sb = new StringBuilder();

            foreach (var x in encryptedByteArray)
            {
                item++;
                sb.Append(x);

                if (item < length)
                    sb.Append(',');
            }

            return sb.ToString();
        }

        public static string DecryptString(string encryptText, string keyString)
        {
            // Check arguments.
            if (string.IsNullOrEmpty(encryptText) || !encryptText.Contains(","))
                throw new ArgumentNullException("encryptText");
            if (string.IsNullOrEmpty(keyString))
                throw new ArgumentNullException("Key");

            string[] cipherAndIV = encryptText.Split(',');
            string stringIV = cipherAndIV[0];
            string stringCipher = cipherAndIV[1];
            byte[] cipherText = stringCipher.Base64StringToByte();
            byte[] iv = stringIV.Base64StringToByte();

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an AesCryptoServiceProvider object
            // with the specified key and IV.
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = keyString.Base64StringToByte();
                aesAlg.IV = iv;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (var msDecrypt = new MemoryStream(cipherText))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        public static string EncryptString(string sourceString, string keyString)
        {
            string returnEncryptString = string.Empty;
            byte[] encrypted = null;

            if (string.IsNullOrEmpty(sourceString))
            {
                return string.Empty;
            }

            // Create an AesCryptoServiceProvider object and load key and generate a new IV
            using (var aesCryptoServiceProvider = new AesCryptoServiceProvider())
            {
                if (!string.IsNullOrEmpty(keyString))
                {
                    aesCryptoServiceProvider.Key = keyString.Base64StringToByte();
                }
                else
                {
                    aesCryptoServiceProvider.GenerateKey();
                }

                aesCryptoServiceProvider.GenerateIV();

                // Create an encryptor to perform the stream transform.
                ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);

                // Create the streams used for encryption.
                var memoryStream = new MemoryStream();

                using (var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                {
                    using (var streamWriter = new StreamWriter(cryptoStream))
                    {
                        // Write all data to the stream.
                        streamWriter.Write(sourceString);
                    }
                }

                // Take it, covert it, prepend the IV and mash them together
                encrypted = memoryStream.ToArray();

                if (string.IsNullOrEmpty(keyString))
                {
                    returnEncryptString = encrypted.ByteToBase64String();
                }
                else
                {
                    returnEncryptString = aesCryptoServiceProvider.IV.ByteToBase64String() + "," + encrypted.ByteToBase64String();
                }
            }

            return returnEncryptString;
        }

        public static string GenerateSHA(string text)
        {
            var sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(text));

                foreach (Byte b in result)
                    sb.Append(b.ToString("x2"));
            }

            return sb.ToString().ToUpper();
        }
    }
}
