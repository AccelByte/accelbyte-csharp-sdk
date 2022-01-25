using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserIDsRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }
        
    }
}