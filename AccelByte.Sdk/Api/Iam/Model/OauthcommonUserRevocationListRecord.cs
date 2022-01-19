using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthcommonUserRevocationListRecord : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("revoked_at")]
        public DateTime? RevokedAt { get; set; }
        
    }
}