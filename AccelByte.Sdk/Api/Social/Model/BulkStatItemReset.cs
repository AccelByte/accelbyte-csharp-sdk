using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class BulkStatItemReset : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
    }
}