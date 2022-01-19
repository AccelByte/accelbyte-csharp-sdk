using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OwnershipToken : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ownershipToken")]
        public string? OwnershipToken_ { get; set; }
        
    }
}