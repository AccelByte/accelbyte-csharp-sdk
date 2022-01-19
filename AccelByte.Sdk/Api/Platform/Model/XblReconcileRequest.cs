using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XblReconcileRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("xstsToken")]
        public string? XstsToken { get; set; }
        
    }
}