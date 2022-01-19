using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonBansV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("bans")]
        public List<AccountcommonBanV3>? Bans { get; set; }
        
    }
}