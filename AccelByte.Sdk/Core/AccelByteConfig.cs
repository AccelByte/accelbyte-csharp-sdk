using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Core
{
    public class AccelByteConfig
    {
        public AccelByteConfig(AccelByte.Sdk.Core.Client.HttpClient httpClient, 
                TokenRepository tokenRepository, 
                ConfigRepository configRepository)
        {
            HttpClient = httpClient;
            TokenRepository = tokenRepository;
            ConfigRepository = configRepository;
        }

        public AccelByte.Sdk.Core.Client.HttpClient HttpClient { get; }
        public TokenRepository TokenRepository { get; }
        public ConfigRepository ConfigRepository { get; }
    }
}