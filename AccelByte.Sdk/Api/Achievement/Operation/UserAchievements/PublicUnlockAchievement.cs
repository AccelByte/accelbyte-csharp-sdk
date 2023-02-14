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
    /// PublicUnlockAchievement
    ///
    /// Required permission
    /// `NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT [UPDATE]` and scope `social`
    /// </summary>
    public class PublicUnlockAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUnlockAchievementBuilder Builder { get => new PublicUnlockAchievementBuilder(); }

        public class PublicUnlockAchievementBuilder
            : OperationBuilder<PublicUnlockAchievementBuilder>
        {





            internal PublicUnlockAchievementBuilder() { }






            public PublicUnlockAchievement Build(
                string achievementCode,
                string namespace_,
                string userId
            )
            {
                PublicUnlockAchievement op = new PublicUnlockAchievement(this,
                    achievementCode,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicUnlockAchievement(PublicUnlockAchievementBuilder builder,
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

        public PublicUnlockAchievement(
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

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/unlock";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

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