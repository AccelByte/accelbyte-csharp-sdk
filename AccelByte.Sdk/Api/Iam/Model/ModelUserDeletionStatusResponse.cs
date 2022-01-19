using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserDeletionStatusResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("deletionStatus")]
        public bool? DeletionStatus { get; set; }
        
    }
}