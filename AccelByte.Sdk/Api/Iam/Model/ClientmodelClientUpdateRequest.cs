using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ClientmodelClientUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ClientName")]
        public string? ClientName { get; set; }
        
        [JsonPropertyName("RedirectUri")]
        public string? RedirectUri { get; set; }
        
    }
}