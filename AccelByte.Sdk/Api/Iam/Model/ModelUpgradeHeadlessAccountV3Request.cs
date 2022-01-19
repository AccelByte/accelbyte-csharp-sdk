using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUpgradeHeadlessAccountV3Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
    }
}