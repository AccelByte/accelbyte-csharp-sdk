// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminCancelUserPersonalDataRequest
    ///
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:INFORMATION:USER:{userId} [DELETE]` and scope `account`
    /// </summary>
    public class AdminCancelUserPersonalDataRequest : AccelByte.Sdk.Core.Operation
    {
        public AdminCancelUserPersonalDataRequest(
            string namespace_,            
            string requestDate,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestDate"] = requestDate;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/requests/{requestDate}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

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