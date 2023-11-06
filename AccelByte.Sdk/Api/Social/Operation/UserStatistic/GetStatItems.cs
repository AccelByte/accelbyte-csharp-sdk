// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getStatItems
    ///
    /// Get users' stat item values for a given namespace and statCode.
    /// Other info:
    /// + *Required permission*: resource=ADMIN:NAMESPACE:{namespace}:STATITEM, action=2 (READ)
    /// + *Returns*: list of users' stat item values
    /// </summary>
    public class GetStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetStatItemsBuilder Builder { get => new GetStatItemsBuilder(); }

        public class GetStatItemsBuilder
            : OperationBuilder<GetStatItemsBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }





            internal GetStatItemsBuilder() { }


            public GetStatItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetStatItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetStatItemsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public GetStatItems Build(
                string namespace_,
                string statCode
            )
            {
                GetStatItems op = new GetStatItems(this,
                    namespace_,
                    statCode
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetStatItems(GetStatItemsBuilder builder,
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetStatItems(
            string namespace_,
            string statCode,
            int? limit,
            int? offset,
            string? sortBy
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/{statCode}/statitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.StatItemValuePagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.StatItemValuePagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.StatItemValuePagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatItemValuePagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}