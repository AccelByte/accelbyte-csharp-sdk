using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// deleteTopicByTopicName
    ///
    /// Required permission : `NAMESPACE:{namespace}:TOPIC [DELETE]` with scope
    /// `social`
    /// delete topic information by topic name.
    /// topic should be alphabets, no special char except underscore, uppercase and no
    /// spacing. for example: TOPIC_TEST. Already existing topic can not be created
    /// </summary>
    public class DeleteTopicByTopicName : AccelByte.Sdk.Core.Operation
    {
        public DeleteTopicByTopicName(
            string namespace_,            
            string topic            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            
            
            
            
        }

        public override string Path => "/notification/namespaces/{namespace}/topics/{topic}";

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