using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class PagedRetrieveUserAcceptedAgreementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<RetrieveUserAcceptedAgreementResponse>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}