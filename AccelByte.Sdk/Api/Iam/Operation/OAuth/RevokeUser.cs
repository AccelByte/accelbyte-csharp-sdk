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
    /// RevokeUser
    ///
    /// 
    /// 
    /// This endpoint requires all requests to have authorization header set with bearer token.
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// The endpoint revokes all access tokens and refresh tokens a user has prior the revocation time. It is a convenient feature for the developer (or admin) who wanted to revokes all user's access tokens and refresh tokens generated before some period of time.
    /// </summary>
    public class RevokeUser : AccelByte.Sdk.Core.Operation
    {
        public RevokeUser(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/oauth/namespaces/{namespace}/users/{userId}/revoke";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}