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
    /// createLeaderboardConfigurationAdminV3
    ///
    /// 
    /// 
    ///  Fields :
    /// 
    /// 
    /// 
    /// 
    ///   * leaderboardCode: unique leaderboard config code must be lowercase and maximum length is 48 characters. (required).
    /// 
    /// 
    ///   * name: leaderboard name, maximum length for leaderboard name is 128 characters. (required).
    /// 
    /// 
    ///   * description: leaderboard description, maximum length for leaderboard description is 2048 characters. (optional).
    /// 
    /// 
    ///   * iconURL: leaderboard icon image url. (optional).
    /// 
    /// 
    ///   * allTime: if true, all time leaderboard will be created. (required).
    /// 
    /// 
    ///   * descending: leaderboard order. If true, the points will be sorted in descending order. (required).
    /// 
    /// 
    ///   * statCode: Stat Code is related with statistic code in statistic service. (required).
    /// 
    /// 
    ///   * cycleIds: Statistic cycle ids that will be tracked in the leaderboard. (required).
    /// </summary>
    public class CreateLeaderboardConfigurationAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateLeaderboardConfigurationAdminV3Builder Builder { get => new CreateLeaderboardConfigurationAdminV3Builder(); }

        public class CreateLeaderboardConfigurationAdminV3Builder
            : OperationBuilder<CreateLeaderboardConfigurationAdminV3Builder>
        {





            internal CreateLeaderboardConfigurationAdminV3Builder() { }






            public CreateLeaderboardConfigurationAdminV3 Build(
                ModelsLeaderboardConfigReqV3 body,
                string namespace_
            )
            {
                CreateLeaderboardConfigurationAdminV3 op = new CreateLeaderboardConfigurationAdminV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CreateLeaderboardConfigurationAdminV3(CreateLeaderboardConfigurationAdminV3Builder builder,
            ModelsLeaderboardConfigReqV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateLeaderboardConfigurationAdminV3(
            string namespace_,
            Model.ModelsLeaderboardConfigReqV3 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetLeaderboardConfigRespV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigRespV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigRespV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigRespV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}