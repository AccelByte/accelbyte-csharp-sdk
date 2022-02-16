// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsDeleteBulkLeaderboardFailedResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }
        
        [JsonPropertyName("leaderboardCode")]
        public string? LeaderboardCode { get; set; }
        
    }
}