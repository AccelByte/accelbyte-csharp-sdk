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
    /// updateLeaderboardConfigurationAdminV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [UPDATE]'
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
    public class UpdateLeaderboardConfigurationAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateLeaderboardConfigurationAdminV3Builder Builder { get => new UpdateLeaderboardConfigurationAdminV3Builder(); }

        public class UpdateLeaderboardConfigurationAdminV3Builder
            : OperationBuilder<UpdateLeaderboardConfigurationAdminV3Builder>
        {





            internal UpdateLeaderboardConfigurationAdminV3Builder() { }






            public UpdateLeaderboardConfigurationAdminV3 Build(
                ModelsUpdateLeaderboardConfigReqV3 body,
                string leaderboardCode,
                string namespace_
            )
            {
                UpdateLeaderboardConfigurationAdminV3 op = new UpdateLeaderboardConfigurationAdminV3(this,
                    body,
                    leaderboardCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateLeaderboardConfigurationAdminV3(UpdateLeaderboardConfigurationAdminV3Builder builder,
            ModelsUpdateLeaderboardConfigReqV3 body,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateLeaderboardConfigurationAdminV3(
            string leaderboardCode,
            string namespace_,
            Model.ModelsUpdateLeaderboardConfigReqV3 body
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}";

        public override HttpMethod Method => HttpMethod.Put;

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
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigRespV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigRespV3>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}