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
    /// GetUserLoginHistories
    ///
    /// Required permission 'NAMESPACE:{namespace}:HISTORY:LOGIN:USER:{userId} [READ]'
    /// 
    /// Notes for this endpoint:
    /// 
    ///     * This endpoint retrieve the first page of the data if `after` and `before` parameters is empty.
    ///     * The maximum value of the limit is 100 and the minimum value of the limit is 1.
    ///     * This endpoint retrieve the next page of the data if we provide `after` parameters with valid Unix timestamp.
    ///     * This endpoint retrieve the previous page of the data if we provide `before` parameter with valid data Unix timestamp.
    /// </summary>
    public class GetUserLoginHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserLoginHistoriesBuilder Builder = new GetUserLoginHistoriesBuilder();

        public class GetUserLoginHistoriesBuilder
        {
            
            
            public double? After { get; set; }
            
            public double? Before { get; set; }
            
            public long? Limit { get; set; }
            
            internal GetUserLoginHistoriesBuilder() { }


            public GetUserLoginHistoriesBuilder SetAfter(double _after)
            {
                After = _after;
                return this;
            }

            public GetUserLoginHistoriesBuilder SetBefore(double _before)
            {
                Before = _before;
                return this;
            }

            public GetUserLoginHistoriesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }




            public GetUserLoginHistories Build(
                string namespace_,
                string userId
            )
            {
                return new GetUserLoginHistories(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GetUserLoginHistories(GetUserLoginHistoriesBuilder builder,
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

        public GetUserLoginHistories(
            string namespace_,            
            string userId,            
            double? after,            
            double? before,            
            long? limit            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (after != null) QueryParams["after"] = Convert.ToString(after)!;
            if (before != null) QueryParams["before"] = Convert.ToString(before)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/logins/histories";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

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