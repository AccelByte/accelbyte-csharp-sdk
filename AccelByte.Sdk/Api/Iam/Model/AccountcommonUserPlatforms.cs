using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonUserPlatforms : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("userIdPlatforms")]
        public List<AccountcommonUserPlatformInfo>? UserIdPlatforms { get; set; }
        
    }
}