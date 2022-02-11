using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// getPlayerPublicRecordHandlerV1
    ///
    /// Required Permission |
    /// `NAMESPACE:{namespace}:USER:{userId}:PUBLIC:CLOUDSAVE:RECORD [READ]`
    /// ---|---
    /// Required Scope | `social`
    /// 
    /// Get other player's record that is public. Only record with `isPublic=true`
    /// that can be retrieved using this endpoint.
    /// </summary>
    public class GetPlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        public GetPlayerPublicRecordHandlerV1(
            string key,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPlayerRecord? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecord>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecord>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}