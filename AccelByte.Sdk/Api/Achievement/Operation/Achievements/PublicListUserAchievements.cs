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
    /// PublicListUserAchievements
    ///
    /// 
    /// 
    /// Required permission
    /// `NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT [READ]` and scope `social`
    /// 
    /// 
    /// 
    /// 
    /// Note: user achievement status value mean: `status = 1 (in progress)` and `status = 2 (unlocked)
    /// 
    /// `
    /// </summary>
    public class PublicListUserAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListUserAchievementsBuilder Builder = new PublicListUserAchievementsBuilder();

        public class PublicListUserAchievementsBuilder
            : OperationBuilder<PublicListUserAchievementsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public bool? PreferUnlocked { get; set; }





            internal PublicListUserAchievementsBuilder() { }


            public PublicListUserAchievementsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListUserAchievementsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListUserAchievementsBuilder SetPreferUnlocked(bool _preferUnlocked)
            {
                PreferUnlocked = _preferUnlocked;
                return this;
            }





            public PublicListUserAchievements Build(
                string namespace_,
                string userId
            )
            {
                PublicListUserAchievements op = new PublicListUserAchievements(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicListUserAchievements(PublicListUserAchievementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PreferUnlocked != null) QueryParams["preferUnlocked"] = Convert.ToString(builder.PreferUnlocked)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListUserAchievements(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset,            
            bool? preferUnlocked            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (preferUnlocked != null) QueryParams["preferUnlocked"] = Convert.ToString(preferUnlocked)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsPaginatedUserAchievementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedUserAchievementResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedUserAchievementResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}