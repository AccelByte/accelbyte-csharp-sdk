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
    /// ListCrossNamespaceAccountLink
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated at 9 July, 2018. Please use this instead: /users/{userId}/platforms/{platformId}/link
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'NAMESPACE:{namespace}:USER:{userId} [UPDATE]'.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Access token from original namespace is needed as authorization header. Access token from designated account needed as form parameter to verify the ownership of that account.
    /// When platformID (device platfom ID) is specified, platform login method for that specific platform ID is removed.
    /// This means to protect account from second hand device usage.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class ListCrossNamespaceAccountLink : AccelByte.Sdk.Core.Operation
    {
        public ListCrossNamespaceAccountLink(
            string namespace_,            
            string userId,            
            string? platformId,            
            string linkingToken            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (platformId != null) FormParams["platformId"] = platformId;
            if (linkingToken != null) FormParams["linkingToken"] = linkingToken;
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/crosslink";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

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