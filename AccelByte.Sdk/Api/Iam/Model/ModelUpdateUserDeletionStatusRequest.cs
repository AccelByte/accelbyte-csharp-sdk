using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUpdateUserDeletionStatusRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
    }
}