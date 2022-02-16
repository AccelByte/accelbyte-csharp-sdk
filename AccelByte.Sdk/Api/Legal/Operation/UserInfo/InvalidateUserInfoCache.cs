// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// invalidateUserInfoCache
    ///
    ///  Important: GOING TO DEPRECATE
    /// 
    /// Invalidate user info cache in agreement service.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=8 (DELETE)
    /// </summary>
    public class InvalidateUserInfoCache : AccelByte.Sdk.Core.Operation
    {
        public InvalidateUserInfoCache(
            string? namespace_            
        )
        {
            
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/agreement/admin/userInfo";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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