using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthapiRevocationList : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("revoked_tokens")]
        public BloomFilterJSON? RevokedTokens { get; set; }
        
        [JsonPropertyName("revoked_users")]
        public List<OauthcommonUserRevocationListRecord>? RevokedUsers { get; set; }
        
    }
}