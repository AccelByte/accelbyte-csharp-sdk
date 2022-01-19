using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsActiveCustomGameResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("pagination")]
        public ModelsPagingCursor? Pagination { get; set; }
        
        [JsonPropertyName("sessions")]
        public List<ModelsCustomGameResponse>? Sessions { get; set; }
        
    }
}