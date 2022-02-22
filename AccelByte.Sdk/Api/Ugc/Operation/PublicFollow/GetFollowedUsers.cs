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
    /// GetFollowedUsers
    ///
    /// Requires valid user token
    /// </summary>
    public class GetFollowedUsers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetFollowedUsersBuilder Builder = new GetFollowedUsersBuilder();

        public class GetFollowedUsersBuilder
        {
            
            public string? Limit { get; set; }
            
            public string? Offset { get; set; }
            
            internal GetFollowedUsersBuilder() { }


            public GetFollowedUsersBuilder SetLimit(string _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetFollowedUsersBuilder SetOffset(string _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetFollowedUsers Build(
                string namespace_
            )
            {
                return new GetFollowedUsers(this,
                    namespace_                    
                );
            }
        }

        private GetFollowedUsers(GetFollowedUsersBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = builder.Limit;
            if (builder.Offset != null) QueryParams["offset"] = builder.Offset;
            
            
            
            
        }
        #endregion

        public GetFollowedUsers(
            string namespace_,            
            string? limit,            
            string? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = limit;
            if (offset != null) QueryParams["offset"] = offset;
            
            
            
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/followed";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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