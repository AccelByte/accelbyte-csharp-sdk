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
    /// adminCreateNamespaceTopic
    ///
    /// Create new namespace group topic in a namespace.
    /// </summary>
    public class AdminCreateNamespaceTopic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateNamespaceTopicBuilder Builder { get => new AdminCreateNamespaceTopicBuilder(); }

        public class AdminCreateNamespaceTopicBuilder
            : OperationBuilder<AdminCreateNamespaceTopicBuilder>
        {





            internal AdminCreateNamespaceTopicBuilder() { }






            public AdminCreateNamespaceTopic Build(
                ApiCreateNamespaceTopicParams body,
                string namespace_
            )
            {
                AdminCreateNamespaceTopic op = new AdminCreateNamespaceTopic(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminCreateNamespaceTopic(AdminCreateNamespaceTopicBuilder builder,
            ApiCreateNamespaceTopicParams body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateNamespaceTopic(
            string namespace_,
            Model.ApiCreateNamespaceTopicParams body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/namespace-topic";

        public override HttpMethod Method => HttpMethod.Post;

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