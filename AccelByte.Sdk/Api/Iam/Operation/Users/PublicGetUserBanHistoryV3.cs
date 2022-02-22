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
    /// PublicGetUserBanHistoryV3
    ///
    /// Required valid user authorization.
    /// 
    /// 
    /// Notes:
    /// 
    /// 
    /// 
    /// 
    ///                       * This endpoint retrieve the first page of the data if after and before parameters is empty
    /// 
    /// 
    ///                       * The pagination is not working yet
    /// </summary>
    public class PublicGetUserBanHistoryV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserBanHistoryV3Builder Builder = new PublicGetUserBanHistoryV3Builder();

        public class PublicGetUserBanHistoryV3Builder
        {
            
            
            public bool? ActiveOnly { get; set; }
            
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public long? Limit { get; set; }
            
            internal PublicGetUserBanHistoryV3Builder() { }


            public PublicGetUserBanHistoryV3Builder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public PublicGetUserBanHistoryV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public PublicGetUserBanHistoryV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public PublicGetUserBanHistoryV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }




            public PublicGetUserBanHistoryV3 Build(
                string namespace_,
                string userId
            )
            {
                return new PublicGetUserBanHistoryV3(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicGetUserBanHistoryV3(PublicGetUserBanHistoryV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            
            
            
            
        }
        #endregion

        public PublicGetUserBanHistoryV3(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            string? after,            
            string? before,            
            long? limit            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetUserBanV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}