using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsRecentPlayerQueryResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsRecentPlayerHistory>? Data { get; set; }
        
    }
}