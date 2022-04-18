// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// AdminUpdateAchievementListOrder
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [UPDATE]` and scope `social`
    /// </summary>
    public class AdminUpdateAchievementListOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateAchievementListOrderBuilder Builder = new AdminUpdateAchievementListOrderBuilder();

        public class AdminUpdateAchievementListOrderBuilder
            : OperationBuilder<AdminUpdateAchievementListOrderBuilder>
        {
            
            
            
            internal AdminUpdateAchievementListOrderBuilder() { }





            public AdminUpdateAchievementListOrder Build(
                ModelsAchievementOrderUpdateRequest body,
                string achievementCode,
                string namespace_
            )
            {
                AdminUpdateAchievementListOrder op = new AdminUpdateAchievementListOrder(this,
                    body,                    
                    achievementCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateAchievementListOrder(AdminUpdateAchievementListOrderBuilder builder,
            ModelsAchievementOrderUpdateRequest body,
            string achievementCode,
            string namespace_
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateAchievementListOrder(
            string achievementCode,            
            string namespace_,            
            Model.ModelsAchievementOrderUpdateRequest body            
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}";

        public override HttpMethod Method => HttpMethod.Patch;

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