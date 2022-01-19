using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsAddPlayerResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("status")]
        public bool? Status { get; set; }
        
    }
}