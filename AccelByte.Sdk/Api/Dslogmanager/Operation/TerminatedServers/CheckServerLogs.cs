using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dslogmanager.Operation
{
    public class CheckServerLogs : AccelByte.Sdk.Core.Operation
    {
        public CheckServerLogs(
            string namespace_,            
            string podName            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;
            
            
            
            
            
        }

        public override string Path => "/dslogmanager/namespaces/{namespace}/servers/{podName}/logs/exists";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json","text/x-log" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsLogFileStatus? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsLogFileStatus>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}