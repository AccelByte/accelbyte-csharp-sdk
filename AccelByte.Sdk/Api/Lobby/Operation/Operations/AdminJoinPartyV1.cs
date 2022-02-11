using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminJoinPartyV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PARTY:STORAGE [UPDATE]`
    /// with scope `social`
    /// admin join a player into a party.
    /// </summary>
    public class AdminJoinPartyV1 : AccelByte.Sdk.Core.Operation
    {
        public AdminJoinPartyV1(
            string namespace_,            
            string partyId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/join/{userId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}