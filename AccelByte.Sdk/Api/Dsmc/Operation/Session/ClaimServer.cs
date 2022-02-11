using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// ClaimServer
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:SESSION [UPDATE] Required
    /// scope: social This endpoint is intended to be called by game session manager
    /// (matchmaker, lobby, etc.) to claim a dedicated server. The dedicated server
    /// cannot be claimed unless the status is READY
    /// </summary>
    public class ClaimServer : AccelByte.Sdk.Core.Operation
    {
        public ClaimServer(
            string namespace_,            
            Model.ModelsClaimSessionRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/sessions/claim";

        public override HttpMethod Method => HttpMethod.Post;

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