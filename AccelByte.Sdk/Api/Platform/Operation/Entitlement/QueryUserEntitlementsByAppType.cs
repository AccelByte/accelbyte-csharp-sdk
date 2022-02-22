// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryUserEntitlementsByAppType
    ///
    /// Query app entitlements by appType.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2
    ///   *  Returns : app entitlement pagination
    /// </summary>
    public class QueryUserEntitlementsByAppType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserEntitlementsByAppTypeBuilder Builder = new QueryUserEntitlementsByAppTypeBuilder();

        public class QueryUserEntitlementsByAppTypeBuilder
        {
            
            
            public bool? ActiveOnly { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            
            internal QueryUserEntitlementsByAppTypeBuilder() { }


            public QueryUserEntitlementsByAppTypeBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryUserEntitlementsByAppTypeBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUserEntitlementsByAppTypeBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }




            public QueryUserEntitlementsByAppType Build(
                string namespace_,
                string userId,
                string appType
            )
            {
                return new QueryUserEntitlementsByAppType(this,
                    namespace_,                    
                    userId,                    
                    appType                    
                );
            }
        }

        private QueryUserEntitlementsByAppType(QueryUserEntitlementsByAppTypeBuilder builder,
            string namespace_,
            string userId,
            string appType
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (appType != null) QueryParams["appType"] = appType;
            
            
            
            
        }
        #endregion

        public QueryUserEntitlementsByAppType(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            int? limit,            
            int? offset,            
            string appType            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (appType != null) QueryParams["appType"] = appType;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppType";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AppEntitlementPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}