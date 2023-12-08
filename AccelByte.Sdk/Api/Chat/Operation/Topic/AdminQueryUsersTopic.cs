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
    /// adminQueryUsersTopic
    ///
    /// Get user's topics in a namespace.
    /// </summary>
    public class AdminQueryUsersTopic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryUsersTopicBuilder Builder { get => new AdminQueryUsersTopicBuilder(); }

        public class AdminQueryUsersTopicBuilder
            : OperationBuilder<AdminQueryUsersTopicBuilder>
        {

            public bool? IncludePastTopics { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminQueryUsersTopicTopicSubType? TopicSubType { get; set; }

            public AdminQueryUsersTopicTopicType? TopicType { get; set; }





            internal AdminQueryUsersTopicBuilder() { }


            public AdminQueryUsersTopicBuilder SetIncludePastTopics(bool _includePastTopics)
            {
                IncludePastTopics = _includePastTopics;
                return this;
            }

            public AdminQueryUsersTopicBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryUsersTopicBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryUsersTopicBuilder SetTopicSubType(AdminQueryUsersTopicTopicSubType _topicSubType)
            {
                TopicSubType = _topicSubType;
                return this;
            }

            public AdminQueryUsersTopicBuilder SetTopicType(AdminQueryUsersTopicTopicType _topicType)
            {
                TopicType = _topicType;
                return this;
            }





            public AdminQueryUsersTopic Build(
                string namespace_,
                string userId
            )
            {
                AdminQueryUsersTopic op = new AdminQueryUsersTopic(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminQueryUsersTopic(AdminQueryUsersTopicBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.IncludePastTopics != null) QueryParams["includePastTopics"] = Convert.ToString(builder.IncludePastTopics)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.TopicSubType is not null) QueryParams["topicSubType"] = builder.TopicSubType.Value;
            if (builder.TopicType is not null) QueryParams["topicType"] = builder.TopicType.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryUsersTopic(
            string namespace_,            
            string userId,            
            bool? includePastTopics,            
            long? limit,            
            long? offset,            
            AdminQueryUsersTopicTopicSubType? topicSubType,            
            AdminQueryUsersTopicTopicType? topicType            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (includePastTopics != null) QueryParams["includePastTopics"] = Convert.ToString(includePastTopics)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (topicSubType is not null) QueryParams["topicSubType"] = topicSubType.Value;
            if (topicType is not null) QueryParams["topicType"] = topicType.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/admin/namespaces/{namespace}/users/{userId}/topics";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsTopicLogWithPaginationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsTopicLogWithPaginationResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsTopicLogWithPaginationResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsTopicLogWithPaginationResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminQueryUsersTopicTopicSubType : StringEnum<AdminQueryUsersTopicTopicSubType>
    {
        public static readonly AdminQueryUsersTopicTopicSubType CLAN
            = new AdminQueryUsersTopicTopicSubType("CLAN");

        public static readonly AdminQueryUsersTopicTopicSubType NAMESPACE
            = new AdminQueryUsersTopicTopicSubType("NAMESPACE");

        public static readonly AdminQueryUsersTopicTopicSubType NORMAL
            = new AdminQueryUsersTopicTopicSubType("NORMAL");

        public static readonly AdminQueryUsersTopicTopicSubType PARTY
            = new AdminQueryUsersTopicTopicSubType("PARTY");

        public static readonly AdminQueryUsersTopicTopicSubType SESSION
            = new AdminQueryUsersTopicTopicSubType("SESSION");


        public static implicit operator AdminQueryUsersTopicTopicSubType(string value)
        {
            return NewValue(value);
        }

        public AdminQueryUsersTopicTopicSubType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class AdminQueryUsersTopicTopicType : StringEnum<AdminQueryUsersTopicTopicType>
    {
        public static readonly AdminQueryUsersTopicTopicType GROUP
            = new AdminQueryUsersTopicTopicType("GROUP");

        public static readonly AdminQueryUsersTopicTopicType PERSONAL
            = new AdminQueryUsersTopicTopicType("PERSONAL");


        public static implicit operator AdminQueryUsersTopicTopicType(string value)
        {
            return NewValue(value);
        }

        public AdminQueryUsersTopicTopicType(string enumValue)
            : base(enumValue)
        {

        }
    }

}