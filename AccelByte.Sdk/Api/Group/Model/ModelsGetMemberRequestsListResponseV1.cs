using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsGetMemberRequestsListResponseV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsMemberRequestResponseV1>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagination? Paging { get; set; }
        
    }
}