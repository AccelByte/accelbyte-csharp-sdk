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
    /// deleteUserRankingAdminV1
    ///
    /// Delete user ranking
    /// Required permission: ADMIN:NAMESPACE:{namespace}:LEADERBOARD:USER [DELETE]
    /// 
    /// Remove entry with provided userId from leaderboard.
    /// If leaderboard with given leaderboard code not found, it will return http status not found (404).
    /// If the leaderboard is found and no entry found in it, it will still return success (204)
    /// </summary>
    public class DeleteUserRankingAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserRankingAdminV1Builder Builder = new DeleteUserRankingAdminV1Builder();

        public class DeleteUserRankingAdminV1Builder
        {
            
            
            
            internal DeleteUserRankingAdminV1Builder() { }





            public DeleteUserRankingAdminV1 Build(
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                return new DeleteUserRankingAdminV1(this,
                    leaderboardCode,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private DeleteUserRankingAdminV1(DeleteUserRankingAdminV1Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public DeleteUserRankingAdminV1(
            string leaderboardCode,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}