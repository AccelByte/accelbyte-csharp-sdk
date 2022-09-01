// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Sample.TicTacToe.Model
{
    public class MatchItem
    {
        [JsonPropertyName("id")]
        public string MatchId { get; set; } = String.Empty;

        [JsonPropertyName("is_full")]
        public bool IsFull { get; set; } = false;
    }
}