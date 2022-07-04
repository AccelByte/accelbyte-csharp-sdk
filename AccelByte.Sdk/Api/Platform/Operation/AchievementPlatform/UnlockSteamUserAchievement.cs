// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// unlockSteamUserAchievement
    ///
    /// This API is used to unlock steam achievement.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT, action=4 (UPDATE)
    /// </summary>
    public class UnlockSteamUserAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UnlockSteamUserAchievementBuilder Builder = new UnlockSteamUserAchievementBuilder();

        public class UnlockSteamUserAchievementBuilder
            : OperationBuilder<UnlockSteamUserAchievementBuilder>
        {


            public Model.ADTOObjectForUnlockSteamAchievementAPI? Body { get; set; }




            internal UnlockSteamUserAchievementBuilder() { }



            public UnlockSteamUserAchievementBuilder SetBody(Model.ADTOObjectForUnlockSteamAchievementAPI _body)
            {
                Body = _body;
                return this;
            }




            public UnlockSteamUserAchievement Build(
                string namespace_,
                string userId
            )
            {
                UnlockSteamUserAchievement op = new UnlockSteamUserAchievement(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UnlockSteamUserAchievement(UnlockSteamUserAchievementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UnlockSteamUserAchievement(
            string namespace_,            
            string userId,            
            Model.ADTOObjectForUnlockSteamAchievementAPI body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/achievement/steam";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if ( code == (HttpStatusCode)400 || code == (HttpStatusCode)404 )
            {
                var payloadString = Helper.ConvertInputStreamToString(payload);
                
                throw new HttpResponseException(code, payloadString);
            }
        }
    }

}