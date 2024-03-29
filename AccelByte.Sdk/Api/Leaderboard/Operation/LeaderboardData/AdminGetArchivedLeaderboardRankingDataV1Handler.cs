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
    /// AdminGetArchivedLeaderboardRankingDataV1Handler
    ///
    /// 
    /// 
    /// Admin Get signed url in an all time leaderboard that archived. Notes: This will be a bulk endpoint to get sign url
    /// </summary>
    public class AdminGetArchivedLeaderboardRankingDataV1Handler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder Builder { get => new AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder(); }

        public class AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder
            : OperationBuilder<AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder>
        {

            public string? Slug { get; set; }





            internal AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder() { }


            public AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder SetSlug(string _slug)
            {
                Slug = _slug;
                return this;
            }





            public AdminGetArchivedLeaderboardRankingDataV1Handler Build(
                string namespace_,
                string leaderboardCodes
            )
            {
                AdminGetArchivedLeaderboardRankingDataV1Handler op = new AdminGetArchivedLeaderboardRankingDataV1Handler(this,
                    namespace_,
                    leaderboardCodes
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetArchivedLeaderboardRankingDataV1Handler(AdminGetArchivedLeaderboardRankingDataV1HandlerBuilder builder,
            string namespace_,
            string leaderboardCodes
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Slug is not null) QueryParams["slug"] = builder.Slug;
            if (leaderboardCodes is not null) QueryParams["leaderboardCodes"] = leaderboardCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetArchivedLeaderboardRankingDataV1Handler(
            string namespace_,
            string? slug,
            string leaderboardCodes
        )
        {
            PathParams["namespace"] = namespace_;

            if (slug is not null) QueryParams["slug"] = slug;
            if (leaderboardCodes is not null) QueryParams["leaderboardCodes"] = leaderboardCodes;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelsArchiveLeaderboardSignedURLResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelsArchiveLeaderboardSignedURLResponse>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelsArchiveLeaderboardSignedURLResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsArchiveLeaderboardSignedURLResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}