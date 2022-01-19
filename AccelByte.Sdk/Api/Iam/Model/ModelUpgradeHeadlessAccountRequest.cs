using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUpgradeHeadlessAccountRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("LoginID")]
        public string? LoginID { get; set; }
        
        [JsonPropertyName("Password")]
        public string? Password { get; set; }
        
    }
}