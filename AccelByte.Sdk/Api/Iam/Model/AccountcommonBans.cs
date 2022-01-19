using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonBans : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Bans")]
        public List<AccountcommonBan>? Bans { get; set; }
        
    }
}