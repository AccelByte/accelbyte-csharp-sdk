// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// updateLeaderboardConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// Fields :
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///   * Maximum length for leaderboard name is 128 characters.
    /// 
    /// 
    ///   * Start time must be follow RFC3339 standard. e.g. 2020-10-02T15:00:00.05Z
    /// 
    /// 
    ///   * Season period must be greater than 31 days.
    /// 
    /// 
    ///   * If seasonPeriod is filled, the LeaderboardConfig would have seasonal leaderboard.
    /// 
    /// 
    ///   * Reset Date must be a number 1 - 31. Default is '1'.
    /// 
    /// 
    ///   * Reset Day must be a number 0 - 6. 0 = Sunday, 1 = Monday, 2 = Tuesday, 3 = Wednesday, 4 = Thursday, 5 = Friday, 6 = Saturday (day of week). Default is '0'.
    /// 
    /// 
    ///   * Reset time must be hours:minutes in 24 hours format e.g. 01:30, 10:30, 15:30, 23:15.
    /// </summary>
    public class UpdateLeaderboardConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateLeaderboardConfigurationAdminV1Builder Builder = new UpdateLeaderboardConfigurationAdminV1Builder();

        public class UpdateLeaderboardConfigurationAdminV1Builder
            : OperationBuilder<UpdateLeaderboardConfigurationAdminV1Builder>
        {
            
            
            
            internal UpdateLeaderboardConfigurationAdminV1Builder() { }





            public UpdateLeaderboardConfigurationAdminV1 Build(
                ModelsUpdateLeaderboardConfigReq body,
                string leaderboardCode,
                string namespace_
            )
            {
                UpdateLeaderboardConfigurationAdminV1 op = new UpdateLeaderboardConfigurationAdminV1(this,
                    body,                    
                    leaderboardCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateLeaderboardConfigurationAdminV1(UpdateLeaderboardConfigurationAdminV1Builder builder,
            ModelsUpdateLeaderboardConfigReq body,
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

        public UpdateLeaderboardConfigurationAdminV1(
            string leaderboardCode,            
            string namespace_,            
            Model.ModelsUpdateLeaderboardConfigReq body            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetLeaderboardConfigResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigResp>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}