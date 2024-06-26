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
    /// queryImportHistory
    ///
    /// This API is used to query import store history
    /// </summary>
    public class QueryImportHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryImportHistoryBuilder Builder { get => new QueryImportHistoryBuilder(); }

        public class QueryImportHistoryBuilder
            : OperationBuilder<QueryImportHistoryBuilder>
        {

            public string? End { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? Start { get; set; }

            public bool? Success { get; set; }





            internal QueryImportHistoryBuilder() { }


            public QueryImportHistoryBuilder SetEnd(string _end)
            {
                End = _end;
                return this;
            }

            public QueryImportHistoryBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryImportHistoryBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryImportHistoryBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public QueryImportHistoryBuilder SetStart(string _start)
            {
                Start = _start;
                return this;
            }

            public QueryImportHistoryBuilder SetSuccess(bool _success)
            {
                Success = _success;
                return this;
            }





            public QueryImportHistory Build(
                string namespace_,
                string storeId
            )
            {
                QueryImportHistory op = new QueryImportHistory(this,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private QueryImportHistory(QueryImportHistoryBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (builder.End is not null) QueryParams["end"] = builder.End;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Start is not null) QueryParams["start"] = builder.Start;
            if (builder.Success != null) QueryParams["success"] = Convert.ToString(builder.Success)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryImportHistory(
            string namespace_,
            string storeId,
            string? end,
            int? limit,
            int? offset,
            string? sortBy,
            string? start,
            bool? success
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;

            if (end is not null) QueryParams["end"] = end;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (start is not null) QueryParams["start"] = start;
            if (success != null) QueryParams["success"] = Convert.ToString(success)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/import/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ImportStoreHistoryPagingResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ImportStoreHistoryPagingResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ImportStoreHistoryPagingResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ImportStoreHistoryPagingResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}