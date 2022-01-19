using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelListUserInformationResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelUserInfoResponse>? Data { get; set; }
        
    }
}