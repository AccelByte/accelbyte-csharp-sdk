using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// postPlayerPublicRecordHandlerV1
    ///
    /// Required Permission |
    /// `NAMESPACE:{namespace}:USER:{userId}:PUBLIC:CLOUDSAVE:RECORD [WRITE]`
    /// ---|---
    /// Required Scope | `social`
    /// 
    /// This endpoint will create or update player record with `isPublic=true` meaning
    /// that the record will be available for other player to be retrieved. Other
    /// player can only retrieve the record and not create, update or even delete.
    /// This endpoint will create public player record if it is not exists otherwise
    /// merge with these criteria: - If field name is already exists, replace the
    /// value - If field name is not exists, append it Example Replace value:
    /// 
    /// 
    /// 
    ///         // existed record
    ///         {
    ///             "foo": "bar"
    ///         }
    /// 
    ///         // new record (request body)
    ///         {
    ///             "foo": "bar_updated"
    ///         }
    /// 
    ///         // result
    ///         {
    ///             "foo": "bar_updated"
    ///         }
    /// 
    /// 
    /// Append value:
    /// 
    /// 
    /// 
    ///         // existed record
    ///         {
    ///             "foo": "bar"
    ///         }
    /// 
    ///         // new record (request body)
    ///         {
    ///             "foo_new": "bar_new"
    ///         }
    /// 
    ///         // result
    ///         {
    ///             "foo": "bar",
    ///             "foo_new": "bar_new"
    ///         }
    /// </summary>
    public class PostPlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        public PostPlayerPublicRecordHandlerV1(
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

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public";

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