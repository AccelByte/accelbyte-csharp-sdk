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
    /// adminDeleteChat
    ///
    /// Delete chat.
    /// </summary>
    public class AdminDeleteChat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteChatBuilder Builder { get => new AdminDeleteChatBuilder(); }

        public class AdminDeleteChatBuilder
            : OperationBuilder<AdminDeleteChatBuilder>
        {





            internal AdminDeleteChatBuilder() { }






            public AdminDeleteChat Build(
                string chatId,
                string namespace_,
                string topic
            )
            {
                AdminDeleteChat op = new AdminDeleteChat(this,
                    chatId,
                    namespace_,
                    topic
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminDeleteChat(AdminDeleteChatBuilder builder,
            string chatId,
            string namespace_,
            string topic
        )
        {
            PathParams["chatId"] = chatId;
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteChat(
            string chatId,
            string namespace_,
            string topic
        )
        {
            PathParams["chatId"] = chatId;
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/chats/{chatId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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