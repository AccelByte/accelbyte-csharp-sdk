using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// getPersonalChatHistoryV1Public
    ///
    /// Required valid user authorization
    /// 
    /// load personal chat history in a namespace based on Friend User ID
    /// Action Code: 50101
    /// </summary>
    public class GetPersonalChatHistoryV1Public : AccelByte.Sdk.Core.Operation
    {
        public GetPersonalChatHistoryV1Public(
            string friendId,            
            string namespace_            
        )
        {
            PathParams["friendId"] = friendId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/lobby/v1/public/chat/namespaces/{namespace}/users/me/friends/{friendId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelChatMessageResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelChatMessageResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelChatMessageResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}