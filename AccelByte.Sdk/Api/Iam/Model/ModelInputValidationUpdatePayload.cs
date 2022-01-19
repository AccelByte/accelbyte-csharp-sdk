using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelInputValidationUpdatePayload : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("field")]
        public string? Field { get; set; }
        
        [JsonPropertyName("validation")]
        public Validation? Validation { get; set; }
        
    }
}