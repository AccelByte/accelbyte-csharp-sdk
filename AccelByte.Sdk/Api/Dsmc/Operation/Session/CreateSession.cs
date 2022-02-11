using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// CreateSession
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:SESSION [CREATE] Required
    /// scope: social This endpoint is intended to be called by game session manager
    /// (matchmaker, lobby, etc.) to get a dedicated server for a game session. If a
    /// dedicated server is available, it will respond with a dedicated server details
    /// ready to be used. Otherwise it will trigger new dedicated server creation and
    /// respond with a server status CREATING. The game session manager then expected
    /// to wait and query the server readiness with GET
    /// /namespaces/{namespace}/sessions/{sessionID} endpoint until the serverstatus
    /// is READY Specify pod_name with name of local DS in the request to create a
    /// session using the registered local DS
    /// </summary>
    public class CreateSession : AccelByte.Sdk.Core.Operation
    {
        public CreateSession(
            string namespace_,            
            Model.ModelsCreateSessionRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/sessions";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}