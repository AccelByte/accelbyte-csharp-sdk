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
    /// AdminGetUserPlatformAccountsV3
    ///
    /// ## Justice Platform Account
    /// The permission âADMIN:NAMESPACE:{namespace}:JUSTICE:USER:{userId}â [READ]
    /// is required in order to read the UserID who linked with the user.
    /// Gets platform accounts that are already linked with user account
    /// action code : 10128
    /// </summary>
    public class AdminGetUserPlatformAccountsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserPlatformAccountsV3Builder Builder { get => new AdminGetUserPlatformAccountsV3Builder(); }

        public class AdminGetUserPlatformAccountsV3Builder
            : OperationBuilder<AdminGetUserPlatformAccountsV3Builder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }

            public string? PlatformId { get; set; }





            internal AdminGetUserPlatformAccountsV3Builder() { }


            public AdminGetUserPlatformAccountsV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetUserPlatformAccountsV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetUserPlatformAccountsV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetUserPlatformAccountsV3Builder SetPlatformId(string _platformId)
            {
                PlatformId = _platformId;
                return this;
            }





            public AdminGetUserPlatformAccountsV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserPlatformAccountsV3 op = new AdminGetUserPlatformAccountsV3(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetUserPlatformAccountsV3(AdminGetUserPlatformAccountsV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.PlatformId is not null) QueryParams["platformId"] = builder.PlatformId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserPlatformAccountsV3(
            string namespace_,
            string userId,
            string? after,
            string? before,
            long? limit,
            string? platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (platformId is not null) QueryParams["platformId"] = platformId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.AccountcommonUserLinkedPlatformsResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.AccountcommonUserLinkedPlatformsResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.AccountcommonUserLinkedPlatformsResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserLinkedPlatformsResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}