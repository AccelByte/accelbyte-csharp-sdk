using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class PassInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("seasonId")]
        public string? SeasonId { get; set; }
        
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("displayOrder")]
        public string? DisplayOrder { get; set; }
        
        [JsonPropertyName("autoEnroll")]
        public bool? AutoEnroll { get; set; }
        
        [JsonPropertyName("passItemId")]
        public string? PassItemId { get; set; }
        
        [JsonPropertyName("passItemName")]
        public string? PassItemName { get; set; }
        
        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }
        
        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}