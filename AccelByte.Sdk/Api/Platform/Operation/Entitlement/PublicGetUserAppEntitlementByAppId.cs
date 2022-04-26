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
    /// publicGetUserAppEntitlementByAppId
    ///
    /// Get user app entitlement by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class PublicGetUserAppEntitlementByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserAppEntitlementByAppIdBuilder Builder = new PublicGetUserAppEntitlementByAppIdBuilder();

        public class PublicGetUserAppEntitlementByAppIdBuilder
            : OperationBuilder<PublicGetUserAppEntitlementByAppIdBuilder>
        {
            
            
            
            internal PublicGetUserAppEntitlementByAppIdBuilder() { }






            public PublicGetUserAppEntitlementByAppId Build(
                string namespace_,
                string userId,
                string appId
            )
            {
                PublicGetUserAppEntitlementByAppId op = new PublicGetUserAppEntitlementByAppId(this,
                    namespace_,                    
                    userId,                    
                    appId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetUserAppEntitlementByAppId(PublicGetUserAppEntitlementByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (appId != null) QueryParams["appId"] = appId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserAppEntitlementByAppId(
            string namespace_,            
            string userId,            
            string appId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (appId != null) QueryParams["appId"] = appId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AppEntitlementInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}