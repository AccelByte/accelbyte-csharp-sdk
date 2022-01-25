using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelLinkRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("client_id")]
        public string? ClientId { get; set; }
        
        [JsonPropertyName("error")]
        public RestErrorResponse? Error { get; set; }
        
        [JsonPropertyName("expiration")]
        public int? Expiration { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("operation_name")]
        public string? OperationName { get; set; }
        
        [JsonPropertyName("payload")]
        public Dictionary<object, object>? Payload { get; set; }
        
        [JsonPropertyName("redirect_uri")]
        public string? RedirectUri { get; set; }
        
        [JsonPropertyName("request_id")]
        public string? RequestId { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
    }
}