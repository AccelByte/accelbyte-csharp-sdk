using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Tests
{
    public class TestConfigRepository : IConfigRepository
    {
        public TestConfigRepository(string baseUrl, string clientId, string clientSecret)
        {
            BaseUrl = baseUrl;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        public string BaseUrl { get; init; }
        public string ClientId { get; init; }
        public string ClientSecret { get; init; }
    }
}