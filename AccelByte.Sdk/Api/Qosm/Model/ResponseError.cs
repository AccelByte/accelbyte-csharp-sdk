using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Qosm.Model
{
    public class ResponseError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public int? Code { get; set; }
        
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        
    }
}