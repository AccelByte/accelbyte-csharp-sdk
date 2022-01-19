using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserProfileBulkRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }
        
    }
}