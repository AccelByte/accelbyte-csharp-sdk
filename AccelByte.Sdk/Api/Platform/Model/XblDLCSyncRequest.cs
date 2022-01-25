using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XblDLCSyncRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("xstsToken")]
        public string? XstsToken { get; set; }
        
    }
}