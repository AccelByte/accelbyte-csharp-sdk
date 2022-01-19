using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ClientmodelClientResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ClientId")]
        public string? ClientId { get; set; }
        
        [JsonPropertyName("ClientName")]
        public string? ClientName { get; set; }
        
        [JsonPropertyName("ClientPermissions")]
        public List<AccountcommonPermission>? ClientPermissions { get; set; }
        
        [JsonPropertyName("CreatedAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("RedirectUri")]
        public string? RedirectUri { get; set; }
        
    }
}