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
    /// PublicListAchievements
    ///
    /// 
    /// 
    /// Required permission
    /// `NAMESPACE:{namespace}:ACHIEVEMENT [READ]` and scope `social`
    /// </summary>
    public class PublicListAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListAchievementsBuilder Builder = new PublicListAchievementsBuilder();

        public class PublicListAchievementsBuilder
            : OperationBuilder<PublicListAchievementsBuilder>
        {
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            public string? SortBy { get; set; }
            
            
            internal PublicListAchievementsBuilder() { }


            public PublicListAchievementsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListAchievementsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListAchievementsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public PublicListAchievements Build(
                string namespace_,
                string language
            )
            {
                PublicListAchievements op = new PublicListAchievements(this,
                    namespace_,                    
                    language                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicListAchievements(PublicListAchievementsBuilder builder,
            string namespace_,
            string language
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy != null) QueryParams["sortBy"] = builder.SortBy;
            if (language != null) QueryParams["language"] = language;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListAchievements(
            string namespace_,            
            long? limit,            
            long? offset,            
            string? sortBy,            
            string language            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (language != null) QueryParams["language"] = language;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/achievements";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsPublicAchievementsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPublicAchievementsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPublicAchievementsResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}