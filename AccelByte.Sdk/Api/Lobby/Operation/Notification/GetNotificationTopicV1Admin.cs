// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// getNotificationTopicV1Admin
    ///
    /// Get topic information by topic name.
    /// 
    /// Action Code: 50215
    /// </summary>
    public class GetNotificationTopicV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNotificationTopicV1AdminBuilder Builder { get => new GetNotificationTopicV1AdminBuilder(); }

        public class GetNotificationTopicV1AdminBuilder
            : OperationBuilder<GetNotificationTopicV1AdminBuilder>
        {





            internal GetNotificationTopicV1AdminBuilder() { }






            public GetNotificationTopicV1Admin Build(
                string namespace_,
                string topicName
            )
            {
                GetNotificationTopicV1Admin op = new GetNotificationTopicV1Admin(this,
                    namespace_,
                    topicName
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetNotificationTopicV1Admin(GetNotificationTopicV1AdminBuilder builder,
            string namespace_,
            string topicName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetNotificationTopicV1Admin(
            string namespace_,
            string topicName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topicName"] = topicName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelNotificationTopicResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelNotificationTopicResponseV1>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelNotificationTopicResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelNotificationTopicResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}