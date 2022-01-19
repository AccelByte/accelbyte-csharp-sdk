using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonUserLinkedPlatformsResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<AccountcommonUserLinkedPlatformV3>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public AccountcommonPaginationV3? Paging { get; set; }
        
    }
}