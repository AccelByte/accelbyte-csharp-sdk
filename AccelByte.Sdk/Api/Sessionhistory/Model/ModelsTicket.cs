// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionhistory.Model
{
    public class ModelsTicket : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("CreatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("Latencies")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, long>? Latencies { get; set; }

        [JsonPropertyName("MatchPool")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MatchPool { get; set; }

        [JsonPropertyName("Namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("PartySessionID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PartySessionID { get; set; }

        [JsonPropertyName("Players")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsPlayerData>? Players { get; set; }

        [JsonPropertyName("ProposedProposal")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsProposedProposal? ProposedProposal { get; set; }

        [JsonPropertyName("TicketAttributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? TicketAttributes { get; set; }

        [JsonPropertyName("TicketID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TicketID { get; set; }

    }

    public class ModelsTicket<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("CreatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("Latencies")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, long>? Latencies { get; set; }

        [JsonPropertyName("MatchPool")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MatchPool { get; set; }

        [JsonPropertyName("Namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("PartySessionID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PartySessionID { get; set; }

        [JsonPropertyName("Players")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsPlayerData>? Players { get; set; }

        [JsonPropertyName("ProposedProposal")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsProposedProposal? ProposedProposal { get; set; }

        [JsonPropertyName("TicketAttributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? TicketAttributes { get; set; }

        [JsonPropertyName("TicketID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TicketID { get; set; }

    }

}