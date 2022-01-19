using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class NamespaceUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
    }
}