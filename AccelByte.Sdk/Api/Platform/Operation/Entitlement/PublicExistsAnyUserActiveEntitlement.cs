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
    /// publicExistsAnyUserActiveEntitlement
    ///
    /// Exists any user active entitlement of specified itemIds, skus and appIds
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class PublicExistsAnyUserActiveEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicExistsAnyUserActiveEntitlementBuilder Builder = new PublicExistsAnyUserActiveEntitlementBuilder();

        public class PublicExistsAnyUserActiveEntitlementBuilder
            : OperationBuilder<PublicExistsAnyUserActiveEntitlementBuilder>
        {
            
            
            public List<string>? AppIds { get; set; }
            
            public List<string>? ItemIds { get; set; }
            
            public List<string>? Skus { get; set; }
            
            internal PublicExistsAnyUserActiveEntitlementBuilder() { }


            public PublicExistsAnyUserActiveEntitlementBuilder SetAppIds(List<string> _appIds)
            {
                AppIds = _appIds;
                return this;
            }

            public PublicExistsAnyUserActiveEntitlementBuilder SetItemIds(List<string> _itemIds)
            {
                ItemIds = _itemIds;
                return this;
            }

            public PublicExistsAnyUserActiveEntitlementBuilder SetSkus(List<string> _skus)
            {
                Skus = _skus;
                return this;
            }




            public PublicExistsAnyUserActiveEntitlement Build(
                string namespace_,
                string userId
            )
            {
                PublicExistsAnyUserActiveEntitlement op = new PublicExistsAnyUserActiveEntitlement(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicExistsAnyUserActiveEntitlement(PublicExistsAnyUserActiveEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.AppIds != null) QueryParams["appIds"] = builder.AppIds;
            if (builder.ItemIds != null) QueryParams["itemIds"] = builder.ItemIds;
            if (builder.Skus != null) QueryParams["skus"] = builder.Skus;
            
            
            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicExistsAnyUserActiveEntitlement(
            string namespace_,            
            string userId,            
            List<string>? appIds,            
            List<string>? itemIds,            
            List<string>? skus            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (appIds != null) QueryParams["appIds"] = appIds;
            if (itemIds != null) QueryParams["itemIds"] = itemIds;
            if (skus != null) QueryParams["skus"] = skus;
            
            
            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/any";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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