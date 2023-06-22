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
    /// getGlobalStatItems_1
    ///
    /// List global statItems by pagination.
    /// Other detail info:
    ///             *  Required permission : resource="NAMESPACE:{namespace}:STATITEM", action=2 (READ)
    ///             *  Returns : stat items
    /// </summary>
    public class GetGlobalStatItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGlobalStatItems1Builder Builder { get => new GetGlobalStatItems1Builder(); }

        public class GetGlobalStatItems1Builder
            : OperationBuilder<GetGlobalStatItems1Builder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? StatCodes { get; set; }





            internal GetGlobalStatItems1Builder() { }


            public GetGlobalStatItems1Builder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGlobalStatItems1Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetGlobalStatItems1Builder SetStatCodes(string _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }





            public GetGlobalStatItems1 Build(
                string namespace_
            )
            {
                GetGlobalStatItems1 op = new GetGlobalStatItems1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetGlobalStatItems1(GetGlobalStatItems1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StatCodes is not null) QueryParams["statCodes"] = builder.StatCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGlobalStatItems1(
            string namespace_,
            int? limit,
            int? offset,
            string? statCodes
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (statCodes is not null) QueryParams["statCodes"] = statCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/globalstatitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.GlobalStatItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.GlobalStatItemPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.GlobalStatItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GlobalStatItemPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}