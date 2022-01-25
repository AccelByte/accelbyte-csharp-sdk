using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    public class GetEventByEventIDHandler : AccelByte.Sdk.Core.Operation
    {
        public GetEventByEventIDHandler(
            double eventId,            
            string namespace_,            
            double? offset,            
            string endDate,            
            double pageSize,            
            string startDate            
        )
        {
            PathParams["eventId"] = Convert.ToString(eventId);
            PathParams["namespace"] = namespace_;
            
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate != null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            
        }

        public override string Path => "/event/namespaces/{namespace}/eventId/{eventId}";

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