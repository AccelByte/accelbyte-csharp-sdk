using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// GetClients
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated at 10 August, 2018. Please use this
    /// instead: namespaces/{namespace}/clients
    /// 
    /// Required permission 'CLIENT [READ]'
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetClients : AccelByte.Sdk.Core.Operation
    {
        public GetClients(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/clients";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ClientmodelClientResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ClientmodelClientResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ClientmodelClientResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}