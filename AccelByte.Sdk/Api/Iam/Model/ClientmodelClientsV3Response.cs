using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ClientmodelClientsV3Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ClientmodelClientV3Response>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public AccountcommonPaginationV3? Paging { get; set; }
        
    }
}