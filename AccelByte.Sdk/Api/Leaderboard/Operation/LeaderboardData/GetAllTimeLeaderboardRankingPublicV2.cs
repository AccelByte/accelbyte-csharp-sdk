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
    /// GetAllTimeLeaderboardRankingPublicV2
    ///
    /// Get rankings in an all time leaderboard.
    /// </summary>
    public class GetAllTimeLeaderboardRankingPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllTimeLeaderboardRankingPublicV2Builder Builder { get => new GetAllTimeLeaderboardRankingPublicV2Builder(); }

        public class GetAllTimeLeaderboardRankingPublicV2Builder
            : OperationBuilder<GetAllTimeLeaderboardRankingPublicV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetAllTimeLeaderboardRankingPublicV2Builder() { }


            public GetAllTimeLeaderboardRankingPublicV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetAllTimeLeaderboardRankingPublicV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetAllTimeLeaderboardRankingPublicV2 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                GetAllTimeLeaderboardRankingPublicV2 op = new GetAllTimeLeaderboardRankingPublicV2(this,
                    leaderboardCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetAllTimeLeaderboardRankingPublicV2(GetAllTimeLeaderboardRankingPublicV2Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAllTimeLeaderboardRankingPublicV2(
            string leaderboardCode,
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v2/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.V2GetPublicLeaderboardRankingResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.V2GetPublicLeaderboardRankingResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.V2GetPublicLeaderboardRankingResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.V2GetPublicLeaderboardRankingResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}