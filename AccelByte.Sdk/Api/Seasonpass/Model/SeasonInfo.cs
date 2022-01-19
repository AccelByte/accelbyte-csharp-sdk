using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class SeasonInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("start")]
        public DateTime? Start { get; set; }
        
        [JsonPropertyName("end")]
        public DateTime? End { get; set; }
        
        [JsonPropertyName("defaultLanguage")]
        public string? DefaultLanguage { get; set; }
        
        [JsonPropertyName("defaultRequiredExp")]
        public int? DefaultRequiredExp { get; set; }
        
        [JsonPropertyName("draftStoreId")]
        public string? DraftStoreId { get; set; }
        
        [JsonPropertyName("tierItemId")]
        public string? TierItemId { get; set; }
        
        [JsonPropertyName("tierItemName")]
        public string? TierItemName { get; set; }
        
        [JsonPropertyName("autoClaim")]
        public bool? AutoClaim { get; set; }
        
        [JsonPropertyName("excessStrategy")]
        public ExcessStrategy? ExcessStrategy { get; set; }
        
        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }
        
        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }
        
        [JsonPropertyName("passCodes")]
        public List<string>? PassCodes { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("publishedAt")]
        public DateTime? PublishedAt { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}