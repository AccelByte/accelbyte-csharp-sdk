using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonClientPermissionsV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("permissions")]
        public List<AccountcommonClientPermissionV3>? Permissions { get; set; }
        
    }
}