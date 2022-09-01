// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Sample.TicTacToe.Model
{
    public class NewGameResult
    {
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = String.Empty;

        [JsonPropertyName("match_id")]
        public string MatchId { get; set; } = String.Empty;

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; } = String.Empty;
    }
}