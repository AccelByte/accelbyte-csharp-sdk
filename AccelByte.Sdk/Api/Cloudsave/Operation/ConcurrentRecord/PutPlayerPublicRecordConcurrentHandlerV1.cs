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
    /// putPlayerPublicRecordConcurrentHandlerV1
    ///
    /// Required Permission | `NAMESPACE:{namespace}:USER:{userId}:PUBLIC:CLOUDSAVE:RECORD [UPDATE]`
    /// --------------------|------------------------------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Description
    /// 
    /// 
    /// 
    /// This endpoints will create new player public record or replace the existing player public record.
    /// 
    ///  Replace behaviour:
    /// The existing value will be replaced completely with the new value.
    /// 
    /// Example
    /// - Existing JSON:
    /// 
    /// 
    /// 
    ///     { "data1": "value" }
    /// 
    /// 
    /// - New JSON:
    /// 
    /// 
    /// 
    ///     { "data2": "new value" }
    /// 
    /// 
    /// - Result:
    /// 
    /// 
    /// 
    ///     { "data2": "new value" }
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Reserved Word
    /// 
    /// 
    /// 
    /// Reserved Word List: META
    /// 
    /// The reserved word cannot be used as a field in record value,
    /// If still defining the field when creating or updating the record, it will be ignored.
    /// 
    /// 
    /// 
    /// 
    /// ## Warning: Current Behaviour when Updating Private Record
    /// 
    /// 
    /// 
    /// When updating existing "Private Record", this endpoint will always convert the "Private Record" into "Public Record".
    /// This behaviour might be deprecated sooner, please don't rely with that behaviour.
    /// 
    /// 
    /// 
    /// ## Optimistic Concurrency Control
    /// 
    /// 
    /// 
    /// This endpoint implement optimistic concurrency control to avoid race condition.
    /// If the record has been updated since the client fetch it, the server will return HTTP status code 412 (precondition failed)
    /// and client need to redo the operation (fetch data and do update).
    /// Otherwise, the server will process the request.
    /// </summary>
    public class PutPlayerPublicRecordConcurrentHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PutPlayerPublicRecordConcurrentHandlerV1Builder Builder = new PutPlayerPublicRecordConcurrentHandlerV1Builder();

        public class PutPlayerPublicRecordConcurrentHandlerV1Builder
        {
            
            
            
            
            internal PutPlayerPublicRecordConcurrentHandlerV1Builder() { }





            public PutPlayerPublicRecordConcurrentHandlerV1 Build(
                ModelsConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                return new PutPlayerPublicRecordConcurrentHandlerV1(this,
                    body,                    
                    key,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PutPlayerPublicRecordConcurrentHandlerV1(PutPlayerPublicRecordConcurrentHandlerV1Builder builder,
            ModelsConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public PutPlayerPublicRecordConcurrentHandlerV1(
            string key,            
            string namespace_,            
            string userId,            
            Model.ModelsConcurrentRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/concurrent/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Put;

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