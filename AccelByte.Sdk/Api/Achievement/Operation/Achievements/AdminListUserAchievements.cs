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
    /// AdminListUserAchievements
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT [READ]` and scope `social`
    /// </summary>
    public class AdminListUserAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUserAchievementsBuilder Builder = new AdminListUserAchievementsBuilder();

        public class AdminListUserAchievementsBuilder
            : OperationBuilder<AdminListUserAchievementsBuilder>
        {
            
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            public bool? PreferUnlocked { get; set; }
            
            internal AdminListUserAchievementsBuilder() { }


            public AdminListUserAchievementsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListUserAchievementsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListUserAchievementsBuilder SetPreferUnlocked(bool _preferUnlocked)
            {
                PreferUnlocked = _preferUnlocked;
                return this;
            }





            public AdminListUserAchievements Build(
                string namespace_,
                string userId
            )
            {
                AdminListUserAchievements op = new AdminListUserAchievements(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminListUserAchievements(AdminListUserAchievementsBuilder builder,
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

        public AdminListUserAchievements(
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

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements";

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