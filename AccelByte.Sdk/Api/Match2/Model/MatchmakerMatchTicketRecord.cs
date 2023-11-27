// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Match2.Model
{
    public class MatchmakerMatchTicketRecord : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("CreatedAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("IsActive")]
        public bool? IsActive { get; set; }

        [JsonPropertyName("PartySessionID")]
        public string? PartySessionID { get; set; }

        [JsonPropertyName("ProposedProposal")]
        public MatchmakerProposedProposal? ProposedProposal { get; set; }

        [JsonPropertyName("SessionID")]
        public string? SessionID { get; set; }

        [JsonPropertyName("Ticket")]
        public MatchmakerTicket? Ticket { get; set; }

        [JsonPropertyName("TicketID")]
        public string? TicketID { get; set; }

        [JsonPropertyName("UniqueTicketID")]
        public string? UniqueTicketID { get; set; }

    }


}