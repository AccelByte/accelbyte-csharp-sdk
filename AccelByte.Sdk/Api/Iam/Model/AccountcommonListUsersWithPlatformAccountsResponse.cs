using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonListUsersWithPlatformAccountsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<AccountcommonUserWithPlatformAccounts>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public AccountcommonPaginationV3? Paging { get; set; }
        
        [JsonPropertyName("totalData")]
        public long? TotalData { get; set; }
        
    }
}