using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonPagination : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("First")]
        public string? First { get; set; }
        
        [JsonPropertyName("Last")]
        public string? Last { get; set; }
        
        [JsonPropertyName("Next")]
        public string? Next { get; set; }
        
        [JsonPropertyName("Previous")]
        public string? Previous { get; set; }
        
    }
}