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
    /// AdminDeleteUserLinkingHistoryByPlatformIDV3
    ///
    /// This API is for admin to delete user's linking history with target platform id.
    /// Supported platform:
    /// - Steam group(steamnetwork)
    /// - steam
    /// - steamopenid
    /// - PSN group(psn)
    /// - ps4web
    /// - ps4
    /// - ps5
    /// - XBOX group(xbox)
    /// - live
    /// - xblweb
    /// - Oculus group(oculusgroup)
    /// - oculus
    /// - oculusweb
    /// - facebook
    /// - google group
    /// - google
    /// - googleplaygames
    /// - twitch
    /// - discord
    /// - apple
    /// - epicgames
    /// - nintendo
    /// - awscognito
    /// - netflix
    /// - snapchat
    /// - oidc platform id
    /// 
    /// Note: you can use either platform ID or platform group as platformId query parameter
    /// </summary>
    public class AdminDeleteUserLinkingHistoryByPlatformIDV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserLinkingHistoryByPlatformIDV3Builder Builder { get => new AdminDeleteUserLinkingHistoryByPlatformIDV3Builder(); }

        public class AdminDeleteUserLinkingHistoryByPlatformIDV3Builder
            : OperationBuilder<AdminDeleteUserLinkingHistoryByPlatformIDV3Builder>
        {





            internal AdminDeleteUserLinkingHistoryByPlatformIDV3Builder() { }






            public AdminDeleteUserLinkingHistoryByPlatformIDV3 Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminDeleteUserLinkingHistoryByPlatformIDV3 op = new AdminDeleteUserLinkingHistoryByPlatformIDV3(this,
                    namespace_,
                    platformId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminDeleteUserLinkingHistoryByPlatformIDV3(AdminDeleteUserLinkingHistoryByPlatformIDV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteUserLinkingHistoryByPlatformIDV3(
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link/histories";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}