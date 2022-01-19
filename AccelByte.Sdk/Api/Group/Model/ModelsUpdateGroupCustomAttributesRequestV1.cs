using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsUpdateGroupCustomAttributesRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("customAttributes")]
        public Dictionary<object, object>? CustomAttributes { get; set; }
        
    }
}