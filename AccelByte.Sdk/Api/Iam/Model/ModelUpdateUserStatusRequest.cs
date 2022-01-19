using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUpdateUserStatusRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
    }
}