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
    /// AdminGetUserByPlatformUserIDV3
    ///
    /// Get User By Platform User ID
    /// 
    /// This endpoint return user information by given platform ID and platform user ID
    /// 
    /// nintendo platform user ID : NSA ID need to be appended with Environment ID using colon as separator. e.g kmzwa8awaa:dd1
    /// </summary>
    public class AdminGetUserByPlatformUserIDV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminGetUserByPlatformUserIDV3(
            string namespace_,            
            string platformId,            
            string platformUserId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["platformUserId"] = platformUserId;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/users/{platformUserId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}