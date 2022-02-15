namespace AccelByte.Sdk.Core.Repository
{
    public class DefaultConfigRepository : IConfigRepository
    {
        private const String BASE_URL = "AB_BASE_URL";

        private const String CLIENT_ID = "AB_CLIENT_ID";

        private const String CLIENT_SECRET = "AB_CLIENT_SECRET";

        private const string CLIENT_APPNAME = "AB_APP_NAME";

        public string BaseUrl
        {
            get => Environment.GetEnvironmentVariable(BASE_URL) ?? 
                    throw new Exception($"Environment variable not found (variable: {BASE_URL})");
        }

        public string ClientId
        {
            get => Environment.GetEnvironmentVariable(CLIENT_ID) ?? 
                    throw new Exception($"Environment variable not found (variable: {CLIENT_ID})");
        }

        public string ClientSecret
        {
            get => Environment.GetEnvironmentVariable(CLIENT_SECRET) ??
                     throw new Exception($"Environment variable not found (variable: {CLIENT_SECRET})");
        }

        public string AppName
        {
            get => Environment.GetEnvironmentVariable(CLIENT_APPNAME) ??
                     throw new Exception($"Environment variable not found (variable: {CLIENT_APPNAME})");
        }
    }
}
