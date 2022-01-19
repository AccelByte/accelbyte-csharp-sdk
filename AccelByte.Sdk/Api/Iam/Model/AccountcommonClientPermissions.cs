using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonClientPermissions : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Permissions")]
        public List<AccountcommonClientPermission>? Permissions { get; set; }
        
    }
}