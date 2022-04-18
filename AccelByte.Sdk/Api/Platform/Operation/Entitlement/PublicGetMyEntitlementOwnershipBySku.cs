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
    /// publicGetMyEntitlementOwnershipBySku
    ///
    /// Get my entitlement ownership by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:ENTITLEMENT", action=2 (READ)
    ///   *  Path's namespace :
    ///     * can be filled with publisher namespace in order to get publisher namespace entitlement ownership by sku
    ///     * can be filled with game namespace in order to get game namespace entitlement ownership by sku
    /// </summary>
    public class PublicGetMyEntitlementOwnershipBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyEntitlementOwnershipBySkuBuilder Builder = new PublicGetMyEntitlementOwnershipBySkuBuilder();

        public class PublicGetMyEntitlementOwnershipBySkuBuilder
            : OperationBuilder<PublicGetMyEntitlementOwnershipBySkuBuilder>
        {
            
            public string? EntitlementClazz { get; set; }
            
            
            internal PublicGetMyEntitlementOwnershipBySkuBuilder() { }


            public PublicGetMyEntitlementOwnershipBySkuBuilder SetEntitlementClazz(string _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }




            public PublicGetMyEntitlementOwnershipBySku Build(
                string namespace_,
                string sku
            )
            {
                PublicGetMyEntitlementOwnershipBySku op = new PublicGetMyEntitlementOwnershipBySku(this,
                    namespace_,                    
                    sku                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetMyEntitlementOwnershipBySku(PublicGetMyEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.EntitlementClazz != null) QueryParams["entitlementClazz"] = builder.EntitlementClazz;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetMyEntitlementOwnershipBySku(
            string namespace_,            
            string? entitlementClazz,            
            string sku            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (entitlementClazz != null) QueryParams["entitlementClazz"] = entitlementClazz;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/bySku";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.TimedOwnership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TimedOwnership>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TimedOwnership>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}