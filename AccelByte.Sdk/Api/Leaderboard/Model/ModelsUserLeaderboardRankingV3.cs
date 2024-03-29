// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsUserLeaderboardRankingV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsUserRankingResponseDetailV3? AllTime { get; set; }

        [JsonPropertyName("cycles")]
        public List<ModelsUserCycleRankingResponseDetail>? Cycles { get; set; }

        [JsonPropertyName("leaderboardCode")]
        public string? LeaderboardCode { get; set; }

        [JsonPropertyName("leaderboardName")]
        public string? LeaderboardName { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }


}