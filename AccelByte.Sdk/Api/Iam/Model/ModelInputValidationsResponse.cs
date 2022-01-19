using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelInputValidationsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelInputValidationData>? Data { get; set; }
        
        [JsonPropertyName("version")]
        public int? Version { get; set; }
        
    }
}