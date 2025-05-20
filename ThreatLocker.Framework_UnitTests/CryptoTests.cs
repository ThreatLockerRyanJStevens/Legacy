using System.Security.Cryptography;
using ThreatLocker.Framework;
using ThreatLocker.Framework.Utils;

namespace ThreatLocker.Framework_UnitTests
{
    public class CryptoTests : BaseTest
    {
        public const string Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
       

        [Theory(DisplayName ="RSAEncrypt: Returns valid RSA hash.", Skip = "Unable to test")]
        [InlineData(Data, @"C:\ThreatLocker\Encryption\publickey.xml","")]
        public void RSAEncrypt_ReturnValidRsaHash(string text,string keyFile, string expected)
        {

            //var result = Crypto.RSAEncrypt(text,keyFile);
            //Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "RSAEncrypt: Throw Exception - No key provided", Skip = "Unable to test")]
        public void RSAEncrypt_ThrowExceptionNullKey()
        {
            //Assert.Throws<ArgumentNullException>(() => Crypto.RSAEncrypt(Data, null));
        }

        [Fact(DisplayName = "RSAEncrypt: Throw Exception - No data", Skip = "Unable to test")]
        public void RSAEncrypt_ThrowExceptionNoData()
        {
            //Assert.Throws<ArgumentNullException>(() => Crypto.RSAEncrypt(null, @"<x><key>badkey</key></x>"));
        }


        [Fact(DisplayName = "RSAEncrypt: Throw Exception - Bad RSA Key", Skip ="Unable to test")]
        public void RSAEncrypt_ThrowExceptionBadRsaKey()
        {
            //Assert.Throws<CryptographicException>(() => Crypto.RSAEncrypt(Data, @"<x><key>badkey</key></x>"));
        }

        [Theory(DisplayName = "DecryptString: Returns valid decrypted string.")]
        [InlineData(@"xcwPgZzIgofwlG6joy+0HA==,UU1Kuvgc86/k81jBOUuj+JPzJwhQ5ZbevM4zBtTErM780Nmkf/J2qiyOAD9X+H+tzjvn4+55HtmfaCAVufs2aQavdchisX74iKsDPnMSGLNFJdYHx+U/g6w0U86APvlJOspFoxbvUaBnbqRX12bCu0r3Xj8ffHGs9a1UE/BUtietlwG9rPUK/1UVq12DV2g6tdGICVC5cgLPUkCRmDPzc5cMGgTN1S9jA1XmFDd3WlD+Xgjf0KIZxMyg4deQKrBx8lUCmuSgpbgADwYl0YqEsJHruS9B51ovYK82VcM/RuklgM97c4d3REzELgsvbSyMXu8xJt8vsyArTTL0oId3jeRJdA+wx5Mgrj1HLXA7Aykk0NrzF6GFqyZ3D5FqlPM2ccU8vQoS0u2/nDcQr+X0S/0d6XwM3O0oRLaro7jjQpqEUhoo0Y76YIXN1Pi2zMmVTUzxnajO7L+VwS6ATxT0PmUyGw8USLJ6AV42h5DQydfxZ9ho8KX/w1U2WK8ewtKKSJaK1gbc2LtIt9gjPMzyhcl2L3Ovk6BuK85GSsWr7YZb3/jRKCSYwPfF4RTFxODv0J+O8nsX8kzcPGrGXar65Q==", "45qUIx2TVoj7wtwlXyryYJTYfW+ysiPM1jwERHUmX0Y=", Data)]
        public void DecryptString_ReturnValidDecryptedString(string text,string key, string expected)
        {
            var result = Crypto.DecryptString(text, key);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "EncryptString: Returns valid encrypted string.")]
        [InlineData(Data, "45qUIx2TVoj7wtwlXyryYJTYfW+ysiPM1jwERHUmX0Y=")]
        //[InlineData(Data, null, "")] // supported by method, but unpredictable result.
        public void EncryptString_ReturnValidEncryptedString(string source, string key)
        {
            var encrypted = Crypto.EncryptString(source, key);
            var decrypted = Crypto.DecryptString(encrypted, key);
          
            // We're decrypting the result to do the comparison due to the random nature of encryption.
            Assert.Equal(source, decrypted);
        }

        /// <summary>
        /// Key was not a Base64 encoded string.
        /// </summary>
        [Fact(DisplayName = "EncryptString: Throws Exception invalid key format.")]
        public void EncryptString_ThrowInvalidKeyFormat()
        {
            Assert.Throws<FormatException>(() => Crypto.EncryptString(Data, "threatlockerkey"));
        }

        [Fact(DisplayName = "EncryptString: Throws Exception invalid key size.")]
        public void EncryptString_ThrowInvalidKeySize()
        {
            Assert.Throws<CryptographicException>(() => Crypto.EncryptString(Data, "dGhyZWF0bG9ja2Vya2V5"));
        }

        [Theory(DisplayName = "GenerateSHA: Returns valid SHA.")]
        [InlineData("Lorem ipsum dolor sit amet", "16ABA5393AD72C0041F5600AD3C2C52EC437A2F0C7FC08FADFC3C0FE9641D7A3")]
        public void GenerateSHA_ReturnValidSHA(string text, string expected)
        {
            var result = Crypto.GenerateSHA(text);
            Assert.Equal(expected, result);
        }
    }
}
