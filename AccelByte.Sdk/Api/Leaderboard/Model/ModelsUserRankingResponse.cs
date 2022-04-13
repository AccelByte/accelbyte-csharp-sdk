// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsUserRankingResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allTime")]
        public ModelsUserRankingResponseDetail? AllTime { get; set; }

        [JsonPropertyName("current")]
        public ModelsUserRankingResponseDetail? Current { get; set; }

        [JsonPropertyName("daily")]
        public ModelsUserRankingResponseDetail? Daily { get; set; }

        [JsonPropertyName("monthly")]
        public ModelsUserRankingResponseDetail? Monthly { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("weekly")]
        public ModelsUserRankingResponseDetail? Weekly { get; set; }

    }
}