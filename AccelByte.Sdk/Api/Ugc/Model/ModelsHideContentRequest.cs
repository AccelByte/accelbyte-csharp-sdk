using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsHideContentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("isHidden")]
        public bool? IsHidden { get; set; }
        
    }
}