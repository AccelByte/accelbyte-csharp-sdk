using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// DeleteServer
    ///
    /// ``` Required permission: ADMIN:QOS:SERVER [DELETE] Required scope: social This
    /// endpoint delete a registered QoS service record. ```
    /// </summary>
    public class DeleteServer : AccelByte.Sdk.Core.Operation
    {
        public DeleteServer(
            string region            
        )
        {
            PathParams["region"] = region;
            
            
            
            
            
        }

        public override string Path => "/qosm/admin/servers/{region}";

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