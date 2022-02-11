using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// GetEventByEventTypeAndEventIDHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]`and scope
    /// `analytics`
    /// </summary>
    public class GetEventByEventTypeAndEventIDHandler : AccelByte.Sdk.Core.Operation
    {
        public GetEventByEventTypeAndEventIDHandler(
            double eventId,            
            double eventType,            
            string namespace_,            
            double? offset,            
            string endDate,            
            double pageSize,            
            string startDate            
        )
        {
            PathParams["eventId"] = Convert.ToString(eventId);
            PathParams["eventType"] = Convert.ToString(eventType);
            PathParams["namespace"] = namespace_;
            
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate != null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            
        }

        public override string Path => "/event/namespaces/{namespace}/eventType/{eventType}/eventId/{eventId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsEventResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}