using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsGetMemberRolesListResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsGetMemberRoleResponseV1>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}