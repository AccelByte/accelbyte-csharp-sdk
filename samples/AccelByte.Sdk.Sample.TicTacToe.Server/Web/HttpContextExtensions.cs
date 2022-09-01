// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading.Tasks;
using System.Text.Json;

using Microsoft.AspNetCore.Http;

namespace AccelByte.Sdk.Sample.TicTacToe.Server.Web
{
    public static class HttpContextExtensions
    {
        public static async Task ResponseWithJSON(this HttpContext context, object data, int statusCode = 200)
        {
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(JsonSerializer.Serialize(data));
        }

        public static async Task ResponseWithText(this HttpContext context, string text, int statusCode = 200)
        {
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "text/plain";
            await context.Response.WriteAsync(text);
        }
    }
}