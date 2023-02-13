// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsMatchingParty : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("first_ticket_created_at")]
        public long? FirstTicketCreatedAt { get; set; }

        [JsonPropertyName("party_attributes")]
        public Dictionary<string, object>? PartyAttributes { get; set; }

        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }

        [JsonPropertyName("party_members")]
        public List<ModelsPartyMember>? PartyMembers { get; set; }

        [JsonPropertyName("ticket_id")]
        public string? TicketId { get; set; }

    }

    public class ModelsMatchingParty<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("first_ticket_created_at")]
        public long? FirstTicketCreatedAt { get; set; }

        [JsonPropertyName("party_attributes")]
        public T1? PartyAttributes { get; set; }

        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }

        [JsonPropertyName("party_members")]
        public List<ModelsPartyMember>? PartyMembers { get; set; }

        [JsonPropertyName("ticket_id")]
        public string? TicketId { get; set; }

    }

}