using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// CreateChannelHandler
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [CREATE]
    /// Required Scope: social Creates a new matchmaking channel. Matchmaking channels
    /// is a list of pool name that is eligible for matchmaking processes. GameMode
    /// isolates each matchmaking pools. If match timeout is set to 0, by default,
    /// incoming matchmaking requests will be timed out after 1 hour. If max worker
    /// delay is set to 0, by default, it will wait for at max ~8 seconds during low
    /// volume. Rule Set Matching Rule used to classify the player. Player that has
    /// matched criteria will be grouped together within an ally. Valid value for
    /// criteria is "distance"
    /// </summary>
    public class CreateChannelHandler : AccelByte.Sdk.Core.Operation
    {
        public CreateChannelHandler(
            string namespace_,            
            Model.ModelsChannelRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/channels";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsCreateChannelResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateChannelResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateChannelResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}