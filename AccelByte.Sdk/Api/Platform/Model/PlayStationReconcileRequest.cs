using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlayStationReconcileRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("serviceLabel")]
        public int? ServiceLabel { get; set; }
        
    }
}