// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminSendInboxMessage
    ///
    /// Send inbox message
    /// </summary>
    public class AdminSendInboxMessage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSendInboxMessageBuilder Builder { get => new AdminSendInboxMessageBuilder(); }

        public class AdminSendInboxMessageBuilder
            : OperationBuilder<AdminSendInboxMessageBuilder>
        {





            internal AdminSendInboxMessageBuilder() { }






            public AdminSendInboxMessage Build(
                ModelsSendInboxMessageRequest body,
                string messageId,
                string namespace_
            )
            {
                AdminSendInboxMessage op = new AdminSendInboxMessage(this,
                    body,                    
                    messageId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminSendInboxMessage(AdminSendInboxMessageBuilder builder,
            ModelsSendInboxMessageRequest body,
            string messageId,
            string namespace_
        )
        {
            PathParams["messageId"] = messageId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSendInboxMessage(
            string messageId,            
            string namespace_,            
            Model.ModelsSendInboxMessageRequest body            
        )
        {
            PathParams["messageId"] = messageId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/messages/{messageId}/send";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsSendInboxMessageResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsSendInboxMessageResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsSendInboxMessageResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSendInboxMessageResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}