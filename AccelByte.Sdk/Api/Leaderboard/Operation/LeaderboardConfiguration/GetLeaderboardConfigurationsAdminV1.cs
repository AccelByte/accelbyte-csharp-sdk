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
    /// getLeaderboardConfigurationsAdminV1
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint return all leaderboard configurations
    /// </summary>
    public class GetLeaderboardConfigurationsAdminV1 : AccelByte.Sdk.Core.Operation
    {
        public GetLeaderboardConfigurationsAdminV1(
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
            
            
            
            
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetAllLeaderboardConfigsResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsResp>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}