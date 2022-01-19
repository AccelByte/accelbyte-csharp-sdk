using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsGetImageDetailResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public ModelsImageRecord? Data { get; set; }
        
    }
}