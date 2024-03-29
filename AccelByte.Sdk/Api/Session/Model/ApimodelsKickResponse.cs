// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsKickResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("leaderID")]
        public string? LeaderID { get; set; }

        [JsonPropertyName("members")]
        public List<ApimodelsUserResponse>? Members { get; set; }

        [JsonPropertyName("partyID")]
        public string? PartyID { get; set; }

    }


}