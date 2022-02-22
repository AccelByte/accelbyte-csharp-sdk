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
    /// VerifyToken
    ///
    /// This endpoint requires all requests to have Authorization header set with Basic access authentication constructed from client id and client secret.
    /// </summary>
    public class VerifyToken : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static VerifyTokenBuilder Builder = new VerifyTokenBuilder();

        public class VerifyTokenBuilder
        {
            
            internal VerifyTokenBuilder() { }





            public VerifyToken Build(
                string token
            )
            {
                return new VerifyToken(this,
                    token                    
                );
            }
        }

        private VerifyToken(VerifyTokenBuilder builder,
            string token
        )
        {
            
            
            if (token != null) FormParams["token"] = token;
            
            
            
        }
        #endregion

        public VerifyToken(
            string token            
        )
        {
            
            
            if (token != null) FormParams["token"] = token;
            
            
            
        }

        public override string Path => "/iam/oauth/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OauthmodelTokenResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}