using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsBulkUserIDsRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }
        
    }
}