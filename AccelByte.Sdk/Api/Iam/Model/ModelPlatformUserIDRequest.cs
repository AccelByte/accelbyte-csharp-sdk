using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPlatformUserIDRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platformUserIds")]
        public List<string>? PlatformUserIds { get; set; }
        
    }
}