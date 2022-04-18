// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// GetPublicFollowing
    /// </summary>
    public class GetPublicFollowing : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPublicFollowingBuilder Builder = new GetPublicFollowingBuilder();

        public class GetPublicFollowingBuilder
            : OperationBuilder<GetPublicFollowingBuilder>
        {
            
            
            public string? Limit { get; set; }
            
            public string? Offset { get; set; }
            
            internal GetPublicFollowingBuilder() { }


            public GetPublicFollowingBuilder SetLimit(string _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetPublicFollowingBuilder SetOffset(string _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetPublicFollowing Build(
                string namespace_,
                string userId
            )
            {
                GetPublicFollowing op = new GetPublicFollowing(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetPublicFollowing(GetPublicFollowingBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = builder.Limit;
            if (builder.Offset != null) QueryParams["offset"] = builder.Offset;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPublicFollowing(
            string namespace_,            
            string userId,            
            string? limit,            
            string? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = limit;
            if (offset != null) QueryParams["offset"] = offset;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/following";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsPaginatedCreatorOverviewResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedCreatorOverviewResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedCreatorOverviewResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}