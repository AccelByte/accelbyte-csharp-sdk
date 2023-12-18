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
    /// adminAddTopicMember
    ///
    /// Add new member for topic in a namespace.
    /// </summary>
    public class AdminAddTopicMember : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddTopicMemberBuilder Builder { get => new AdminAddTopicMemberBuilder(); }

        public class AdminAddTopicMemberBuilder
            : OperationBuilder<AdminAddTopicMemberBuilder>
        {





            internal AdminAddTopicMemberBuilder() { }






            public AdminAddTopicMember Build(
                ApiAddMemberParams body,
                string namespace_,
                string topic,
                string userId
            )
            {
                AdminAddTopicMember op = new AdminAddTopicMember(this,
                    body,
                    namespace_,
                    topic,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminAddTopicMember(AdminAddTopicMemberBuilder builder,
            ApiAddMemberParams body,
            string namespace_,
            string topic,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAddTopicMember(
            string namespace_,
            string topic,
            string userId,
            Model.ApiAddMemberParams body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/user/{userId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.MessageActionAddUserToTopicResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.MessageActionAddUserToTopicResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.MessageActionAddUserToTopicResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.MessageActionAddUserToTopicResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}