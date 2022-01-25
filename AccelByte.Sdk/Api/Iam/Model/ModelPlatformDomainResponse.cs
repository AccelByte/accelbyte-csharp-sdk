using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPlatformDomainResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("registeredDomains")]
        public List<AccountcommonRegisteredDomain>? RegisteredDomains { get; set; }
        
    }
}