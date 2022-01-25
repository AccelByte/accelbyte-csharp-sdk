using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelInviteUserRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("emailAddresses")]
        public List<string>? EmailAddresses { get; set; }
        
        [JsonPropertyName("isAdmin")]
        public bool? IsAdmin { get; set; }
        
        [JsonPropertyName("roles")]
        public List<string>? Roles { get; set; }
        
    }
}