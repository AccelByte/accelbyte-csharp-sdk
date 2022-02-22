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
    /// deleteLeaderboardConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [DELETE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint delete a leaderboard configuration
    /// </summary>
    public class DeleteLeaderboardConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteLeaderboardConfigurationAdminV1Builder Builder = new DeleteLeaderboardConfigurationAdminV1Builder();

        public class DeleteLeaderboardConfigurationAdminV1Builder
        {
            
            
            internal DeleteLeaderboardConfigurationAdminV1Builder() { }





            public DeleteLeaderboardConfigurationAdminV1 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                return new DeleteLeaderboardConfigurationAdminV1(this,
                    leaderboardCode,                    
                    namespace_                    
                );
            }
        }

        private DeleteLeaderboardConfigurationAdminV1(DeleteLeaderboardConfigurationAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public DeleteLeaderboardConfigurationAdminV1(
            string leaderboardCode,            
            string namespace_            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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