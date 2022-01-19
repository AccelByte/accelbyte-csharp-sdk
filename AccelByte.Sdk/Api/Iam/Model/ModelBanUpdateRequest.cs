using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelBanUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
        [JsonPropertyName("skipNotif")]
        public bool? SkipNotif { get; set; }
        
    }
}