using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonClientPermissionV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        public int? Action { get; set; }
        
        [JsonPropertyName("resource")]
        public string? Resource { get; set; }
        
    }
}