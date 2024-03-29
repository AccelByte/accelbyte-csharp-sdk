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
    /// getLeaderboardConfigurationsPublicV1
    ///
    /// 
    /// 
    /// This endpoint return all leaderboard configurations
    /// </summary>
    public class GetLeaderboardConfigurationsPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLeaderboardConfigurationsPublicV1Builder Builder { get => new GetLeaderboardConfigurationsPublicV1Builder(); }

        public class GetLeaderboardConfigurationsPublicV1Builder
            : OperationBuilder<GetLeaderboardConfigurationsPublicV1Builder>
        {

            public bool? IsArchived { get; set; }

            public bool? IsDeleted { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetLeaderboardConfigurationsPublicV1Builder() { }


            public GetLeaderboardConfigurationsPublicV1Builder SetIsArchived(bool _isArchived)
            {
                IsArchived = _isArchived;
                return this;
            }

            public GetLeaderboardConfigurationsPublicV1Builder SetIsDeleted(bool _isDeleted)
            {
                IsDeleted = _isDeleted;
                return this;
            }

            public GetLeaderboardConfigurationsPublicV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetLeaderboardConfigurationsPublicV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetLeaderboardConfigurationsPublicV1 Build(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsPublicV1 op = new GetLeaderboardConfigurationsPublicV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetLeaderboardConfigurationsPublicV1(GetLeaderboardConfigurationsPublicV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.IsArchived != null) QueryParams["isArchived"] = Convert.ToString(builder.IsArchived)!;
            if (builder.IsDeleted != null) QueryParams["isDeleted"] = Convert.ToString(builder.IsDeleted)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLeaderboardConfigurationsPublicV1(
            string namespace_,
            bool? isArchived,
            bool? isDeleted,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (isArchived != null) QueryParams["isArchived"] = Convert.ToString(isArchived)!;
            if (isDeleted != null) QueryParams["isDeleted"] = Convert.ToString(isDeleted)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetAllLeaderboardConfigsPublicResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsPublicResp>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsPublicResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsPublicResp>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}