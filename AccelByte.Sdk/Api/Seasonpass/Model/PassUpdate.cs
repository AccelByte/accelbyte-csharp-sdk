using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class PassUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("displayOrder")]
        public int? DisplayOrder { get; set; }
        
        [JsonPropertyName("autoEnroll")]
        public bool? AutoEnroll { get; set; }
        
        [JsonPropertyName("passItemId")]
        public string? PassItemId { get; set; }
        
        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }
        
        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }
        
    }
}