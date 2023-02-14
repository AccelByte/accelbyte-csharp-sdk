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
    /// AdminCreateNewAchievement
    ///
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [CREATE]` and scope `social`
    /// 
    /// 
    /// Other detail info:
    /// - achievementCode: Human readable unique code to indentify the achievement. Must be lowercase
    /// and maximum length is 32
    /// - incremental: If the achievement is not incremental, it does not need to store a goal value
    /// of a stat to be unlocked.
    /// If the achievement is incremental, it needs to set statCode and goalValue
    /// - statCode: Selected statistic code, from the published statistic code event.Human readable unique
    /// code to indentify the achievement. Must be lowercase and maximum length is 32
    /// - goalValue: Statistics value required to unlock the achievement.
    /// - defaultLanguage: localozation for achievement name and achievement description. Allowed format : en, en-US
    /// - slug: specify the image they want to use, it can be file image name or something
    /// to define the achievement icon.
    /// </summary>
    public class AdminCreateNewAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateNewAchievementBuilder Builder { get => new AdminCreateNewAchievementBuilder(); }

        public class AdminCreateNewAchievementBuilder
            : OperationBuilder<AdminCreateNewAchievementBuilder>
        {





            internal AdminCreateNewAchievementBuilder() { }






            public AdminCreateNewAchievement Build(
                ModelsAchievementRequest body,
                string namespace_
            )
            {
                AdminCreateNewAchievement op = new AdminCreateNewAchievement(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminCreateNewAchievement(AdminCreateNewAchievementBuilder builder,
            ModelsAchievementRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateNewAchievement(
            string namespace_,
            Model.ModelsAchievementRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsAchievementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsAchievementResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsAchievementResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}