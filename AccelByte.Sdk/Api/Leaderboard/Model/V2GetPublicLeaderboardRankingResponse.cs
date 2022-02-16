// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class V2GetPublicLeaderboardRankingResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<V2Entry>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public V2Pagination? Paging { get; set; }
        
    }
}