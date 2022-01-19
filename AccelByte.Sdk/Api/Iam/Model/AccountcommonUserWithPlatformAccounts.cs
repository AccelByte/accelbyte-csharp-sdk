using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonUserWithPlatformAccounts : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("linkedPlatforms")]
        public List<AccountcommonPlatformAccount>? LinkedPlatforms { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}