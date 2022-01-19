using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class UserExpGrant : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("exp")]
        public int? Exp { get; set; }
        
    }
}