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
    /// adminGetInboxMessages
    ///
    /// Get inbox messages
    /// </summary>
    public class AdminGetInboxMessages : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetInboxMessagesBuilder Builder { get => new AdminGetInboxMessagesBuilder(); }

        public class AdminGetInboxMessagesBuilder
            : OperationBuilder<AdminGetInboxMessagesBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public long? EndCreatedAt { get; set; }

            public long? Limit { get; set; }

            public List<string>? MessageId { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public AdminGetInboxMessagesScope? Scope { get; set; }

            public long? StartCreatedAt { get; set; }

            public AdminGetInboxMessagesStatus? Status { get; set; }

            public bool? Transient { get; set; }





            internal AdminGetInboxMessagesBuilder() { }


            public AdminGetInboxMessagesBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public AdminGetInboxMessagesBuilder SetEndCreatedAt(long _endCreatedAt)
            {
                EndCreatedAt = _endCreatedAt;
                return this;
            }

            public AdminGetInboxMessagesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetInboxMessagesBuilder SetMessageId(List<string> _messageId)
            {
                MessageId = _messageId;
                return this;
            }

            public AdminGetInboxMessagesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetInboxMessagesBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public AdminGetInboxMessagesBuilder SetScope(AdminGetInboxMessagesScope _scope)
            {
                Scope = _scope;
                return this;
            }

            public AdminGetInboxMessagesBuilder SetStartCreatedAt(long _startCreatedAt)
            {
                StartCreatedAt = _startCreatedAt;
                return this;
            }

            public AdminGetInboxMessagesBuilder SetStatus(AdminGetInboxMessagesStatus _status)
            {
                Status = _status;
                return this;
            }

            public AdminGetInboxMessagesBuilder SetTransient(bool _transient)
            {
                Transient = _transient;
                return this;
            }





            public AdminGetInboxMessages Build(
                string namespace_
            )
            {
                AdminGetInboxMessages op = new AdminGetInboxMessages(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetInboxMessages(AdminGetInboxMessagesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.EndCreatedAt != null) QueryParams["endCreatedAt"] = Convert.ToString(builder.EndCreatedAt)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.MessageId is not null) QueryParams["messageId"] = builder.MessageId;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.Scope is not null) QueryParams["scope"] = builder.Scope.Value;
            if (builder.StartCreatedAt != null) QueryParams["startCreatedAt"] = Convert.ToString(builder.StartCreatedAt)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.Transient != null) QueryParams["transient"] = Convert.ToString(builder.Transient)!;



            CollectionFormatMap["messageId"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetInboxMessages(
            string namespace_,
            bool? activeOnly,
            long? endCreatedAt,
            long? limit,
            List<string>? messageId,
            long? offset,
            string? order,
            AdminGetInboxMessagesScope? scope,
            long? startCreatedAt,
            AdminGetInboxMessagesStatus? status,
            bool? transient
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (endCreatedAt != null) QueryParams["endCreatedAt"] = Convert.ToString(endCreatedAt)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (messageId is not null) QueryParams["messageId"] = messageId;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (scope is not null) QueryParams["scope"] = scope.Value;
            if (startCreatedAt != null) QueryParams["startCreatedAt"] = Convert.ToString(startCreatedAt)!;
            if (status is not null) QueryParams["status"] = status.Value;
            if (transient != null) QueryParams["transient"] = Convert.ToString(transient)!;



            CollectionFormatMap["messageId"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/messages";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetInboxMessagesResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGetInboxMessagesResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGetInboxMessagesResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetInboxMessagesResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminGetInboxMessagesScope : StringEnum<AdminGetInboxMessagesScope>
    {
        public static readonly AdminGetInboxMessagesScope NAMESPACE
            = new AdminGetInboxMessagesScope("NAMESPACE");

        public static readonly AdminGetInboxMessagesScope USER
            = new AdminGetInboxMessagesScope("USER");


        public static implicit operator AdminGetInboxMessagesScope(string value)
        {
            return NewValue(value);
        }

        public AdminGetInboxMessagesScope(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class AdminGetInboxMessagesStatus : StringEnum<AdminGetInboxMessagesStatus>
    {
        public static readonly AdminGetInboxMessagesStatus DRAFT
            = new AdminGetInboxMessagesStatus("DRAFT");

        public static readonly AdminGetInboxMessagesStatus SENT
            = new AdminGetInboxMessagesStatus("SENT");

        public static readonly AdminGetInboxMessagesStatus UNSENT
            = new AdminGetInboxMessagesStatus("UNSENT");


        public static implicit operator AdminGetInboxMessagesStatus(string value)
        {
            return NewValue(value);
        }

        public AdminGetInboxMessagesStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}