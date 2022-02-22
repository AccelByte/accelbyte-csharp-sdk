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
    /// publicQueryUserEntitlementsByAppType
    ///
    /// Query app entitlements by appType.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    ///   *  Returns : app entitlement pagination
    /// </summary>
    public class PublicQueryUserEntitlementsByAppType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserEntitlementsByAppTypeBuilder Builder = new PublicQueryUserEntitlementsByAppTypeBuilder();

        public class PublicQueryUserEntitlementsByAppTypeBuilder
        {
            
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            
            internal PublicQueryUserEntitlementsByAppTypeBuilder() { }


            public PublicQueryUserEntitlementsByAppTypeBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserEntitlementsByAppTypeBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }




            public PublicQueryUserEntitlementsByAppType Build(
                string namespace_,
                string userId,
                string appType
            )
            {
                return new PublicQueryUserEntitlementsByAppType(this,
                    namespace_,                    
                    userId,                    
                    appType                    
                );
            }
        }

        private PublicQueryUserEntitlementsByAppType(PublicQueryUserEntitlementsByAppTypeBuilder builder,
            string namespace_,
            string userId,
            string appType
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (appType != null) QueryParams["appType"] = appType;
            
            
            
            
        }
        #endregion

        public PublicQueryUserEntitlementsByAppType(
            string namespace_,            
            string userId,            
            int? limit,            
            int? offset,            
            string appType            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (appType != null) QueryParams["appType"] = appType;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppType";

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