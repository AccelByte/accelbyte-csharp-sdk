using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleMembersRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Members")]
        public List<AccountcommonRoleMember>? Members { get; set; }
        
    }
}