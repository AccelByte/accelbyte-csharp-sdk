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
    /// adminUnsendInboxMessage
    ///
    /// Unsend inbox message
    /// </summary>
    public class AdminUnsendInboxMessage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUnsendInboxMessageBuilder Builder { get => new AdminUnsendInboxMessageBuilder(); }

        public class AdminUnsendInboxMessageBuilder
            : OperationBuilder<AdminUnsendInboxMessageBuilder>
        {





            internal AdminUnsendInboxMessageBuilder() { }






            public AdminUnsendInboxMessage Build(
                ModelsUnsendInboxMessageRequest body,
                string inbox,
                string namespace_
            )
            {
                AdminUnsendInboxMessage op = new AdminUnsendInboxMessage(this,
                    body,
                    inbox,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminUnsendInboxMessage(AdminUnsendInboxMessageBuilder builder,
            ModelsUnsendInboxMessageRequest body,
            string inbox,
            string namespace_
        )
        {
            PathParams["inbox"] = inbox;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUnsendInboxMessage(
            string inbox,
            string namespace_,
            Model.ModelsUnsendInboxMessageRequest body
        )
        {
            PathParams["inbox"] = inbox;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/messages/{inbox}/unsend";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsUnsendInboxMessageResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsUnsendInboxMessageResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsUnsendInboxMessageResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUnsendInboxMessageResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}