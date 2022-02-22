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
    /// PublicGetAchievement
    ///
    /// 
    /// 
    /// Required permission
    /// `NAMESPACE:{namespace}:ACHIEVEMENT [READ]` and scope `social`
    /// </summary>
    public class PublicGetAchievement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetAchievementBuilder Builder = new PublicGetAchievementBuilder();

        public class PublicGetAchievementBuilder
        {
            
            
            
            internal PublicGetAchievementBuilder() { }





            public PublicGetAchievement Build(
                string achievementCode,
                string namespace_,
                string language
            )
            {
                return new PublicGetAchievement(this,
                    achievementCode,                    
                    namespace_,                    
                    language                    
                );
            }
        }

        private PublicGetAchievement(PublicGetAchievementBuilder builder,
            string achievementCode,
            string namespace_,
            string language
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            
            
            
            
        }
        #endregion

        public PublicGetAchievement(
            string achievementCode,            
            string namespace_,            
            string language            
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            
            
            
            
        }

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/achievements/{achievementCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPublicAchievementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPublicAchievementResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPublicAchievementResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}