// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// adminAnonymizeUserLeaderboardAdminV1
    ///
    /// 
    /// 
    /// This API will delete specified user leaderboard
    /// </summary>
    public class AdminAnonymizeUserLeaderboardAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAnonymizeUserLeaderboardAdminV1Builder Builder { get => new AdminAnonymizeUserLeaderboardAdminV1Builder(); }

        public class AdminAnonymizeUserLeaderboardAdminV1Builder
            : OperationBuilder<AdminAnonymizeUserLeaderboardAdminV1Builder>
        {





            internal AdminAnonymizeUserLeaderboardAdminV1Builder() { }






            public AdminAnonymizeUserLeaderboardAdminV1 Build(
                string namespace_,
                string userId
            )
            {
                AdminAnonymizeUserLeaderboardAdminV1 op = new AdminAnonymizeUserLeaderboardAdminV1(this,
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

        private AdminAnonymizeUserLeaderboardAdminV1(AdminAnonymizeUserLeaderboardAdminV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAnonymizeUserLeaderboardAdminV1(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/users/{userId}/anonymization/leaderboards";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

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