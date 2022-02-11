using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CountSession
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SESSION [READ] Required
    /// scope: social This endpoint count all of sessions in a namespace managed by
    /// this service.
    /// </summary>
    public class CountSession : AccelByte.Sdk.Core.Operation
    {
        public CountSession(
            string namespace_,            
            string? region            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (region != null) QueryParams["region"] = region;
            
            
            
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/sessions/count";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsCountSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCountSessionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}