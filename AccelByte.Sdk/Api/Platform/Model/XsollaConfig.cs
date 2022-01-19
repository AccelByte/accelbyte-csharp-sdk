using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XsollaConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }
        
        [JsonPropertyName("flowCompletionUrl")]
        public string? FlowCompletionUrl { get; set; }
        
        [JsonPropertyName("merchantId")]
        public int? MerchantId { get; set; }
        
        [JsonPropertyName("projectId")]
        public int? ProjectId { get; set; }
        
        [JsonPropertyName("projectSecretKey")]
        public string? ProjectSecretKey { get; set; }
        
    }
}