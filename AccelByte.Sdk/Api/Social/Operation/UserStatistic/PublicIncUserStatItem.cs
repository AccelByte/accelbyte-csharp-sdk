// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicIncUserStatItem
    ///
    /// Public update user's statitem value.
    /// Other detail info:
    ///                   *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    ///                   *  Returns : updated user's statItem
    /// </summary>
    public class PublicIncUserStatItem : AccelByte.Sdk.Core.Operation
    {
        public PublicIncUserStatItem(
            string namespace_,            
            string statCode,            
            string userId,            
            Model.StatItemInc body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.StatItemIncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}