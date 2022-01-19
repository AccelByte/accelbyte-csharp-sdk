using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsCountServerResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("count")]
        public int? Count { get; set; }
        
    }
}