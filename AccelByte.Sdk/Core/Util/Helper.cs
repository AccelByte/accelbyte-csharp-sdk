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

        public static string GenerateRandomPassword(int length)
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWabcdefghijklmnopqrstuvw0123456789!@#$%^&*()";
            return new String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}