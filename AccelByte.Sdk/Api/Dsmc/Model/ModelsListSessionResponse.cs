using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsListSessionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("paging")]
        public ModelsPagingCursor? Paging { get; set; }
        
        [JsonPropertyName("sessions")]
        public List<ModelsSession>? Sessions { get; set; }
        
    }
}