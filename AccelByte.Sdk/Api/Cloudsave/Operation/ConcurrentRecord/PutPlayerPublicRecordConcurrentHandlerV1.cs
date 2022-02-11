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
    /// Required Permission |
    /// `NAMESPACE:{namespace}:USER:{userId}:PUBLIC:CLOUDSAVE:RECORD [UPDATE]`
    /// ---|---
    /// Required Scope | `social`
    /// 
    /// If the record is not exist, it will create. If the record already exist, it
    /// will replace the record instead. And this operation can only be applied to
    /// record with `isPublic=true`. Example Replace record
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
    /// 
    /// 
    /// Optimistic Concurrency Control
    /// This endpoint implement optimistic concurrency control to avoid race
    /// condition. If the record has been updated since the client fetch it, the
    /// server will return HTTP status code 412 (precondition failed) and client need
    /// to redo the operation (fetch data and do update). Otherwise, the server will
    /// process the request.
    /// </summary>
    public class PutPlayerPublicRecordConcurrentHandlerV1 : AccelByte.Sdk.Core.Operation
    {
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