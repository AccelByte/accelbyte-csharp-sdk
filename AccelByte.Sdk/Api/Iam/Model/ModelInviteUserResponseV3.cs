using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelInviteUserResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelUserInvitationV3>? Data { get; set; }
        
    }
}