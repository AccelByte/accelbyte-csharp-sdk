using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserLoginHistoryResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ApplicationName")]
        public string? ApplicationName { get; set; }
        
        [JsonPropertyName("City")]
        public string? City { get; set; }
        
        [JsonPropertyName("Country")]
        public string? Country { get; set; }
        
        [JsonPropertyName("DeviceId")]
        public string? DeviceId { get; set; }
        
        [JsonPropertyName("State")]
        public string? State { get; set; }
        
        [JsonPropertyName("Timestamp")]
        public long? Timestamp { get; set; }
        
        [JsonPropertyName("deviceName")]
        public string? DeviceName { get; set; }
        
    }
}