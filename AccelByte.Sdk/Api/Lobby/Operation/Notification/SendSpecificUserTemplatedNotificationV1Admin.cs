using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// sendSpecificUserTemplatedNotificationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [CREATE]` with
    /// scope `social`
    /// Sends templated notification to a user.
    /// In the request body, specify which template slug (template identifier) to use
    /// and the template language.
    /// NotificationTemplate context is the key-value pair defining the value of each
    /// handlebar specified in the template content. Template need to be published
    /// before it can be use to send notifications
    /// Action Code: 50212
    /// </summary>
    public class SendSpecificUserTemplatedNotificationV1Admin : AccelByte.Sdk.Core.Operation
    {
        public SendSpecificUserTemplatedNotificationV1Admin(
            string namespace_,            
            string userId,            
            Model.ModelNotificationWithTemplateRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/users/{userId}/templates/notify";

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