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
    /// adminChannelTopicList
    ///
    /// Get channel chat list of topic in a namespace.
    /// </summary>
    public class AdminChannelTopicList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminChannelTopicListBuilder Builder { get => new AdminChannelTopicListBuilder(); }

        public class AdminChannelTopicListBuilder
            : OperationBuilder<AdminChannelTopicListBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? TopicName { get; set; }





            internal AdminChannelTopicListBuilder() { }


            public AdminChannelTopicListBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminChannelTopicListBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminChannelTopicListBuilder SetTopicName(string _topicName)
            {
                TopicName = _topicName;
                return this;
            }





            public AdminChannelTopicList Build(
                string namespace_
            )
            {
                AdminChannelTopicList op = new AdminChannelTopicList(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminChannelTopicList(AdminChannelTopicListBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.TopicName is not null) QueryParams["topicName"] = builder.TopicName;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminChannelTopicList(
            string namespace_,
            long? limit,
            long? offset,
            string? topicName
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (topicName is not null) QueryParams["topicName"] = topicName;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic/channel";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsChannelTopicWithPaginationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsChannelTopicWithPaginationResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsChannelTopicWithPaginationResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelTopicWithPaginationResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}