using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class NamespaceStatusUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
    }
}