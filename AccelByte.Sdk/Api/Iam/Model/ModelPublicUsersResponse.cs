using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPublicUsersResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Users")]
        public List<ModelPublicUserResponse>? Users { get; set; }
        
    }
}