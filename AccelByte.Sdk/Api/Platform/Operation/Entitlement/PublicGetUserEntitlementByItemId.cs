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
    /// publicGetUserEntitlementByItemId
    ///
    /// Get user entitlement by itemId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class PublicGetUserEntitlementByItemId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserEntitlementByItemIdBuilder Builder = new PublicGetUserEntitlementByItemIdBuilder();

        public class PublicGetUserEntitlementByItemIdBuilder
            : OperationBuilder<PublicGetUserEntitlementByItemIdBuilder>
        {
            
            
            public string? EntitlementClazz { get; set; }
            
            
            internal PublicGetUserEntitlementByItemIdBuilder() { }


            public PublicGetUserEntitlementByItemIdBuilder SetEntitlementClazz(string _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }




            public PublicGetUserEntitlementByItemId Build(
                string namespace_,
                string userId,
                string itemId
            )
            {
                PublicGetUserEntitlementByItemId op = new PublicGetUserEntitlementByItemId(this,
                    namespace_,                    
                    userId,                    
                    itemId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetUserEntitlementByItemId(PublicGetUserEntitlementByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.EntitlementClazz != null) QueryParams["entitlementClazz"] = builder.EntitlementClazz;
            if (itemId != null) QueryParams["itemId"] = itemId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserEntitlementByItemId(
            string namespace_,            
            string userId,            
            string? entitlementClazz,            
            string itemId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (entitlementClazz != null) QueryParams["entitlementClazz"] = entitlementClazz;
            if (itemId != null) QueryParams["itemId"] = itemId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byItemId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.EntitlementInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}