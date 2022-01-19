using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CodeCreateResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("numCreated")]
        public int? NumCreated { get; set; }
        
    }
}