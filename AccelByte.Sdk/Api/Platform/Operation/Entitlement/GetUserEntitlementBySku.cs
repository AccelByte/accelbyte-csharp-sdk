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
    /// getUserEntitlementBySku
    ///
    /// Get user entitlement by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class GetUserEntitlementBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserEntitlementBySkuBuilder Builder = new GetUserEntitlementBySkuBuilder();

        public class GetUserEntitlementBySkuBuilder
            : OperationBuilder<GetUserEntitlementBySkuBuilder>
        {
            
            
            public bool? ActiveOnly { get; set; }
            
            public string? EntitlementClazz { get; set; }
            
            
            internal GetUserEntitlementBySkuBuilder() { }


            public GetUserEntitlementBySkuBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetUserEntitlementBySkuBuilder SetEntitlementClazz(string _entitlementClazz)
            {
                EntitlementClazz = _entitlementClazz;
                return this;
            }




            public GetUserEntitlementBySku Build(
                string namespace_,
                string userId,
                string sku
            )
            {
                GetUserEntitlementBySku op = new GetUserEntitlementBySku(this,
                    namespace_,                    
                    userId,                    
                    sku                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserEntitlementBySku(GetUserEntitlementBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.EntitlementClazz != null) QueryParams["entitlementClazz"] = builder.EntitlementClazz;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserEntitlementBySku(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            string? entitlementClazz,            
            string sku            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (entitlementClazz != null) QueryParams["entitlementClazz"] = entitlementClazz;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/bySku";

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