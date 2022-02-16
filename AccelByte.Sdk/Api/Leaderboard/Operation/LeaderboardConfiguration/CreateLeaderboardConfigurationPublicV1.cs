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
    /// createLeaderboardConfigurationPublicV1
    ///
    /// Public endpoint to create a new leaderboard.
    /// 
    /// 
    /// 
    /// Required permission 'NAMESPACE:{namespace}:LEADERBOARD [CREATE]'
    /// 
    /// 
    /// 
    /// 
    ///  Fields :
    /// 
    /// 
    /// 
    /// 
    ///   * LeaderboardConfig code must be lowercase and maximum length is 48 characters. (required).
    /// 
    /// 
    ///   * Maximum length for leaderboard name is 128 characters. (required).
    /// 
    /// 
    ///   * Start time must be follow RFC3339 standard. e.g. 2020-10-02T15:00:00.05Z (required).
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
    ///   * Reset time must be hours:minutes in 24 hours format e.g. 01:30, 10:30, 15:30, 23:15.Default is '00:00'.
    /// 
    /// 
    ///   * Stat Code is related with statistic code in statistic service. (required).
    /// </summary>
    public class CreateLeaderboardConfigurationPublicV1 : AccelByte.Sdk.Core.Operation
    {
        public CreateLeaderboardConfigurationPublicV1(
            string namespace_,            
            Model.ModelsLeaderboardConfigReq body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsLeaderboardConfigReq? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsLeaderboardConfigReq>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsLeaderboardConfigReq>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}