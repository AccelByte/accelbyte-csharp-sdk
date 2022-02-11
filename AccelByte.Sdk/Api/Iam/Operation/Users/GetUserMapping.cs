using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// GetUserMapping
    ///
    /// 
    /// 
    /// This endpoint requires the client access token as the bearer token. Required
    /// permission 'ADMIN:NAMESPACE:{namespace}:JUSTICE:USER:{userId} [READ]'
    /// 
    /// This endpoint will support publisher access to game and game access to
    /// publisher
    /// 
    /// If targetNamespace filled with publisher namespace then this endpoint will
    /// return its game user id and game namespace
    /// 
    /// If targetNamespace filled with game namespace then this endpoint will return
    /// its publisher user id and publisher namespace
    /// </summary>
    public class GetUserMapping : AccelByte.Sdk.Core.Operation
    {
        public GetUserMapping(
            string namespace_,            
            string targetNamespace,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["targetNamespace"] = targetNamespace;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetUserMapping? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserMapping>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserMapping>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}