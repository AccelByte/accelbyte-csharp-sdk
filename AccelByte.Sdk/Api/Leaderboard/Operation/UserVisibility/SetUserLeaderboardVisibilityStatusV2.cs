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
    /// SetUserLeaderboardVisibilityStatusV2
    ///
    /// User with false visibility status will have hidden attribute set to true on it's leaderboard entry
    /// </summary>
    public class SetUserLeaderboardVisibilityStatusV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetUserLeaderboardVisibilityStatusV2Builder Builder = new SetUserLeaderboardVisibilityStatusV2Builder();

        public class SetUserLeaderboardVisibilityStatusV2Builder
            : OperationBuilder<SetUserLeaderboardVisibilityStatusV2Builder>
        {
            
            
            
            
            internal SetUserLeaderboardVisibilityStatusV2Builder() { }





            public SetUserLeaderboardVisibilityStatusV2 Build(
                ModelsSetUserVisibilityRequest body,
                string leaderboardCode,
                string namespace_,
                string userId
            )
            {
                SetUserLeaderboardVisibilityStatusV2 op = new SetUserLeaderboardVisibilityStatusV2(this,
                    body,                    
                    leaderboardCode,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SetUserLeaderboardVisibilityStatusV2(SetUserLeaderboardVisibilityStatusV2Builder builder,
            ModelsSetUserVisibilityRequest body,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SetUserLeaderboardVisibilityStatusV2(
            string leaderboardCode,            
            string namespace_,            
            string userId,            
            Model.ModelsSetUserVisibilityRequest body            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v2/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}/visibility";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetUserVisibilityResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserVisibilityResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetUserVisibilityResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}