using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    public class QueryEventStreamHandler : AccelByte.Sdk.Core.Operation
    {
        public QueryEventStreamHandler(
            string namespace_,            
            string? endDate,            
            double? offset,            
            double? pageSize,            
            string? startDate,            
            Model.ModelsGenericQueryPayload body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (endDate != null) QueryParams["endDate"] = endDate;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (pageSize != null) QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/event/v2/admin/namespaces/{namespace}/query";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsEventResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponseV2>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}