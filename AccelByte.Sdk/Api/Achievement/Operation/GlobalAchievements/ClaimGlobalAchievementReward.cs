// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// ClaimGlobalAchievementReward
    ///
    /// 
    /// 
    /// Required permission
    /// `NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT [UPDATE]` and scope `social`
    /// 
    /// 
    /// 
    /// 
    /// Note:
    /// 
    /// 
    /// 
    /// 
    /// Global achievement should be unlocked to claim the reward. Only contributor of global achievement are eligible for rewards
    /// </summary>
    public class ClaimGlobalAchievementReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ClaimGlobalAchievementRewardBuilder Builder { get => new ClaimGlobalAchievementRewardBuilder(); }

        public class ClaimGlobalAchievementRewardBuilder
            : OperationBuilder<ClaimGlobalAchievementRewardBuilder>
        {





            internal ClaimGlobalAchievementRewardBuilder() { }






            public ClaimGlobalAchievementReward Build(
                string achievementCode,
                string namespace_,
                string userId
            )
            {
                ClaimGlobalAchievementReward op = new ClaimGlobalAchievementReward(this,
                    achievementCode,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private ClaimGlobalAchievementReward(ClaimGlobalAchievementRewardBuilder builder,
            string achievementCode,
            string namespace_,
            string userId
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ClaimGlobalAchievementReward(
            string achievementCode,
            string namespace_,
            string userId
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/users/{userId}/global/achievements/{achievementCode}/claim";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}