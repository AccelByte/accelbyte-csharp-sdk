using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonConflictedUserPlatformAccounts : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platformUserID")]
        public string? PlatformUserID { get; set; }
        
        [JsonPropertyName("publisherAccounts")]
        public List<AccountcommonUserWithLinkedPlatformAccounts>? PublisherAccounts { get; set; }
        
    }
}