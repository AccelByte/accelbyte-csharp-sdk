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
    /// publicGetUserAppEntitlementOwnershipByAppId
    ///
    /// Get user app entitlement ownership by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class PublicGetUserAppEntitlementOwnershipByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserAppEntitlementOwnershipByAppIdBuilder Builder = new PublicGetUserAppEntitlementOwnershipByAppIdBuilder();

        public class PublicGetUserAppEntitlementOwnershipByAppIdBuilder
        {
            
            
            
            internal PublicGetUserAppEntitlementOwnershipByAppIdBuilder() { }





            public PublicGetUserAppEntitlementOwnershipByAppId Build(
                string namespace_,
                string userId,
                string appId
            )
            {
                return new PublicGetUserAppEntitlementOwnershipByAppId(this,
                    namespace_,                    
                    userId,                    
                    appId                    
                );
            }
        }

        private PublicGetUserAppEntitlementOwnershipByAppId(PublicGetUserAppEntitlementOwnershipByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (appId != null) QueryParams["appId"] = appId;
            
            
            
            
        }
        #endregion

        public PublicGetUserAppEntitlementOwnershipByAppId(
            string namespace_,            
            string userId,            
            string appId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (appId != null) QueryParams["appId"] = appId;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.Ownership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}