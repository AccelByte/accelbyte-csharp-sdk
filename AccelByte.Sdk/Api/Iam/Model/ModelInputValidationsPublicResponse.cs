using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelInputValidationsPublicResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelInputValidationDataPublic>? Data { get; set; }
        
        [JsonPropertyName("version")]
        public int? Version { get; set; }
        
    }
}