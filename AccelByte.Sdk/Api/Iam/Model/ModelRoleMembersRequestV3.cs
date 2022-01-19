using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleMembersRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("members")]
        public List<AccountcommonRoleMemberV3>? Members { get; set; }
        
    }
}