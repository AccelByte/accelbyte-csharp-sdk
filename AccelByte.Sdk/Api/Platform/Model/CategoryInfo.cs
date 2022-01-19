using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CategoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("parentCategoryPath")]
        public string? ParentCategoryPath { get; set; }
        
        [JsonPropertyName("root")]
        public bool? Root { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}