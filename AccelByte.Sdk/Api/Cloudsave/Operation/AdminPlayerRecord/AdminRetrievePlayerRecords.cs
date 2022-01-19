using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    public class AdminRetrievePlayerRecords : AccelByte.Sdk.Core.Operation
    {
        public AdminRetrievePlayerRecords(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListPlayerRecordKeys? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeys>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}