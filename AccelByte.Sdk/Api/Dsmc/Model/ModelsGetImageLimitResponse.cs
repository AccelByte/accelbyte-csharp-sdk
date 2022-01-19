using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsGetImageLimitResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public ModelsGetImageLimitResponseData? Data { get; set; }
        
    }
}