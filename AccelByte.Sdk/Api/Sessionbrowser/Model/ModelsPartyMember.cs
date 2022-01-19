using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsPartyMember : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extra_attributes")]
        public Dictionary<object, object>? ExtraAttributes { get; set; }
        
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
    }
}