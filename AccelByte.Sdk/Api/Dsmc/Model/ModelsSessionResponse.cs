using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsSessionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("session")]
        public ModelsSession? Session { get; set; }
        
    }
}