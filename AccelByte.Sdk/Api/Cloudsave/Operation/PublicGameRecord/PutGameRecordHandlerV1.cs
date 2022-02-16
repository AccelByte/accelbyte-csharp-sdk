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
    /// putGameRecordHandlerV1
    ///
    /// Required Permission | `NAMESPACE:{namespace}:CLOUDSAVE:RECORD [UPDATE]`
    /// --------------------|---------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// If record already exists, it will be replaced with the one from request body (all fields will be
    /// deleted). If record is not exists, it will create a new one with value from request body.
    /// 
    /// Example:
    /// 
    /// Replace all records
    /// 
    /// 
    /// 
    /// 
    ///         // existed record
    ///         {
    ///             "foo": "bar"
    ///         }
    /// 
    ///         // new update (request body)
    ///         {
    ///             "foo_new": "bar_new"
    ///         }
    /// 
    ///         // result
    ///         {
    ///             "foo_new": "bar_new"
    ///         }
    /// </summary>
    public class PutGameRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        public PutGameRecordHandlerV1(
            string key,            
            string namespace_,            
            Model.ModelsGameRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/records/{key}";

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