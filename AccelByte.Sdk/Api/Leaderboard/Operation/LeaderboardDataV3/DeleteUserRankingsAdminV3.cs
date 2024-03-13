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
    /// deleteUserRankingsAdminV3
    ///
    /// Delete user ranking across leaderboard
    /// 
    /// Remove entry with provided userId from leaderboard.
    /// </summary>
    public class DeleteUserRankingsAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserRankingsAdminV3Builder Builder { get => new DeleteUserRankingsAdminV3Builder(); }

        public class DeleteUserRankingsAdminV3Builder
            : OperationBuilder<DeleteUserRankingsAdminV3Builder>
        {





            internal DeleteUserRankingsAdminV3Builder() { }






            public DeleteUserRankingsAdminV3 Build(
                string namespace_,
                string userId,
                List<string> leaderboardCode
            )
            {
                DeleteUserRankingsAdminV3 op = new DeleteUserRankingsAdminV3(this,
                    namespace_,
                    userId,
                    leaderboardCode
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteUserRankingsAdminV3(DeleteUserRankingsAdminV3Builder builder,
            string namespace_,
            string userId,
            List<string> leaderboardCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (leaderboardCode is not null) QueryParams["leaderboardCode"] = leaderboardCode;



            CollectionFormatMap["leaderboardCode"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserRankingsAdminV3(
            string namespace_,
            string userId,
            List<string> leaderboardCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (leaderboardCode is not null) QueryParams["leaderboardCode"] = leaderboardCode;



            CollectionFormatMap["leaderboardCode"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/users/{userId}";

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