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

using Microsoft.AspNetCore.Http;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Sample.TicTacToe;
using AccelByte.Sdk.Sample.TicTacToe.Web;
using AccelByte.Sdk.Sample.TicTacToe.Provider;
using AccelByte.Sdk.Sample.TicTacToe.Model;

namespace AccelByte.Sdk.Sample.TicTacToe.Server.Web
{
    public class APIMiddleware
    {
        private readonly RequestDelegate _Next;

        private readonly AccelByteSDK _Sdk;

        private readonly ICacheProvider _Cache;

        public APIMiddleware(RequestDelegate next, IAccelByteSdkProvider sdkProvider, ICacheProvider cacheProvider)
        {
            _Next = next;
            _Sdk = sdkProvider.Sdk;
            _Cache = cacheProvider;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                string route = (context.Request.Method.ToUpper() + " " + context.Request.Path);
                string authBearer = String.Empty;

                if (context.Request.Headers.ContainsKey("Authorization"))
                {
                    string[] authzValues = context.Request.Headers.GetCommaSeparatedValues("Authorization");
                    if (authzValues.Length > 0)
                    {
                        string authzValue = authzValues[0].Trim();
                        string[] authzParts = authzValue.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                        if (authzParts.Length >= 2)
                            authBearer = authzParts[1].Trim();
                    }
                }

                if (route == "GET /ping")
                {
                    await context.ResponseWithText("PONG");
                }
                else if (route == "GET /matches")
                {
                    if (authBearer == String.Empty)
                        throw new APIException("not authorized", 0, 403);

                    _Sdk.LoginClient();
                    TicTacToeServer t3 = new TicTacToeServer(_Sdk, _Cache);

                    List<MatchItem> matches = t3.GetActiveMatches();
                    await context.ResponseWithJSON(matches, 200);
                }
                else if (route == "POST /match/start")
                {
                    if (authBearer == String.Empty)
                        throw new APIException("not authorized", 0, 403);

                    _Sdk.LoginClient();
                    TicTacToeServer t3 = new TicTacToeServer(_Sdk, _Cache);
                    string userId = t3.ValidateAuthToken(authBearer);

                    NewGameResult result = t3.NewGame(userId);
                    await context.ResponseWithJSON(result, 200);
                }
                else if (route == "POST /match/join")
                {
                    if (authBearer == String.Empty)
                        throw new APIException("not authorized", 0, 403);

                    string match_id = String.Empty;
                    if (context.Request.Form.ContainsKey("match_id"))
                        match_id = context.Request.Form["match_id"].ToString().Trim();
                    if (match_id == String.Empty)
                        throw new APIException("unspecified match id", 0, 400);

                    _Sdk.LoginClient();
                    TicTacToeServer t3 = new TicTacToeServer(_Sdk, _Cache);
                    string userId = t3.ValidateAuthToken(authBearer);

                    NewGameResult result = t3.JoinGame(userId, match_id);
                    await context.ResponseWithJSON(result, 200);
                }
                else if (route == "POST /match/move")
                {
                    if (authBearer == String.Empty)
                        throw new APIException("not authorized", 0, 403);

                    string match_id = String.Empty;
                    if (context.Request.Form.ContainsKey("match_id"))
                        match_id = context.Request.Form["match_id"].ToString().Trim();
                    if (match_id == String.Empty)
                        throw new APIException("unspecified match id", 0, 400);

                    string s_row = String.Empty;
                    if (context.Request.Form.ContainsKey("row"))
                        s_row = context.Request.Form["row"].ToString().Trim();
                    int row = -1;
                    if (!int.TryParse(s_row, out row))
                        throw new APIException("invalid row value", 0, 400);

                    string s_col = String.Empty;
                    if (context.Request.Form.ContainsKey("column"))
                        s_col = context.Request.Form["column"].ToString().Trim();
                    int col = -1;
                    if (!int.TryParse(s_col, out col))
                        throw new APIException("invalid column value", 0, 400);

                    _Sdk.LoginClient();
                    TicTacToeServer t3 = new TicTacToeServer(_Sdk, _Cache);
                    string userId = t3.ValidateAuthToken(authBearer);

                    t3.Move(userId, match_id, row, col);

                    await context.ResponseWithText("", 204);
                }
                else if (route == "POST /login")
                {
                    string aUsername = String.Empty;
                    if (context.Request.Form.ContainsKey("username"))
                        aUsername = context.Request.Form["username"].ToString();
                    string aPassword = String.Empty;
                    if (context.Request.Form.ContainsKey("password"))
                        aPassword = context.Request.Form["password"].ToString();

                    if (!_Sdk.LoginUser(aUsername, aPassword))
                        throw new APIException("Invalid login", 0, 401);

                    await context.ResponseWithJSON(new LoginResponse()
                    {
                        AccessToken = _Sdk.Configuration.TokenRepository.Token
                    });
                }
                else if (route == "POST /notif/send")
                {
                    if (authBearer == String.Empty)
                        throw new APIException("not authorized", 0, 403);

                    string target_user_id = String.Empty;
                    if (context.Request.Form.ContainsKey("target_user_id"))
                        target_user_id = context.Request.Form["target_user_id"].ToString().Trim();
                    if (target_user_id == String.Empty)
                        throw new APIException("unspecified target user id", 0, 400);

                    string topic = String.Empty;
                    if (context.Request.Form.ContainsKey("topic"))
                        topic = context.Request.Form["topic"].ToString().Trim();
                    if (topic == String.Empty)
                        throw new APIException("unspecified topic", 0, 400);

                    string strPayload = String.Empty;
                    if (context.Request.Form.ContainsKey("payload"))
                        strPayload = context.Request.Form["payload"].ToString().Trim();
                    if (strPayload == String.Empty)
                        throw new APIException("unspecified payload", 0, 400);

                    _Sdk.LoginClient();
                    TicTacToeServer t3 = new TicTacToeServer(_Sdk, _Cache);
                    t3.SendNotificationToUser(target_user_id, topic, strPayload);

                    await context.ResponseWithText(strPayload, 200);
                }
                else
                {
                    context.Response.StatusCode = 404;
                    context.Response.ContentType = "text/plain";
                    await context.Response.WriteAsync("NOT FOUND");
                }
            }
            catch (APIException ex)
            {
                context.Response.StatusCode = ex.StatusCode;
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync(ex.Message);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync(ex.Message);
            }            
        }
    }
}