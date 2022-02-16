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
    /// AdminUpdateAchievement
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [UPDATE]` and scope `social`
    /// </summary>
    public class AdminUpdateAchievement : AccelByte.Sdk.Core.Operation
    {
        public AdminUpdateAchievement(
            string achievementCode,            
            string namespace_,            
            Model.ModelsAchievementUpdateRequest body            
        )
        {
            PathParams["achievementCode"] = achievementCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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