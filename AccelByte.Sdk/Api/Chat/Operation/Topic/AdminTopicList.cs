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
    /// adminTopicList
    ///
    /// Get chat list of topic in a namespace.
    /// </summary>
    public class AdminTopicList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminTopicListBuilder Builder { get => new AdminTopicListBuilder(); }

        public class AdminTopicListBuilder
            : OperationBuilder<AdminTopicListBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? TopicType { get; set; }





            internal AdminTopicListBuilder() { }


            public AdminTopicListBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminTopicListBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminTopicListBuilder SetTopicType(string _topicType)
            {
                TopicType = _topicType;
                return this;
            }





            public AdminTopicList Build(
                string namespace_
            )
            {
                AdminTopicList op = new AdminTopicList(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminTopicList(AdminTopicListBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.TopicType is not null) QueryParams["topicType"] = builder.TopicType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminTopicList(
            string namespace_,
            long? limit,
            long? offset,
            string? topicType
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (topicType is not null) QueryParams["topicType"] = topicType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/topic";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelsTopicResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelsTopicResponse>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelsTopicResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsTopicResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}