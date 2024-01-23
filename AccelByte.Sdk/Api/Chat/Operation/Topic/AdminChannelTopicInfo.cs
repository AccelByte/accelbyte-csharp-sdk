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
    /// adminChannelTopicInfo
    ///
    /// Get chat list of topic in a namespace.
    /// </summary>
    public class AdminChannelTopicInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminChannelTopicInfoBuilder Builder { get => new AdminChannelTopicInfoBuilder(); }

        public class AdminChannelTopicInfoBuilder
            : OperationBuilder<AdminChannelTopicInfoBuilder>
        {





            internal AdminChannelTopicInfoBuilder() { }






            public AdminChannelTopicInfo Build(
                string namespace_,
                string topic
            )
            {
                AdminChannelTopicInfo op = new AdminChannelTopicInfo(this,
                    namespace_,
                    topic
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminChannelTopicInfo(AdminChannelTopicInfoBuilder builder,
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminChannelTopicInfo(
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/{topic}/channel";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsChannelTopicResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsChannelTopicResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsChannelTopicResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelTopicResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}