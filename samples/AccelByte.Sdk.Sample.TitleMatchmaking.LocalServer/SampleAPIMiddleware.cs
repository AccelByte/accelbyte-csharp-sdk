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

namespace AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer
{
    public class SampleAPIMiddleware
    {
        private readonly RequestDelegate _Next;

        private readonly AccelByteSDK _Sdk;

        private readonly ICacheProvider _Cache;

        public SampleAPIMiddleware(RequestDelegate next, IAccelByteSdkProvider sdkProvider, ICacheProvider cacheProvider)
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
                if (route == "GET /")
                {
                    context.Response.StatusCode = 200;
                    context.Response.ContentType = "text/plain";
                    await context.Response.WriteAsync("PONG");
                }
                else if (route == "POST /")
                {
                    if (!context.Request.Headers.ContainsKey("Authorization"))
                        throw new APIException("not authorized", 0, 401);
                    string[] authzValues = context.Request.Headers.GetCommaSeparatedValues("Authorization");
                    if (authzValues.Length <= 0)
                        throw new APIException("empty authorization", 0, 401);
                    string authzValue = authzValues[0].Trim();
                    if (authzValue == String.Empty)
                        throw new APIException("empty authorization", 0, 401);

                    string[] authzParts = authzValue.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                    if (authzParts.Length < 2)
                        throw new APIException("invalid authorization", 0, 401);

                    _Sdk.LoginClient();

                    Matchmaker mm = new Matchmaker(_Sdk, _Cache, "csharp_tm_gm_");
                    MatchmakingResult mResult = mm.CreateMatchmakingRequest(authzParts[1]);

                    if (!mResult.IsFirstMember)
                    {
                        Task t = Task.Run(() =>
                        {
                            mm.CreateSessionAndClaimServer(mResult);
                        });
                    }

                    context.Response.StatusCode = 200;
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(JsonSerializer.Serialize(mResult));
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

                    context.Response.StatusCode = 200;
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync("{\"AccessToken\":\"" + _Sdk.Configuration.TokenRepository.Token + "\"}");

                }
                else if (route == "GET /status")
                {
                    Matchmaker mm = new Matchmaker(_Sdk, _Cache, "csharp_tm_gm_");
                    string response = mm.GetMatchmakingStatus();

                    context.Response.StatusCode = 200;
                    context.Response.ContentType = "application/json";
                    await context.Response.WriteAsync(response);
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