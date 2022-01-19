using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsSessionQueryResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("pagination")]
        public ModelsPagingCursor? Pagination { get; set; }
        
        [JsonPropertyName("sessions")]
        public List<ModelsGameSession>? Sessions { get; set; }
        
    }
}