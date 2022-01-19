using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelBanCreateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ban")]
        public string? Ban { get; set; }
        
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
        
        [JsonPropertyName("endDate")]
        public string? EndDate { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
        [JsonPropertyName("skipNotif")]
        public bool? SkipNotif { get; set; }
        
    }
}