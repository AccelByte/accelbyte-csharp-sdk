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
    /// ExportAchievements
    ///
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [READ]
    /// 
    /// Required Scope: social
    /// </summary>
    public class ExportAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExportAchievementsBuilder Builder = new ExportAchievementsBuilder();

        public class ExportAchievementsBuilder
        {
            
            internal ExportAchievementsBuilder() { }





            public ExportAchievements Build(
                string namespace_
            )
            {
                return new ExportAchievements(this,
                    namespace_                    
                );
            }
        }

        private ExportAchievements(ExportAchievementsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public ExportAchievements(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements/export";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelsAchievement>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsAchievement>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsAchievement>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}