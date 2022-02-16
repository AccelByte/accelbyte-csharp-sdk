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
    /// adminPostPlayerPublicRecordHandlerV1
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:PUBLIC:CLOUDSAVE:RECORD [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// Save a record (arbitrary JSON data) in user-level.
    /// If a record already exist with given record key, this endpoint will try to merge.
    /// Same top level key inside body will be replaced, different top level key will be appended.
    /// Record saved will be a public record.
    /// If existing record is not public (is_public false) then this endpoint won't make it public.
    /// </summary>
    public class AdminPostPlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        public AdminPostPlayerPublicRecordHandlerV1(
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

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}