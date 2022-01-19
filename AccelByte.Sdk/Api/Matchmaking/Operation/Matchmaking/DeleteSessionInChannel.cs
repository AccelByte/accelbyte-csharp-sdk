using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    public class DeleteSessionInChannel : AccelByte.Sdk.Core.Operation
    {
        public DeleteSessionInChannel(
            string channelName,            
            string matchID,            
            string namespace_            
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}";

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