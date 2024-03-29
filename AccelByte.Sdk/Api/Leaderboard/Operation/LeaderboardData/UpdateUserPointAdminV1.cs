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
    /// updateUserPointAdminV1
    ///
    /// 
    /// 
    /// Update user point in a leaderboard. This endpoint uses for test utility only.
    /// 
    /// 
    /// 
    /// 
    /// Other detail info:
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * Returns: user ranking
    /// </summary>
    public class UpdateUserPointAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateUserPointAdminV1Builder Builder { get => new UpdateUserPointAdminV1Builder(); }

        public class UpdateUserPointAdminV1Builder
            : OperationBuilder<UpdateUserPointAdminV1Builder>
        {





            internal UpdateUserPointAdminV1Builder() { }






            public UpdateUserPointAdminV1 Build(
                ModelsUpdateUserPointAdminV1Request body,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                UpdateUserPointAdminV1 op = new UpdateUserPointAdminV1(this,
                    body,
                    leaderboardCode,
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

        private UpdateUserPointAdminV1(UpdateUserPointAdminV1Builder builder,
            ModelsUpdateUserPointAdminV1Request body,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateUserPointAdminV1(
            string leaderboardCode,
            string namespace_,
            string userId,
            Model.ModelsUpdateUserPointAdminV1Request body
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsUpdateUserPointAdminV1Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsUpdateUserPointAdminV1Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsUpdateUserPointAdminV1Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateUserPointAdminV1Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}