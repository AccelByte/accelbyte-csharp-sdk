using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonPermissionsV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("permissions")]
        public List<AccountcommonPermissionV3>? Permissions { get; set; }
        
    }
}