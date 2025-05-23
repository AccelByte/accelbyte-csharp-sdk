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
    /// getUserLeaderboardRankingsAdminV3
    ///
    /// 
    /// 
    /// Get user leaderboard rankings
    /// </summary>
    public class GetUserLeaderboardRankingsAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserLeaderboardRankingsAdminV3Builder Builder { get => new GetUserLeaderboardRankingsAdminV3Builder(); }

        public class GetUserLeaderboardRankingsAdminV3Builder
            : OperationBuilder<GetUserLeaderboardRankingsAdminV3Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public long? PreviousVersion { get; set; }





            internal GetUserLeaderboardRankingsAdminV3Builder() { }


            public GetUserLeaderboardRankingsAdminV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserLeaderboardRankingsAdminV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetUserLeaderboardRankingsAdminV3Builder SetPreviousVersion(long _previousVersion)
            {
                PreviousVersion = _previousVersion;
                return this;
            }





            public GetUserLeaderboardRankingsAdminV3 Build(
                string namespace_,
                string userId
            )
            {
                GetUserLeaderboardRankingsAdminV3 op = new GetUserLeaderboardRankingsAdminV3(this,
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

        private GetUserLeaderboardRankingsAdminV3(GetUserLeaderboardRankingsAdminV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PreviousVersion != null) QueryParams["previousVersion"] = Convert.ToString(builder.PreviousVersion)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserLeaderboardRankingsAdminV3(
            string namespace_,
            string userId,
            long? limit,
            long? offset,
            long? previousVersion
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (previousVersion != null) QueryParams["previousVersion"] = Convert.ToString(previousVersion)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/users/{userId}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetAllUserLeaderboardsRespV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGetAllUserLeaderboardsRespV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGetAllUserLeaderboardsRespV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllUserLeaderboardsRespV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}