using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XblIAPConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("relyingPartyCert")]
        public string? RelyingPartyCert { get; set; }
        
    }
}