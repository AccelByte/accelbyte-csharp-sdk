// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// putPlayerRecordHandlerV1
    ///
    /// Required Permission | `NAMESPACE:{namespace}:USER:{userId}:CLOUDSAVE:RECORD [UPDATE]`
    /// --------------------|-----------------------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will create new record if it is not exists and it will replace if already exists.
    /// 
    /// Example
    /// 
    /// Replace record
    /// 
    /// 
    /// 
    /// 
    ///     // existed record
    ///     {
    ///         "foo": "bar"
    ///     }
    /// 
    ///     // new record (request body)
    ///     {
    ///         "foo_new": "bar_new"
    ///     }
    /// 
    ///     // result
    ///     {
    ///         "foo_new": "bar_new"
    ///     }
    /// </summary>
    public class PutPlayerRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        public PutPlayerRecordHandlerV1(
            string key,            
            string namespace_,            
            string userId,            
            Model.ModelsPlayerRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}";

        public override HttpMethod Method => HttpMethod.Put;

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