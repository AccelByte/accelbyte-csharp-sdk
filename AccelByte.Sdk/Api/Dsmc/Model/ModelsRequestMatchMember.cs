using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsRequestMatchMember : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
    }
}