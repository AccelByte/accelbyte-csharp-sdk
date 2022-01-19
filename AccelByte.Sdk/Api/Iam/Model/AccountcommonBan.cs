using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonBan : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Ban")]
        public string? Ban { get; set; }
        
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        
    }
}