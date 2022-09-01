// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Text.Json;
using System.Net;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api.Lobby;
using AccelByte.Sdk.Api.Lobby.WSModel;

using AccelByte.Sdk.Sample.TicTacToe;
using AccelByte.Sdk.Sample.TicTacToe.Model;

namespace AccelByte.Sdk.Sample.TicTacToe.Game
{
    public class Player
    {
        private string _AccessToken = String.Empty;

        private bool _IsLobbyWSConnected = false;

        private char _PlayerSymbol = ' ';

        private string _ServerUrl;

        private LobbyService _LobbyWs;

        private AccelByteSDK _Sdk;

        public string ActiveMatchId { get; set; } = String.Empty;

        public string UserId { get; set; } = String.Empty;

        public Action<MatchUpdate, Dictionary<(int, int), char>>? OnMatchStarted { get; set; } = null;

        public Action<MatchUpdate, Dictionary<(int, int), char>>? OnMatchUpdated { get; set; } = null;

        public Action<MatchUpdate, bool>? OnMatchConcluded { get; set; } = null;

        public bool IsCredentialAvailable
        {
            get { return _Sdk.Configuration.Credential != null; }
        }

        protected bool SendRequest(HttpMethod method, string endpoint, Dictionary<string, string>? data)
        {
            string url = _ServerUrl + endpoint;

            HttpRequestMessage req = new HttpRequestMessage(method, url);
            if (_AccessToken != String.Empty)
                req.Headers.TryAddWithoutValidation("Authorization", "Bearer " + _AccessToken);

            if (data != null)
                req.Content = new FormUrlEncodedContent(data);

            HttpResponseMessage resp = DefaultHttpClient.Http.Send(req);
            return ((resp.StatusCode == HttpStatusCode.OK) || (resp.StatusCode == HttpStatusCode.NoContent));
        }

        protected R SendRequest<R>(HttpMethod method, string endpoint, Dictionary<string,string>? data)
        {
            string url = _ServerUrl + endpoint;

            HttpRequestMessage req = new HttpRequestMessage(method, url);
            if (_AccessToken != String.Empty)
                req.Headers.TryAddWithoutValidation("Authorization", "Bearer " + _AccessToken);

            if (data != null)
                req.Content = new FormUrlEncodedContent(data);

            HttpResponseMessage resp = DefaultHttpClient.Http.Send(req);

            R? response = JsonSerializer.Deserialize<R>(resp.Content.ReadAsStream());
            if (response != null)
                return response;
            else
                throw new Exception("Could not deserialize response body.");
        }

        protected Dictionary<(int, int), char> ToBoardData(string boardState, int boardSize)
        {
            if (boardState == String.Empty)
                throw new Exception("Board state is empty!");

            if ((boardState[0] != '|') || (boardState[^1] != '|'))
                throw new Exception("Invalid board state value.");
            string state = boardState.Substring(1, boardState.Length - 2);

            Dictionary<(int, int), char> data = new Dictionary<(int, int), char>();
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    int cIdx = ((row * boardSize) + col);
                    data.Add((row, col), state[cIdx]);
                }
            }
            return data;
        }

        public Player(CommandArguments cArgs)
        {
            _ServerUrl = cArgs.ServerURL;
            AccelByteSdkBuilder builder = AccelByteSDK.Builder
                    .UseDefaultHttpClient()
                    .UseDefaultTokenRepository();
            if (cArgs.SdkConfigFile != String.Empty)
                builder.UseJsonConfigRepository(cArgs.SdkConfigFile);
            else
                builder.UseDefaultConfigRepository();
            if (cArgs.SdkCredentialFile != String.Empty)
                builder.UseJsonCredentialRepository(cArgs.SdkCredentialFile);

            if (cArgs.IsLogEnabled)
                builder.EnableLog();

            _Sdk = builder.Build();
            _LobbyWs = new LobbyService(_Sdk.Configuration)
            {
                RedirectAllReceivedMessagesToMessageReceivedEvent = true,
                OnMessageReceived = (msg) =>
                {
                    if (msg.MessageType == "messageNotif")
                    {
                        string topic = msg.Data["topic"].Trim();
                        string payload = msg.Data["payload"].Trim();                        

                        if (topic == TicTacToeServer.WSTOPIC_START)
                        {
                            MatchUpdate? mUpdate = JsonSerializer.Deserialize<MatchUpdate>(payload);
                            if (mUpdate != null)
                                OnMatchStarted?.Invoke(mUpdate, ToBoardData(mUpdate.BoardState, mUpdate.BoardSize));
                        }
                        else if (topic == TicTacToeServer.WSTOPIC_UPDATE)
                        {
                            MatchUpdate? mUpdate = JsonSerializer.Deserialize<MatchUpdate>(payload);
                            if (mUpdate != null)
                                OnMatchUpdated?.Invoke(mUpdate, ToBoardData(mUpdate.BoardState, mUpdate.BoardSize));
                        }
                        else if (topic == TicTacToeServer.WSTOPIC_WIN)
                        {
                            MatchUpdate? mUpdate = JsonSerializer.Deserialize<MatchUpdate>(payload);
                            if (mUpdate != null)
                                OnMatchConcluded?.Invoke(mUpdate, true);
                        }
                        else if (topic == TicTacToeServer.WSTOPIC_LOSE)
                        {
                            MatchUpdate? mUpdate = JsonSerializer.Deserialize<MatchUpdate>(payload);
                            if (mUpdate != null)
                                OnMatchConcluded?.Invoke(mUpdate, false);
                        }
                    }
                }
            };
        }

        public bool Login(string userName, string password)
        {
            if (!_Sdk.LoginUser(userName, password, (tr) =>
             {
                 UserId = tr.UserId!;
             }))
                return false;
            _AccessToken = _Sdk.Configuration.TokenRepository.Token;

            //Connect to Lobby WS
            Task connectTask = _LobbyWs.Connect(false);
            connectTask.Wait();

            Task listenTask = Task.Run(() => _LobbyWs.Listen());
            _IsLobbyWSConnected = true;

            return true;
        }

        public bool Login()
        {
            if (!_Sdk.LoginUser((tr) =>
            {
                UserId = tr.UserId!;
            }))
                return false;
            _AccessToken = _Sdk.Configuration.TokenRepository.Token;

            //Connect to Lobby WS
            Task connectTask = _LobbyWs.Connect(false);
            connectTask.Wait();

            Task listenTask = Task.Run(() => _LobbyWs.Listen());
            _IsLobbyWSConnected = true;

            return true;
        }

        public void NewGame()
        {
            if (_AccessToken == String.Empty)
                throw new Exception("No valid login session. Please login first.");
            if (!_IsLobbyWSConnected)
                throw new Exception("No active Lobby WS connection.");

            NewGameResult game = SendRequest<NewGameResult>(HttpMethod.Post, "/match/start", null);
            _PlayerSymbol = game.Symbol[0];
            ActiveMatchId = game.MatchId;
        }

        public void JoinGame(string matchId)
        {
            if (_AccessToken == String.Empty)
                throw new Exception("No valid login session. Please login first.");
            if (!_IsLobbyWSConnected)
                throw new Exception("No active Lobby WS connection.");

            NewGameResult game = SendRequest<NewGameResult>(HttpMethod.Post, "/match/join", new Dictionary<string, string>()
            {
                { "match_id", matchId },
            });
            _PlayerSymbol = game.Symbol[0];
            ActiveMatchId = game.MatchId;
        }

        public void MakeAMove(int row, int col)
        {
            SendRequest(HttpMethod.Post, "/match/move", new Dictionary<string, string>()
            {
                { "match_id", ActiveMatchId },
                { "row", row.ToString() },
                { "column", col.ToString() }
            });
        }

        public List<string> GetAvailableMatches()
        {
            List<MatchItem> matches = SendRequest<List<MatchItem>>(HttpMethod.Get, "/matches", null);

            List<string> matchIds = new List<string>();
            foreach (MatchItem matchItem in matches)
            {
                if (!matchItem.IsFull)
                    matchIds.Add(matchItem.MatchId);
            }
            return matchIds;
        }

        public void Disconnect()
        {
            if ((_LobbyWs != null) && (_IsLobbyWSConnected))
            {
                Task disconnectTask = _LobbyWs.Disconnect();
                disconnectTask.Wait();
            }
        }

    }
}