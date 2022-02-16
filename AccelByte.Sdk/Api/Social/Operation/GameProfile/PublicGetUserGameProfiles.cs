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
    /// publicGetUserGameProfiles
    ///
    /// Returns all profiles for specified users.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:GAMEPROFILE", action=2 (READ)
    /// 
    ///         *  Returns : list of profiles
    /// </summary>
    public class PublicGetUserGameProfiles : AccelByte.Sdk.Core.Operation
    {
        public PublicGetUserGameProfiles(
            string namespace_,            
            List<string> userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (userIds != null) QueryParams["userIds"] = userIds;
            
            
            CollectionFormatMap["userIds"] = "multi";
            
            
        }

        public override string Path => "/social/public/namespaces/{namespace}/profiles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.UserGameProfiles>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserGameProfiles>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserGameProfiles>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}