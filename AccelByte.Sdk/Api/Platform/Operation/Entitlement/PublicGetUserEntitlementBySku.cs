// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicGetUserEntitlementBySku
    ///
    /// Get user entitlement by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class PublicGetUserEntitlementBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserEntitlementBySkuBuilder Builder { get => new PublicGetUserEntitlementBySkuBuilder(); }

        public class PublicGetUserEntitlementBySkuBuilder
            : OperationBuilder<PublicGetUserEntitlementBySkuBuilder>
        {

            public PublicGetUserEntitlementBySkuEntitlementClazz? EntitlementClazz { get; set; }





            internal PublicGetUserEntitlementBySkuBuilder() { }


            public PublicGetUserEntitlementBySkuBuilder SetEntitlementClazz(PublicGetUserEntitlementBySkuEntitlementClazz _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }





            public PublicGetUserEntitlementBySku Build(
                string namespace_,
                string userId,
                string sku
            )
            {
                PublicGetUserEntitlementBySku op = new PublicGetUserEntitlementBySku(this,
                    namespace_,                    
                    userId,                    
                    sku                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetUserEntitlementBySku(PublicGetUserEntitlementBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.EntitlementClazz is not null) QueryParams["entitlementClazz"] = builder.EntitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserEntitlementBySku(
            string namespace_,            
            string userId,            
            PublicGetUserEntitlementBySkuEntitlementClazz? entitlementClazz,            
            string sku            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (entitlementClazz is not null) QueryParams["entitlementClazz"] = entitlementClazz.Value;
            if (sku is not null) QueryParams["sku"] = sku;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/bySku";

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

    public class PublicGetUserEntitlementBySkuEntitlementClazz : StringEnum<PublicGetUserEntitlementBySkuEntitlementClazz>
    {
        public static readonly PublicGetUserEntitlementBySkuEntitlementClazz APP
            = new PublicGetUserEntitlementBySkuEntitlementClazz("APP");

        public static readonly PublicGetUserEntitlementBySkuEntitlementClazz CODE
            = new PublicGetUserEntitlementBySkuEntitlementClazz("CODE");

        public static readonly PublicGetUserEntitlementBySkuEntitlementClazz ENTITLEMENT
            = new PublicGetUserEntitlementBySkuEntitlementClazz("ENTITLEMENT");

        public static readonly PublicGetUserEntitlementBySkuEntitlementClazz LOOTBOX
            = new PublicGetUserEntitlementBySkuEntitlementClazz("LOOTBOX");

        public static readonly PublicGetUserEntitlementBySkuEntitlementClazz MEDIA
            = new PublicGetUserEntitlementBySkuEntitlementClazz("MEDIA");

        public static readonly PublicGetUserEntitlementBySkuEntitlementClazz OPTIONBOX
            = new PublicGetUserEntitlementBySkuEntitlementClazz("OPTIONBOX");

        public static readonly PublicGetUserEntitlementBySkuEntitlementClazz SUBSCRIPTION
            = new PublicGetUserEntitlementBySkuEntitlementClazz("SUBSCRIPTION");


        public static implicit operator PublicGetUserEntitlementBySkuEntitlementClazz(string value)
        {
            return NewValue(value);
        }

        public PublicGetUserEntitlementBySkuEntitlementClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

}