using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthcommonJWKSet : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("keys")]
        public List<OauthcommonJWKKey>? Keys { get; set; }
        
    }
}