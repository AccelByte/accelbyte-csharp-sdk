// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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

        public static string GenerateRandomId(int length)
        {
            Random random = new Random();
            string chars = "abcdefghijklmnopqrstuvw0123456789";
            return new String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string RandomizeChar(Random random, string source, int length)
        {
            string result = String.Empty;
            for (int i = 0; i < length; i++)
            {
                char temp = source[random.Next(source.Length)];
                while (true)
                {
                    if (result.IndexOf(temp) > -1)
                        temp = source[random.Next(source.Length)];
                    else
                    {
                        result += temp.ToString();
                        break;
                    }
                }
            }
            return result;
        }

        public static string GenerateRandomPassword(int length)
        {
            Random random = new Random();

            string final = String.Empty;
            int pCount = (length / 3);

            final += RandomizeChar(random, "ABCDEFGHIJKLMNOPQRSTUVWXYZ", pCount);
            final += RandomizeChar(random, "abcdefghijklmnopqrstuvwxyz", pCount);

            int fCount = (length - (pCount * 2));
            final += RandomizeChar(random, "0123456789!@#$%^&*()", fCount);

            return final;
        }
    }
}