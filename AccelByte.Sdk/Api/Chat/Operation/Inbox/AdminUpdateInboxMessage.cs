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
    /// adminUpdateInboxMessage
    ///
    /// Update inbox message
    /// </summary>
    public class AdminUpdateInboxMessage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateInboxMessageBuilder Builder { get => new AdminUpdateInboxMessageBuilder(); }

        public class AdminUpdateInboxMessageBuilder
            : OperationBuilder<AdminUpdateInboxMessageBuilder>
        {





            internal AdminUpdateInboxMessageBuilder() { }






            public AdminUpdateInboxMessage Build(
                ModelsUpdateInboxMessageRequest body,
                string messageId,
                string namespace_
            )
            {
                AdminUpdateInboxMessage op = new AdminUpdateInboxMessage(this,
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

        private AdminUpdateInboxMessage(AdminUpdateInboxMessageBuilder builder,
            ModelsUpdateInboxMessageRequest body,
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

        public AdminUpdateInboxMessage(
            string messageId,            
            string namespace_,            
            Model.ModelsUpdateInboxMessageRequest body            
        )
        {
            PathParams["messageId"] = messageId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/messages/{messageId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}