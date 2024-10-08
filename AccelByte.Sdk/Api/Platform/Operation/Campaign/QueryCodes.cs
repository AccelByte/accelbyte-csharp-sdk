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
    /// queryCodes
    ///
    /// Query campaign codes.
    /// Other detail info:
    /// 
    ///   * Returns : list of codes
    ///   * The batchName field in the codes response will be present only when the withBatchName parameter is true , or when the batchName filter is not blank.
    /// </summary>
    public class QueryCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryCodesBuilder Builder { get => new QueryCodesBuilder(); }

        public class QueryCodesBuilder
            : OperationBuilder<QueryCodesBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? BatchName { get; set; }

            public List<int>? BatchNo { get; set; }

            public string? Code { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public bool? WithBatchName { get; set; }





            internal QueryCodesBuilder() { }


            public QueryCodesBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryCodesBuilder SetBatchName(string _batchName)
            {
                BatchName = _batchName;
                return this;
            }

            public QueryCodesBuilder SetBatchNo(List<int> _batchNo)
            {
                BatchNo = _batchNo;
                return this;
            }

            public QueryCodesBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public QueryCodesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryCodesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryCodesBuilder SetWithBatchName(bool _withBatchName)
            {
                WithBatchName = _withBatchName;
                return this;
            }





            public QueryCodes Build(
                string campaignId,
                string namespace_
            )
            {
                QueryCodes op = new QueryCodes(this,
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

        private QueryCodes(QueryCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.BatchName is not null) QueryParams["batchName"] = builder.BatchName;
            if (builder.BatchNo is not null) QueryParams["batchNo"] = builder.BatchNo;
            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.WithBatchName != null) QueryParams["withBatchName"] = Convert.ToString(builder.WithBatchName)!;



            CollectionFormatMap["batchNo"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryCodes(
            string campaignId,
            string namespace_,
            bool? activeOnly,
            string? batchName,
            List<int>? batchNo,
            string? code,
            int? limit,
            int? offset,
            bool? withBatchName
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (batchName is not null) QueryParams["batchName"] = batchName;
            if (batchNo is not null) QueryParams["batchNo"] = batchNo;
            if (code is not null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (withBatchName != null) QueryParams["withBatchName"] = Convert.ToString(withBatchName)!;



            CollectionFormatMap["batchNo"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.CodeInfoPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.CodeInfoPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.CodeInfoPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeInfoPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}