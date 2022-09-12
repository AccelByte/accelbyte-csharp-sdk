// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Sample.TicTacToe.Model
{
    public class MatchData
    {
        [JsonPropertyName("match_id")]
        public string MatchId { get; set; } = String.Empty;

        [JsonPropertyName("p1_user_id")]
        public string P1UserId { get; set; } = String.Empty;

        [JsonPropertyName("p1_name")]
        public string P1Name { get; set; } = String.Empty;

        [JsonPropertyName("p2_user_id")]
        public string P2UserId { get; set; } = String.Empty;

        [JsonPropertyName("p2_name")]
        public string P2Name { get; set; } = String.Empty;

        [JsonPropertyName("board_size")]
        public int BoardSize { get; set; } = 5;

        [JsonPropertyName("board_state")]
        public string BoardState { get; set; } = String.Empty;

        [JsonPropertyName("is_concluded")]
        public bool IsConcluded { get; set; } = false;

        [JsonPropertyName("winner_user_id")]
        public string WinnerUserId { get; set; } = String.Empty;

        [JsonIgnore]
        public bool IsFull
        {
            get { return (P1UserId != String.Empty) && (P2UserId != String.Empty); }
        }

        [JsonIgnore]
        public Dictionary<(int, int), char>? BoardData //(row,col),symbol
        {
            get
            {
                if (BoardState == String.Empty)
                    return null;

                if ((BoardState[0] != '|') || (BoardState[^1] != '|'))
                    throw new Exception("Invalid board state value.");
                string state = BoardState.Substring(1, BoardState.Length - 2);

                Dictionary<(int, int), char> data = new Dictionary<(int, int), char>();
                for (int row = 0; row < BoardSize; row++)
                {
                    for (int col = 0; col < BoardSize; col++)
                    {
                        int cIdx = ((row * BoardSize) + col);
                        data.Add((row, col), state[cIdx]);
                    }
                }
                return data;
            }
            set
            {
                if (value == null)
                {
                    BoardState = String.Empty;
                    return;
                }

                string data = String.Empty;
                for (int row = 0; row < BoardSize; row++)
                {
                    for (int col = 0; col < BoardSize; col++)
                        data += value[(row, col)].ToString();
                }

                BoardState = ("|" + data + "|");
            }
        }

        public void InitializeEmptyBoard()
        {
            Dictionary<(int, int), char> data = new Dictionary<(int, int), char>();
            for (int r = 0; r < BoardSize; r++)
            {
                for (int c = 0; c < BoardSize; c++)
                {
                    data.Add((r, c), ' ');
                }
            }
            BoardData = data;
        }
    }
}