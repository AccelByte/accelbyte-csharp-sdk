using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelListUserResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelUserResponseV3>? Data { get; set; }
        
    }
}