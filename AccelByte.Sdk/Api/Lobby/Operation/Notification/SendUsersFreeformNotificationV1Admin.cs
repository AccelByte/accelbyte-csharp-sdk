// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// sendUsersFreeformNotificationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Sends notification to all connected users in a namespace.
    /// 
    /// Action Code: 50201
    /// </summary>
    public class SendUsersFreeformNotificationV1Admin : AccelByte.Sdk.Core.Operation
    {
        public SendUsersFreeformNotificationV1Admin(
            string namespace_,            
            Model.ModelFreeFormNotificationRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/freeform/notify";

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