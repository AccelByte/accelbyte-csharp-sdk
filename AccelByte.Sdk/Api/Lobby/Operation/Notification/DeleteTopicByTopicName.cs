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
    /// deleteTopicByTopicName
    ///
    /// delete topic information by topic name.
    /// 
    /// topic should be alphabets, no special char except underscore, uppercase and no spacing. for example: TOPIC_TEST.
    /// Already existing topic can not be created
    /// </summary>
    public class DeleteTopicByTopicName : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTopicByTopicNameBuilder Builder { get => new DeleteTopicByTopicNameBuilder(); }

        public class DeleteTopicByTopicNameBuilder
            : OperationBuilder<DeleteTopicByTopicNameBuilder>
        {





            internal DeleteTopicByTopicNameBuilder() { }






            public DeleteTopicByTopicName Build(
                string namespace_,
                string topic
            )
            {
                DeleteTopicByTopicName op = new DeleteTopicByTopicName(this,
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

        private DeleteTopicByTopicName(DeleteTopicByTopicNameBuilder builder,
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteTopicByTopicName(
            string namespace_,
            string topic
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/topics/{topic}";

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