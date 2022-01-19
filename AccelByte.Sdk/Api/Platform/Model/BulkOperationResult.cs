using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class BulkOperationResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affected")]
        public int? Affected { get; set; }
        
    }
}