using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class BloomFilterJSON : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("bits")]
        public List<long>? Bits { get; set; }
        
        [JsonPropertyName("k")]
        public long? K { get; set; }
        
        [JsonPropertyName("m")]
        public long? M { get; set; }
        
    }
}