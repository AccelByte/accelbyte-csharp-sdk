using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    public class GetEventByUserIDHandler : AccelByte.Sdk.Core.Operation
    {
        public GetEventByUserIDHandler(
            string namespace_,            
            string userId,            
            double? offset,            
            string endDate,            
            double pageSize,            
            string startDate            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate != null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            
        }

        public override string Path => "/event/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsEventResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}