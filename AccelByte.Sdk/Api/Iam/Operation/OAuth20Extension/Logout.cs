// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// Logout
    ///
    /// 
    /// 
    /// This endpoint is used to remove access_token cookie and refresh_token cookie.
    /// </summary>
    public class Logout : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LogoutBuilder Builder = new LogoutBuilder();

        public class LogoutBuilder
        {
            internal LogoutBuilder() { }





            public Logout Build(
            )
            {
                return new Logout(this
                );
            }
        }

        private Logout(LogoutBuilder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public Logout(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/v3/logout";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "*/*" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}