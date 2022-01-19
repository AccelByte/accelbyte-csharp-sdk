using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelSearchUsersResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Data")]
        public List<AccountcommonUserSearchResult>? Data { get; set; }
        
    }
}