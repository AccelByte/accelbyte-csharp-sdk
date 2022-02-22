// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicGetUserPlatformAccountsV3
    ///
    /// 
    /// 
    /// This endpoint retrieves platform accounts linked to user. Required valid user authorization.
    /// 
    /// action code: 10128
    /// </summary>
    public class PublicGetUserPlatformAccountsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserPlatformAccountsV3Builder Builder = new PublicGetUserPlatformAccountsV3Builder();

        public class PublicGetUserPlatformAccountsV3Builder
        {
            
            
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public long? Limit { get; set; }
            
            internal PublicGetUserPlatformAccountsV3Builder() { }


            public PublicGetUserPlatformAccountsV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public PublicGetUserPlatformAccountsV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public PublicGetUserPlatformAccountsV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }




            public PublicGetUserPlatformAccountsV3 Build(
                string namespace_,
                string userId
            )
            {
                return new PublicGetUserPlatformAccountsV3(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicGetUserPlatformAccountsV3(PublicGetUserPlatformAccountsV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            
            
            
            
        }
        #endregion

        public PublicGetUserPlatformAccountsV3(
            string namespace_,            
            string userId,            
            string? after,            
            string? before,            
            long? limit            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/platforms";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountcommonUserLinkedPlatformsResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserLinkedPlatformsResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserLinkedPlatformsResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}