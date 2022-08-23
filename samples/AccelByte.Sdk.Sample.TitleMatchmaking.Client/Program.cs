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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Api.Lobby;
using AccelByte.Sdk.Api.Lobby.WSModel;

namespace AccelByte.Sdk.Sample.TitleMatchmaking.Client
{
    internal class Program
    {
        static int Main(string[] args)
        {
            string _LoginAccessToken = String.Empty;
            bool isLobbyWSConnected = false;
            LobbyService? lobbyWs = null;

            try
            {
                CommandArguments cArgs = new CommandArguments(args);

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

                AccelByteSDK sdk = builder.Build();
                lobbyWs = new LobbyService(sdk.Configuration)
                {
                    ProcessRawMessage = false,
                    OnRawMessageReceived = (aMsg) =>
                    {
                        Console.WriteLine("WS Message: {0}", aMsg);
                    }
                };

                (new CommandMenu())
                    .Add("1", "Login", () =>
                    {
                        try
                        {
                            bool b = false;
                            if (sdk.Configuration.Credential == null)
                            {
                                string aUsername = cArgs.LoginUsername;
                                if (aUsername == String.Empty)
                                {
                                    Console.Write("Username? ");
                                    aUsername = Console.ReadLine()!.Trim();
                                }

                                string aPassword = cArgs.LoginPassword;
                                if (aPassword == String.Empty)
                                {
                                    Console.Write("Password? ");
                                    aPassword = Console.ReadLine()!.Trim();
                                }

                                b = sdk.LoginUser(aUsername, aPassword);
                            }
                            else
                                b = sdk.LoginUser();
                            if (!b)
                                throw new Exception("failed");

                            _LoginAccessToken = sdk.Configuration.TokenRepository.Token;
                            Console.WriteLine("Access Token: {0}", _LoginAccessToken);

                            //Connect to Lobby WS
                            Task connectTask = lobbyWs.Connect(false);
                            connectTask.Wait();

                            Task listenTask = Task.Run(() => lobbyWs.Listen());
                            isLobbyWSConnected = true;
                            Console.WriteLine("Lobby WS connected.");
                        }
                        catch (Exception x)
                        {
                            Console.WriteLine("Login error: {0}", x.Message);
                        }
                    })
                    .Add("2", "Title matchmaking", () =>
                    {
                        if (_LoginAccessToken == String.Empty)
                        {
                            Console.WriteLine("Please login first.");
                            return;
                        }

                        if (!isLobbyWSConnected)
                        {
                            Console.WriteLine("Lobby WS is not connected.");
                            return;
                        }

                        string url = cArgs.MatchmakingServerURL + "/";
                        HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, url);
                        req.Headers.TryAddWithoutValidation("Authorization", "Bearer " + _LoginAccessToken);

                        HttpResponseMessage resp = DefaultHttpClient.Http.Send(req);
                        Stream respStream = resp.Content.ReadAsStream();
                        string response = Helper.ConvertInputStreamToString(respStream);
                        Console.WriteLine("Response:\n{0}", response);
                    })
                    .AddExitItem("x", "Exit", true)
                    .Run();

                if (isLobbyWSConnected)
                {
                    Task disconnectTask = lobbyWs.Disconnect();
                    disconnectTask.Wait();
                }

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
                if ((lobbyWs != null) && isLobbyWSConnected)
                {
                    Task disconnectTask = lobbyWs.Disconnect();
                    disconnectTask.Wait();
                }
                return 2;
            }
        }
    }
}