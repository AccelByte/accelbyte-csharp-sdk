using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsAdminSetProfanityRuleForNamespaceRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("rule")]
        public string? Rule { get; set; }
        
    }
}