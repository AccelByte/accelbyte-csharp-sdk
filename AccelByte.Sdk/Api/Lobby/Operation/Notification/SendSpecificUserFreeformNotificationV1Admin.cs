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
    /// sendSpecificUserFreeformNotificationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Sends notification to a user.
    /// Action Code: 50211
    /// </summary>
    public class SendSpecificUserFreeformNotificationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SendSpecificUserFreeformNotificationV1AdminBuilder Builder = new SendSpecificUserFreeformNotificationV1AdminBuilder();

        public class SendSpecificUserFreeformNotificationV1AdminBuilder
            : OperationBuilder<SendSpecificUserFreeformNotificationV1AdminBuilder>
        {
            
            
            
            internal SendSpecificUserFreeformNotificationV1AdminBuilder() { }





            public SendSpecificUserFreeformNotificationV1Admin Build(
                ModelFreeFormNotificationRequestV1 body,
                string namespace_,
                string userId
            )
            {
                SendSpecificUserFreeformNotificationV1Admin op = new SendSpecificUserFreeformNotificationV1Admin(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SendSpecificUserFreeformNotificationV1Admin(SendSpecificUserFreeformNotificationV1AdminBuilder builder,
            ModelFreeFormNotificationRequestV1 body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SendSpecificUserFreeformNotificationV1Admin(
            string namespace_,            
            string userId,            
            Model.ModelFreeFormNotificationRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/users/{userId}/freeform/notify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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