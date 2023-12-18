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
    /// adminUpdateTopic
    ///
    /// Update group topic in a namespace.
    /// </summary>
    public class AdminUpdateTopic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateTopicBuilder Builder { get => new AdminUpdateTopicBuilder(); }

        public class AdminUpdateTopicBuilder
            : OperationBuilder<AdminUpdateTopicBuilder>
        {





            internal AdminUpdateTopicBuilder() { }






            public AdminUpdateTopic Build(
                ApiUpdateTopicParams body,
                string namespace_,
                string topic
            )
            {
                AdminUpdateTopic op = new AdminUpdateTopic(this,
                    body,
                    namespace_,
                    topic
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminUpdateTopic(AdminUpdateTopicBuilder builder,
            ApiUpdateTopicParams body,
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateTopic(
            string namespace_,
            string topic,
            Model.ApiUpdateTopicParams body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiCreateTopicResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiCreateTopicResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiCreateTopicResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiCreateTopicResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}