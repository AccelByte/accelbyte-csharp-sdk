using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelGetUserJusticePlatformAccountResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DesignatedNamespace")]
        public string? DesignatedNamespace { get; set; }
        
        [JsonPropertyName("UserID")]
        public string? UserID { get; set; }
        
    }
}