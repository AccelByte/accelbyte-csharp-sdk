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
    /// queryRedeemHistory
    ///
    /// Query redeem history.
    /// Other detail info:
    /// 
    ///   * Returns : slice of redeem history
    /// </summary>
    public class QueryRedeemHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryRedeemHistoryBuilder Builder { get => new QueryRedeemHistoryBuilder(); }

        public class QueryRedeemHistoryBuilder
            : OperationBuilder<QueryRedeemHistoryBuilder>
        {

            public string? Code { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? UserId { get; set; }





            internal QueryRedeemHistoryBuilder() { }


            public QueryRedeemHistoryBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public QueryRedeemHistoryBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryRedeemHistoryBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryRedeemHistoryBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public QueryRedeemHistory Build(
                string campaignId,
                string namespace_
            )
            {
                QueryRedeemHistory op = new QueryRedeemHistory(this,
                    campaignId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private QueryRedeemHistory(QueryRedeemHistoryBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryRedeemHistory(
            string campaignId,
            string namespace_,
            string? code,
            int? limit,
            int? offset,
            string? userId
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (code is not null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RedeemHistoryPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RedeemHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RedeemHistoryPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RedeemHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}