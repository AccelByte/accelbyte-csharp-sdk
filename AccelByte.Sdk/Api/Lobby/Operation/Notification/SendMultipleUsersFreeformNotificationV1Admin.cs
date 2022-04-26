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
    /// sendMultipleUsersFreeformNotificationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Sends notification to multiple user.
    /// Action Code: 50211
    /// </summary>
    public class SendMultipleUsersFreeformNotificationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SendMultipleUsersFreeformNotificationV1AdminBuilder Builder = new SendMultipleUsersFreeformNotificationV1AdminBuilder();

        public class SendMultipleUsersFreeformNotificationV1AdminBuilder
            : OperationBuilder<SendMultipleUsersFreeformNotificationV1AdminBuilder>
        {
            
            
            internal SendMultipleUsersFreeformNotificationV1AdminBuilder() { }






            public SendMultipleUsersFreeformNotificationV1Admin Build(
                ModelBulkUsersFreeFormNotificationRequestV1 body,
                string namespace_
            )
            {
                SendMultipleUsersFreeformNotificationV1Admin op = new SendMultipleUsersFreeformNotificationV1Admin(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SendMultipleUsersFreeformNotificationV1Admin(SendMultipleUsersFreeformNotificationV1AdminBuilder builder,
            ModelBulkUsersFreeFormNotificationRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SendMultipleUsersFreeformNotificationV1Admin(
            string namespace_,            
            Model.ModelBulkUsersFreeFormNotificationRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/bulkUsers/freeform/notify";

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