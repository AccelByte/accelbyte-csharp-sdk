// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryFulfillmentHistories
    ///
    /// Query fulfillment histories in a namespace.
    /// Other detail info:
    /// 
    ///   * Returns : query fulfillment history
    /// </summary>
    public class QueryFulfillmentHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryFulfillmentHistoriesBuilder Builder { get => new QueryFulfillmentHistoriesBuilder(); }

        public class QueryFulfillmentHistoriesBuilder
            : OperationBuilder<QueryFulfillmentHistoriesBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public QueryFulfillmentHistoriesStatus? Status { get; set; }

            public string? UserId { get; set; }





            internal QueryFulfillmentHistoriesBuilder() { }


            public QueryFulfillmentHistoriesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryFulfillmentHistoriesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryFulfillmentHistoriesBuilder SetStatus(QueryFulfillmentHistoriesStatus _status)
            {
                Status = _status;
                return this;
            }

            public QueryFulfillmentHistoriesBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public QueryFulfillmentHistories Build(
                string namespace_
            )
            {
                QueryFulfillmentHistories op = new QueryFulfillmentHistories(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private QueryFulfillmentHistories(QueryFulfillmentHistoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryFulfillmentHistories(
            string namespace_,
            int? limit,
            int? offset,
            QueryFulfillmentHistoriesStatus? status,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status.Value;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/fulfillment/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.FulfillmentHistoryPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.FulfillmentHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.FulfillmentHistoryPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryFulfillmentHistoriesStatus : StringEnum<QueryFulfillmentHistoriesStatus>
    {
        public static readonly QueryFulfillmentHistoriesStatus FAIL
            = new QueryFulfillmentHistoriesStatus("FAIL");

        public static readonly QueryFulfillmentHistoriesStatus SUCCESS
            = new QueryFulfillmentHistoriesStatus("SUCCESS");


        public static implicit operator QueryFulfillmentHistoriesStatus(string value)
        {
            return NewValue(value);
        }

        public QueryFulfillmentHistoriesStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}