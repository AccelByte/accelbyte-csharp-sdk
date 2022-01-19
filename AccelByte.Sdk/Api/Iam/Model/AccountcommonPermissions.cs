using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonPermissions : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Permissions")]
        public List<AccountcommonPermission>? Permissions { get; set; }
        
    }
}