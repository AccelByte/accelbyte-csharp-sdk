using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsConfigReq : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("autoKickOnDisconnect")]
        public bool? AutoKickOnDisconnect { get; set; }
        
        [JsonPropertyName("autoKickOnDisconnectDelay")]
        public long? AutoKickOnDisconnectDelay { get; set; }
        
        [JsonPropertyName("cancelTicketOnDisconnect")]
        public bool? CancelTicketOnDisconnect { get; set; }
        
        [JsonPropertyName("chatRateLimitBurst")]
        public int? ChatRateLimitBurst { get; set; }
        
        [JsonPropertyName("chatRateLimitDuration")]
        public long? ChatRateLimitDuration { get; set; }
        
        [JsonPropertyName("concurrentUsersLimit")]
        public int? ConcurrentUsersLimit { get; set; }
        
        [JsonPropertyName("disablePartyInvitationToken")]
        public bool? DisablePartyInvitationToken { get; set; }
        
        [JsonPropertyName("enableChat")]
        public bool? EnableChat { get; set; }
        
        [JsonPropertyName("entitlementCheck")]
        public bool? EntitlementCheck { get; set; }
        
        [JsonPropertyName("entitlementItemID")]
        public string? EntitlementItemID { get; set; }
        
        [JsonPropertyName("generalRateLimitBurst")]
        public int? GeneralRateLimitBurst { get; set; }
        
        [JsonPropertyName("generalRateLimitDuration")]
        public long? GeneralRateLimitDuration { get; set; }
        
        [JsonPropertyName("maxPartyMember")]
        public int? MaxPartyMember { get; set; }
        
        [JsonPropertyName("profanityFilter")]
        public bool? ProfanityFilter { get; set; }
        
        [JsonPropertyName("readyConsentTimeout")]
        public long? ReadyConsentTimeout { get; set; }
        
    }
}