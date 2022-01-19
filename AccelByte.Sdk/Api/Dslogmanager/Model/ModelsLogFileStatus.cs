using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsLogFileStatus : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("log_existence")]
        public bool? LogExistence { get; set; }
        
    }
}