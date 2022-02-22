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
    /// sendPartyFreeformNotificationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Sends notification to a party.
    /// </summary>
    public class SendPartyFreeformNotificationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SendPartyFreeformNotificationV1AdminBuilder Builder = new SendPartyFreeformNotificationV1AdminBuilder();

        public class SendPartyFreeformNotificationV1AdminBuilder
        {
            
            
            
            internal SendPartyFreeformNotificationV1AdminBuilder() { }





            public SendPartyFreeformNotificationV1Admin Build(
                ModelFreeFormNotificationRequestV1 body,
                string namespace_,
                string partyId
            )
            {
                return new SendPartyFreeformNotificationV1Admin(this,
                    body,                    
                    namespace_,                    
                    partyId                    
                );
            }
        }

        private SendPartyFreeformNotificationV1Admin(SendPartyFreeformNotificationV1AdminBuilder builder,
            ModelFreeFormNotificationRequestV1 body,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public SendPartyFreeformNotificationV1Admin(
            string namespace_,            
            string partyId,            
            Model.ModelFreeFormNotificationRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/parties/{partyId}/freeform/notify";

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