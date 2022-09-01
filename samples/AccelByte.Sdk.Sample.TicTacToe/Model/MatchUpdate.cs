// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Sample.TicTacToe.Model
{
    public class MatchUpdate
    {
        [JsonPropertyName("match_id")]
        public string MatchId { get; set; } = String.Empty;

        [JsonPropertyName("p1_name")]
        public string P1Name { get; set; } = String.Empty;

        [JsonPropertyName("p2_name")]
        public string P2Name { get; set; } = String.Empty;

        [JsonPropertyName("board_size")]
        public int BoardSize { get; set; } = 5;

        [JsonPropertyName("board_state")]
        public string BoardState { get; set; } = String.Empty;

        [JsonPropertyName("player_turn")]
        public bool IsPlayerTurn { get; set; } = false;

        public MatchUpdate() { }

        public MatchUpdate(MatchData mData)
        {
            MatchId = mData.MatchId;
            P1Name = mData.P1Name;
            P2Name = mData.P2Name;
            BoardSize = mData.BoardSize;
            BoardState = mData.BoardState;
        }
    }
}