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
    /// queryRevocationHistories
    ///
    /// Query revocation histories in a namespace.
    /// Other detail info:
    /// 
    ///   * Returns : query revocation history
    /// </summary>
    public class QueryRevocationHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryRevocationHistoriesBuilder Builder { get => new QueryRevocationHistoriesBuilder(); }

        public class QueryRevocationHistoriesBuilder
            : OperationBuilder<QueryRevocationHistoriesBuilder>
        {

            public string? EndTime { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public QueryRevocationHistoriesSource? Source { get; set; }

            public string? StartTime { get; set; }

            public QueryRevocationHistoriesStatus? Status { get; set; }

            public string? TransactionId { get; set; }

            public string? UserId { get; set; }





            internal QueryRevocationHistoriesBuilder() { }


            public QueryRevocationHistoriesBuilder SetEndTime(string _endTime)
            {
                EndTime = _endTime;
                return this;
            }

            public QueryRevocationHistoriesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryRevocationHistoriesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryRevocationHistoriesBuilder SetSource(QueryRevocationHistoriesSource _source)
            {
                Source = _source;
                return this;
            }

            public QueryRevocationHistoriesBuilder SetStartTime(string _startTime)
            {
                StartTime = _startTime;
                return this;
            }

            public QueryRevocationHistoriesBuilder SetStatus(QueryRevocationHistoriesStatus _status)
            {
                Status = _status;
                return this;
            }

            public QueryRevocationHistoriesBuilder SetTransactionId(string _transactionId)
            {
                TransactionId = _transactionId;
                return this;
            }

            public QueryRevocationHistoriesBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public QueryRevocationHistories Build(
                string namespace_
            )
            {
                QueryRevocationHistories op = new QueryRevocationHistories(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private QueryRevocationHistories(QueryRevocationHistoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EndTime is not null) QueryParams["endTime"] = builder.EndTime;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Source is not null) QueryParams["source"] = builder.Source.Value;
            if (builder.StartTime is not null) QueryParams["startTime"] = builder.StartTime;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.TransactionId is not null) QueryParams["transactionId"] = builder.TransactionId;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryRevocationHistories(
            string namespace_,
            string? endTime,
            int? limit,
            int? offset,
            QueryRevocationHistoriesSource? source,
            string? startTime,
            QueryRevocationHistoriesStatus? status,
            string? transactionId,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (source is not null) QueryParams["source"] = source.Value;
            if (startTime is not null) QueryParams["startTime"] = startTime;
            if (status is not null) QueryParams["status"] = status.Value;
            if (transactionId is not null) QueryParams["transactionId"] = transactionId;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/revocation/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RevocationHistoryPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RevocationHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RevocationHistoryPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RevocationHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryRevocationHistoriesSource : StringEnum<QueryRevocationHistoriesSource>
    {
        public static readonly QueryRevocationHistoriesSource DLC
            = new QueryRevocationHistoriesSource("DLC");

        public static readonly QueryRevocationHistoriesSource IAP
            = new QueryRevocationHistoriesSource("IAP");

        public static readonly QueryRevocationHistoriesSource ORDER
            = new QueryRevocationHistoriesSource("ORDER");

        public static readonly QueryRevocationHistoriesSource OTHER
            = new QueryRevocationHistoriesSource("OTHER");


        public static implicit operator QueryRevocationHistoriesSource(string value)
        {
            return NewValue(value);
        }

        public QueryRevocationHistoriesSource(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryRevocationHistoriesStatus : StringEnum<QueryRevocationHistoriesStatus>
    {
        public static readonly QueryRevocationHistoriesStatus FAIL
            = new QueryRevocationHistoriesStatus("FAIL");

        public static readonly QueryRevocationHistoriesStatus SUCCESS
            = new QueryRevocationHistoriesStatus("SUCCESS");


        public static implicit operator QueryRevocationHistoriesStatus(string value)
        {
            return NewValue(value);
        }

        public QueryRevocationHistoriesStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}