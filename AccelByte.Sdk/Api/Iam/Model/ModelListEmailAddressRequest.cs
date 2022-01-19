using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelListEmailAddressRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("listEmailAddressRequest")]
        public List<string>? ListEmailAddressRequest { get; set; }
        
    }
}