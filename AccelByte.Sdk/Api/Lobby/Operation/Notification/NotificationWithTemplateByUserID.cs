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
    /// notificationWithTemplateByUserID
    ///
    /// Required permission : `NAMESPACE:{namespace}:USER:{userId}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Sends notification to a user with predefined template.
    /// 
    /// In the request body, specify which template slug (template identifier) to use and the template language.
    /// 
    /// NotificationTemplate context is the key-value pair defining the value of each handlebar specified in the template content.
    /// Template need to be published before it can be use to send notifications
    /// </summary>
    public class NotificationWithTemplateByUserID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static NotificationWithTemplateByUserIDBuilder Builder = new NotificationWithTemplateByUserIDBuilder();

        public class NotificationWithTemplateByUserIDBuilder
            : OperationBuilder<NotificationWithTemplateByUserIDBuilder>
        {
            
            
            
            internal NotificationWithTemplateByUserIDBuilder() { }






            public NotificationWithTemplateByUserID Build(
                ModelNotificationWithTemplateRequest body,
                string namespace_,
                string userId
            )
            {
                NotificationWithTemplateByUserID op = new NotificationWithTemplateByUserID(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private NotificationWithTemplateByUserID(NotificationWithTemplateByUserIDBuilder builder,
            ModelNotificationWithTemplateRequest body,
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

        public NotificationWithTemplateByUserID(
            string namespace_,            
            string userId,            
            Model.ModelNotificationWithTemplateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/users/{userId}/templated";

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