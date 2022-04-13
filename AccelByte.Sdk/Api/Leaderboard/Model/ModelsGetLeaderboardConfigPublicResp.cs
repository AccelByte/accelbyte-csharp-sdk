// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsGetLeaderboardConfigPublicResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("iconURL")]
        public string? IconURL { get; set; }

        [JsonPropertyName("leaderboardCode")]
        public string? LeaderboardCode { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }

    }
}