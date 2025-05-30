// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminQueryTagV3
    ///
    /// Retrieve Account Identifier Tags. This endpoint allows administrators to retrieve tags that are used to identify and categorize user accounts.
    /// Tag Name can be used for partial content search.
    /// </summary>
    public class AdminQueryTagV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryTagV3Builder Builder { get => new AdminQueryTagV3Builder(); }

        public class AdminQueryTagV3Builder
            : OperationBuilder<AdminQueryTagV3Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? TagName { get; set; }





            internal AdminQueryTagV3Builder() { }


            public AdminQueryTagV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryTagV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryTagV3Builder SetTagName(string _tagName)
            {
                TagName = _tagName;
                return this;
            }





            public AdminQueryTagV3 Build(
                string namespace_
            )
            {
                AdminQueryTagV3 op = new AdminQueryTagV3(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminQueryTagV3(AdminQueryTagV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.TagName is not null) QueryParams["tagName"] = builder.TagName;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryTagV3(
            string namespace_,
            long? limit,
            long? offset,
            string? tagName
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (tagName is not null) QueryParams["tagName"] = tagName;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/tags";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.AccountcommonTagsGetResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.AccountcommonTagsGetResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.AccountcommonTagsGetResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonTagsGetResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}