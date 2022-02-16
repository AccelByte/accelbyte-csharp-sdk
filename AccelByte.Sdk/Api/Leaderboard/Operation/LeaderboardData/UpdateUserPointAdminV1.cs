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
    ///   * Required permission: resource="ADMIN:NAMESPACE:{namespace}:USER:(userId):LEADERBOARD", action=4 (UPDATE)
    /// 
    /// 
    ///   * Returns: user ranking
    /// </summary>
    public class UpdateUserPointAdminV1 : AccelByte.Sdk.Core.Operation
    {
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
            
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsUpdateUserPointAdminV1Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateUserPointAdminV1Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateUserPointAdminV1Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}