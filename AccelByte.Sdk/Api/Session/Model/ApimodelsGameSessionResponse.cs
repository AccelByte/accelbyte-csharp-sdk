// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsGameSessionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DSInformation")]
        public ApimodelsDSInformationResponse? DSInformation { get; set; }

        [JsonPropertyName("attributes")]
        public Dictionary<string, object>? Attributes { get; set; }

        [JsonPropertyName("backfillTicketID")]
        public string? BackfillTicketID { get; set; }

        [JsonPropertyName("configuration")]
        public ApimodelsPublicConfiguration? Configuration { get; set; }

        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        [JsonPropertyName("expiredAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExpiredAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }

        [JsonPropertyName("isFull")]
        public bool? IsFull { get; set; }

        [JsonPropertyName("leaderID")]
        public string? LeaderID { get; set; }

        [JsonPropertyName("matchPool")]
        public string? MatchPool { get; set; }

        [JsonPropertyName("members")]
        public List<ApimodelsUserResponse>? Members { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("teams")]
        public List<ModelsTeam>? Teams { get; set; }

        [JsonPropertyName("ticketIDs")]
        public List<string>? TicketIDs { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("version")]
        public int? Version { get; set; }

    }

    public class ApimodelsGameSessionResponse<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DSInformation")]
        public ApimodelsDSInformationResponse? DSInformation { get; set; }

        [JsonPropertyName("attributes")]
        public T1? Attributes { get; set; }

        [JsonPropertyName("backfillTicketID")]
        public string? BackfillTicketID { get; set; }

        [JsonPropertyName("configuration")]
        public ApimodelsPublicConfiguration? Configuration { get; set; }

        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        [JsonPropertyName("expiredAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExpiredAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }

        [JsonPropertyName("isFull")]
        public bool? IsFull { get; set; }

        [JsonPropertyName("leaderID")]
        public string? LeaderID { get; set; }

        [JsonPropertyName("matchPool")]
        public string? MatchPool { get; set; }

        [JsonPropertyName("members")]
        public List<ApimodelsUserResponse>? Members { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("teams")]
        public List<ModelsTeam>? Teams { get; set; }

        [JsonPropertyName("ticketIDs")]
        public List<string>? TicketIDs { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("version")]
        public int? Version { get; set; }

    }

}