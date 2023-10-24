// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Lobby.Model;

using AccelByte.Sdk.Sample.TicTacToe.Provider;
using AccelByte.Sdk.Sample.TicTacToe.Model;

namespace AccelByte.Sdk.Sample.TicTacToe
{
    public class TicTacToeServer
    {
        public const string CACHEKEY_MATCHLIST = "t3sample_matches";

        public const string WSTOPIC_START = "START";

        public const string WSTOPIC_UPDATE = "UPDATE";

        public const string WSTOPIC_WIN = "WIN";

        public const string WSTOPIC_LOSE = "LOSE";

        private readonly AccelByteSDK _Sdk;

        private readonly ICacheProvider _Cache;

        public char P1Symbol { get; set; } = 'o';

        public char P2Symbol { get; set; } = 'x';

        public TicTacToeServer(AccelByteSDK sdk, ICacheProvider cacheProvider)
        {
            _Sdk = sdk;
            _Cache = cacheProvider;
        }

        public string ValidateAuthToken(string authToken)
        {
            OauthmodelTokenResponseV3? oauthToken = _Sdk.Iam.OAuth20.VerifyTokenV3Op
                .SetPreferredSecurityMethod(Operation.SECURITY_BASIC)
                .Execute(authToken);
            if (oauthToken == null)
                throw new Exception("NULL oauthToken");
            return oauthToken.UserId!;
        }

        public string GetUsername(string userId)
        {
            AccountcommonUserInformationV3? userInfo = _Sdk.Iam.Users.PublicGetUserInformationV3Op
                .Execute(_Sdk.Namespace, userId);
            if (userInfo == null)
                throw new Exception("NULL userInfo");
            return userInfo.Username!;
        }

        public void SendNotificationToUser(string userId, string topic, object payload)
        {
            ModelFreeFormNotificationRequest notifBody = new ModelFreeFormNotificationRequest()
            {
                Topic = topic,
                Message = (payload is String ? payload.ToString() : JsonSerializer.Serialize(payload))
            };

            _Sdk.Lobby.Notification.FreeFormNotificationByUserIDOp
                .Execute(notifBody, _Sdk.Namespace, userId);
        }

        public NewGameResult NewGame(string userId)
        {
            MatchData mData = new MatchData()
            {
                MatchId = Guid.NewGuid().ToString().Replace("-", ""),
                P1UserId = userId,
                P1Name = GetUsername(userId)
            };

            _Cache.PushItem(CACHEKEY_MATCHLIST, mData.MatchId);
            _Cache.Save(mData.MatchId, JsonSerializer.Serialize(mData));

            return new NewGameResult()
            {
                MatchId = mData.MatchId,
                Symbol = P1Symbol.ToString(),
                UserId = userId
            };
        }

        public NewGameResult JoinGame(string userId, string matchId)
        {
            string? strMData = _Cache.Load(matchId);
            if (strMData == null)
                throw new Exception("No match session with specified id.");

            MatchData? mData = JsonSerializer.Deserialize<MatchData>(strMData);
            if (mData == null)
                throw new Exception("Cannot deserialize match data.");

            if (mData.IsFull)
                throw new Exception("Match session is full.");

            if (mData.P1UserId == userId)
                throw new Exception("Hey, you can't play with yourself.");

            mData.P2UserId = userId;
            mData.P2Name = GetUsername(userId);
            mData.InitializeEmptyBoard();
            _Cache.Save(mData.MatchId, JsonSerializer.Serialize(mData));

            //
            MatchUpdate mUpdate = new MatchUpdate(mData);

            mUpdate.IsPlayerTurn = true;
            SendNotificationToUser(mData.P1UserId, WSTOPIC_START, mUpdate);

            mUpdate.IsPlayerTurn = false;
            SendNotificationToUser(mData.P2UserId, WSTOPIC_START, mUpdate);
            //

            return new NewGameResult()
            {
                MatchId = mData.MatchId,
                Symbol = P2Symbol.ToString(),
                UserId = userId
            };
        }

        public void Move(string userId, string matchId, int row, int col)
        {
            string? strMData = _Cache.Load(matchId);
            if (strMData == null)
                throw new Exception("No match session with specified id.");

            MatchData? mData = JsonSerializer.Deserialize<MatchData>(strMData);
            if (mData == null)
                throw new Exception("Cannot deserialize match data.");

            Dictionary<(int, int), char>? board = mData.BoardData;
            if (board == null)
                throw new Exception("Missing board");

            char prevContent = board[(row, col)];
            if (prevContent != ' ')
                throw new Exception("Invalid move!");

            bool isPlayer1NextTurn = false;
            if (userId == mData.P1UserId)
            {
                board[(row, col)] = P1Symbol;
                isPlayer1NextTurn = false;
            }
            else if (userId == mData.P2UserId)
            {
                board[(row, col)] = P2Symbol;
                isPlayer1NextTurn = true;
            }

            mData.BoardData = board;
            _Cache.Save(mData.MatchId, JsonSerializer.Serialize(mData));

            //
            MatchUpdate mUpdate = new MatchUpdate(mData);

            mUpdate.IsPlayerTurn = isPlayer1NextTurn;
            SendNotificationToUser(mData.P1UserId, WSTOPIC_UPDATE, mUpdate);

            mUpdate.IsPlayerTurn = !isPlayer1NextTurn;
            SendNotificationToUser(mData.P2UserId, WSTOPIC_UPDATE, mUpdate);
            //

            if (mData.BoardData == null)
                return;

            int win = DeduceWinner(mData.BoardData, mData.BoardSize);
            if (win == 1)
            {
                mData.WinnerUserId = mData.P1UserId;
                mData.IsConcluded = true;
                _Cache.Save(mData.MatchId, JsonSerializer.Serialize(mData));

                MatchUpdate newUpdate = new MatchUpdate(mData);
                SendNotificationToUser(mData.P1UserId, WSTOPIC_WIN, newUpdate);
                SendNotificationToUser(mData.P2UserId, WSTOPIC_LOSE, newUpdate);
            }
            else if (win == 2)
            {
                mData.WinnerUserId = mData.P2UserId;
                mData.IsConcluded = true;
                _Cache.Save(mData.MatchId, JsonSerializer.Serialize(mData));

                MatchUpdate newUpdate = new MatchUpdate(mData);
                SendNotificationToUser(mData.P1UserId, WSTOPIC_LOSE, newUpdate);
                SendNotificationToUser(mData.P2UserId, WSTOPIC_WIN, newUpdate);
            }
        }

        public List<MatchItem> GetActiveMatches()
        {
            List<MatchItem> matches = new List<MatchItem>();

            List<string>? strMatches = _Cache.GetItems(CACHEKEY_MATCHLIST);
            if (strMatches != null)
            {
                foreach (string matchId in strMatches)
                {
                    string? strMData = _Cache.Load(matchId);
                    if (strMData == null)
                        continue;

                    MatchData? mData = JsonSerializer.Deserialize<MatchData>(strMData);
                    if (mData == null)
                        throw new Exception("Cannot deserialize match data.");

                    if (!mData.IsConcluded)
                    {
                        matches.Add(new MatchItem()
                        {
                            MatchId = matchId,
                            IsFull = mData.IsFull
                        });
                    }
                }
            }

            return matches;
        }

        public int DeduceWinner(Dictionary<(int, int), char> board, int size)
        {
            double a1 = 6.0;
            double a2 = 13.0;

            List<double> values = new List<double>();

            for (int row = 0; row < size; row++)
            {
                double r_val = 0.0;
                for (int col = 0; col < size; col++)
                {
                    if (board[(row, col)] == P1Symbol)
                        r_val += a1;
                    else if (board[(row, col)] == P2Symbol)
                        r_val += a2;
                }
                values.Add(r_val / (double)size);
            }

            for (int col = 0; col < size; col++)
            {
                double c_val = 0.0;
                for (int row = 0; row < size; row++)
                {
                    if (board[(row, col)] == P1Symbol)
                        c_val += a1;
                    else if (board[(row, col)] == P2Symbol)
                        c_val += a2;
                }
                values.Add(c_val / (double)size);
            }

            double lx_val = 0.0;
            for (int lx = 0; lx < size; lx++)
            {
                if (board[(lx, lx)] == P1Symbol)
                    lx_val += a1;
                else if (board[(lx, lx)] == P2Symbol)
                    lx_val += a2;
            }
            values.Add(lx_val / (double)size);

            double rx_val = 0.0;
            for (int lx = 0; lx < size; lx++)
            {
                if (board[(4 - lx, lx)] == P1Symbol)
                    rx_val += a1;
                else if (board[(4 - lx, lx)] == P2Symbol)
                    rx_val += a2;
            }
            values.Add(rx_val / (double)size);

            int p1c = 0;
            int p2c = 0;
            foreach (double val in values)
            {
                if (val == a1)
                    p1c++;
                else if (val == a2)
                    p2c++;
            }

            return (p1c > p2c ? 1 : (p2c > p1c ? 2 : 0));
        }
    }
}