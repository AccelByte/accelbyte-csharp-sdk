using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// DeleteServer
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SERVER [DELETE] Required
    /// scope: social This endpoint deletes a specified dedicated server from DB and
    /// terminates the DS pod.
    /// </summary>
    public class DeleteServer : AccelByte.Sdk.Core.Operation
    {
        public DeleteServer(
            string namespace_,            
            string podName            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;
            
            
            
            
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/servers/{podName}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}