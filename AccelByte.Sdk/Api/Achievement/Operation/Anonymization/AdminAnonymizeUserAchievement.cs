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
    /// AdminAnonymizeUserAchievement
    ///
    /// This API will delete specified user achievement
    /// 
    /// 
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:USER:{userId}:ANONYMIZATION [DELETE]`
    /// </summary>
    public class AdminAnonymizeUserAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAnonymizeUserAchievementBuilder Builder = new AdminAnonymizeUserAchievementBuilder();

        public class AdminAnonymizeUserAchievementBuilder
            : OperationBuilder<AdminAnonymizeUserAchievementBuilder>
        {





            internal AdminAnonymizeUserAchievementBuilder() { }






            public AdminAnonymizeUserAchievement Build(
                string namespace_,
                string userId
            )
            {
                AdminAnonymizeUserAchievement op = new AdminAnonymizeUserAchievement(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminAnonymizeUserAchievement(AdminAnonymizeUserAchievementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAnonymizeUserAchievement(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/users/{userId}/anonymization/achievements";

        public override HttpMethod Method => HttpMethod.Delete;

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