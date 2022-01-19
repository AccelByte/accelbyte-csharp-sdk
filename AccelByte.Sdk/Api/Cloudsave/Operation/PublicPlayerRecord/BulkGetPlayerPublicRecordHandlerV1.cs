using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    public class BulkGetPlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        public BulkGetPlayerPublicRecordHandlerV1(
            string key,            
            string namespace_,            
            Model.ModelsBulkUserIDsRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/bulk/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsBulkGetPlayerRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}