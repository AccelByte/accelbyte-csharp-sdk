using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonBanReasonsV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("reasons")]
        public List<AccountcommonBanReasonV3>? Reasons { get; set; }
        
    }
}