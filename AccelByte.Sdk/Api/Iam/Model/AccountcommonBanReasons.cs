using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonBanReasons : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Reasons")]
        public List<AccountcommonBanReason>? Reasons { get; set; }
        
    }
}