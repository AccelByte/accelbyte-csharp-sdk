using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class BulkUserStatItemReset : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}