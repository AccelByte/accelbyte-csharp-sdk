using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsDeletionStatus : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DeletionStatus")]
        public bool? DeletionStatus { get; set; }
        
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("ExecutionDate")]
        public DateTime? ExecutionDate { get; set; }
        
        [JsonPropertyName("Status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("UserID")]
        public string? UserID { get; set; }
        
    }
}