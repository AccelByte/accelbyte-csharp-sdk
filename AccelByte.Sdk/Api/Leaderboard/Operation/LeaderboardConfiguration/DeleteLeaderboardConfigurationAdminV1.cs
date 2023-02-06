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
    /// deleteLeaderboardConfigurationAdminV1
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
        public static DeleteLeaderboardConfigurationAdminV1Builder Builder { get => new DeleteLeaderboardConfigurationAdminV1Builder(); }

        public class DeleteLeaderboardConfigurationAdminV1Builder
            : OperationBuilder<DeleteLeaderboardConfigurationAdminV1Builder>
        {





            internal DeleteLeaderboardConfigurationAdminV1Builder() { }






            public DeleteLeaderboardConfigurationAdminV1 Build(
                string leaderboardCode,
                string namespace_
            )
            {
                DeleteLeaderboardConfigurationAdminV1 op = new DeleteLeaderboardConfigurationAdminV1(this,
                    leaderboardCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteLeaderboardConfigurationAdminV1(DeleteLeaderboardConfigurationAdminV1Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteLeaderboardConfigurationAdminV1(
            string leaderboardCode,            
            string namespace_            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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