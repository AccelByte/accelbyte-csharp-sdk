using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Client;

namespace AccelByte.Sdk.Core
{
    public class AccelByteConfig
    {
        public AccelByteConfig(IHttpClient httpClient, 
                ITokenRepository tokenRepository, 
                IConfigRepository configRepository)
        {
            HttpClient = httpClient;
            TokenRepository = tokenRepository;
            ConfigRepository = configRepository;
        }

        public IHttpClient HttpClient { get; }
        public ITokenRepository TokenRepository { get; }
        public IConfigRepository ConfigRepository { get; }
    }
}