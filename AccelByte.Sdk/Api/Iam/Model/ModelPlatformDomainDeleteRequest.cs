using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPlatformDomainDeleteRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("domain")]
        public string? Domain { get; set; }
        
    }
}