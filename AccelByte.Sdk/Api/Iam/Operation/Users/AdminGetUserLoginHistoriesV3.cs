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
    /// AdminGetUserLoginHistoriesV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:HISTORY:LOGIN:USER:{userId} [READ]'
    /// 
    /// Notes for this endpoint:
    /// 
    ///             * This endpoint retrieve the first page of the data if `after` and `before` parameters is empty.
    ///             * The maximum value of the limit is 100 and the minimum value of the limit is 1.
    ///             * This endpoint retrieve the next page of the data if we provide `after` parameters with valid Unix timestamp.
    ///             * This endpoint retrieve the previous page of the data if we provide `before` parameter with valid data Unix timestamp.
    /// </summary>
    public class AdminGetUserLoginHistoriesV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserLoginHistoriesV3Builder Builder = new AdminGetUserLoginHistoriesV3Builder();

        public class AdminGetUserLoginHistoriesV3Builder
        {
            
            
            public double? After { get; set; }
            
            public double? Before { get; set; }
            
            public double? Limit { get; set; }
            
            internal AdminGetUserLoginHistoriesV3Builder() { }


            public AdminGetUserLoginHistoriesV3Builder SetAfter(double _after)
            {
                After = _after;
                return this;
            }

            public AdminGetUserLoginHistoriesV3Builder SetBefore(double _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetUserLoginHistoriesV3Builder SetLimit(double _limit)
            {
                Limit = _limit;
                return this;
            }




            public AdminGetUserLoginHistoriesV3 Build(
                string namespace_,
                string userId
            )
            {
                return new AdminGetUserLoginHistoriesV3(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminGetUserLoginHistoriesV3(AdminGetUserLoginHistoriesV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.After != null) QueryParams["after"] = Convert.ToString(builder.After)!;
            if (builder.Before != null) QueryParams["before"] = Convert.ToString(builder.Before)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            
            
            
            
        }
        #endregion

        public AdminGetUserLoginHistoriesV3(
            string namespace_,            
            string userId,            
            double? after,            
            double? before,            
            double? limit            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (after != null) QueryParams["after"] = Convert.ToString(after)!;
            if (before != null) QueryParams["before"] = Convert.ToString(before)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/logins/histories";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelLoginHistoriesResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLoginHistoriesResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLoginHistoriesResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}