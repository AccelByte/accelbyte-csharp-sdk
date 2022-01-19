using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsListTerminatedServersResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelsNotifPayloadServerStatusChange>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
    }
}