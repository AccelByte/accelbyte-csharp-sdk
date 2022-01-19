using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class UserTierGrant : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("count")]
        public int? Count { get; set; }
        
    }
}