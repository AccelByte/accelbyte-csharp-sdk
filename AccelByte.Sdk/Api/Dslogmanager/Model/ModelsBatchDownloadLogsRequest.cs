using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsBatchDownloadLogsRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Downloads")]
        public List<ModelsDownloadLogsRequest>? Downloads { get; set; }
        
    }
}