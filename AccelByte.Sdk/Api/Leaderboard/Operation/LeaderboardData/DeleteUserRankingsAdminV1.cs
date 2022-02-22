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
    /// deleteUserRankingsAdminV1
    ///
    /// Delete user ranking across leaderboard
    /// Required permission: ADMIN:NAMESPACE:{namespace}:LEADERBOARD:USER [DELETE]
    /// 
    /// Remove entry with provided userId from leaderboard.
    /// If leaderboard with given leaderboard code not found, it will return http status not found (404).
    /// If the leaderboard is found and no entry found in it, it will still return success (204)
    /// </summary>
    public class DeleteUserRankingsAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserRankingsAdminV1Builder Builder = new DeleteUserRankingsAdminV1Builder();

        public class DeleteUserRankingsAdminV1Builder
        {
            
            
            
            internal DeleteUserRankingsAdminV1Builder() { }





            public DeleteUserRankingsAdminV1 Build(
                string namespace_,
                string userId,
                List<string> leaderboardCode
            )
            {
                return new DeleteUserRankingsAdminV1(this,
                    namespace_,                    
                    userId,                    
                    leaderboardCode                    
                );
            }
        }

        private DeleteUserRankingsAdminV1(DeleteUserRankingsAdminV1Builder builder,
            string namespace_,
            string userId,
            List<string> leaderboardCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (leaderboardCode != null) QueryParams["leaderboardCode"] = leaderboardCode;
            
            
            CollectionFormatMap["leaderboardCode"] = "multi";
            
            
        }
        #endregion

        public DeleteUserRankingsAdminV1(
            string namespace_,            
            string userId,            
            List<string> leaderboardCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (leaderboardCode != null) QueryParams["leaderboardCode"] = leaderboardCode;
            
            
            CollectionFormatMap["leaderboardCode"] = "multi";
            
            
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/users/{userId}";

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