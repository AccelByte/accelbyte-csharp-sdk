using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    public class JoinSession : AccelByte.Sdk.Core.Operation
    {
        public JoinSession(
            string namespace_,            
            string sessionID,            
            Model.ModelsJoinGameSessionRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/join";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}