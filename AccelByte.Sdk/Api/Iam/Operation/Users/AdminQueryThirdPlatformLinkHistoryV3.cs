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
    /// AdminQueryThirdPlatformLinkHistoryV3
    ///
    /// if limit is not defined, The default limit is 100
    /// </summary>
    public class AdminQueryThirdPlatformLinkHistoryV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryThirdPlatformLinkHistoryV3Builder Builder { get => new AdminQueryThirdPlatformLinkHistoryV3Builder(); }

        public class AdminQueryThirdPlatformLinkHistoryV3Builder
            : OperationBuilder<AdminQueryThirdPlatformLinkHistoryV3Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? PlatformUserId { get; set; }





            internal AdminQueryThirdPlatformLinkHistoryV3Builder() { }


            public AdminQueryThirdPlatformLinkHistoryV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryThirdPlatformLinkHistoryV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryThirdPlatformLinkHistoryV3Builder SetPlatformUserId(string _platformUserId)
            {
                PlatformUserId = _platformUserId;
                return this;
            }





            public AdminQueryThirdPlatformLinkHistoryV3 Build(
                string namespace_,
                string platformId
            )
            {
                AdminQueryThirdPlatformLinkHistoryV3 op = new AdminQueryThirdPlatformLinkHistoryV3(this,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminQueryThirdPlatformLinkHistoryV3(AdminQueryThirdPlatformLinkHistoryV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PlatformUserId is not null) QueryParams["platformUserId"] = builder.PlatformUserId;
            if (platformId is not null) QueryParams["platformId"] = platformId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryThirdPlatformLinkHistoryV3(
            string namespace_,
            long? limit,
            long? offset,
            string? platformUserId,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (platformUserId is not null) QueryParams["platformUserId"] = platformUserId;
            if (platformId is not null) QueryParams["platformId"] = platformId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/linkhistories";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelLinkingHistoryResponseWithPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelLinkingHistoryResponseWithPaginationV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelLinkingHistoryResponseWithPaginationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkingHistoryResponseWithPaginationV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}