using System.Security.Cryptography;
using System.Text;

namespace AccelByte.Sdk.Core.Util
{
    public static class Helper
    {
        public static string GenerateCodeVerifier()
        {
            var codeVerifier = new byte[32];
            var random = new Random();
            random.NextBytes(codeVerifier);

            return EncodeBase64Url(codeVerifier);
        }

        public static string GenerateCodeChallenge(string codeVerifier)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));

                return EncodeBase64Url(bytes);
            }
        }

        public static string ConvertInputStreamToString(Stream @is)
        {
            using (var sr = new StreamReader(@is))
            {
                return sr.ReadToEnd();
            }
        }

        private static string EncodeBase64Url(byte[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            return Convert.ToBase64String(data).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }
    }
}