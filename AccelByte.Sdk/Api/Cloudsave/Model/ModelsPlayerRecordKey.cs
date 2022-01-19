using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsPlayerRecordKey : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
    }
}