using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class DeleteClientPermission : AccelByte.Sdk.Core.Operation
    {
        public DeleteClientPermission(
            long action,            
            string clientId,            
            string resource            
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["resource"] = resource;
            
            
            
            
        }

        public override string Path => "/iam/clients/{clientId}/clientpermissions/{resource}/{action}";

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