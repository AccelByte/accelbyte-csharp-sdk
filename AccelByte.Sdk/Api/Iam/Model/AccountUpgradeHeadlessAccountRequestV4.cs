using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountUpgradeHeadlessAccountRequestV4 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
        [JsonPropertyName("username")]
        public string? Username { get; set; }
        
    }
}