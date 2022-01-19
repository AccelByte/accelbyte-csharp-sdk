using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ClientmodelClientUpdateSecretRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("NewSecret")]
        public string? NewSecret { get; set; }
        
    }
}