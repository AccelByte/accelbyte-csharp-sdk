using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrieveUserEligibilitiesIndirectResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("isComply")]
        public bool? IsComply { get; set; }
        
    }
}