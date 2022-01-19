using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class BannedBy : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}