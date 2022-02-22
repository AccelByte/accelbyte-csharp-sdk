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
    /// publicGetEntitlementOwnershipToken
    ///
    /// Gets an entitlement ownership token of specified itemIds, skus and appIds
    /// 
    /// The decoded ownership token header like below:
    /// 
    /// 
    ///     {
    /// 
    ///       "kid": "9fd4cd5f991cebe3323605cd12d3b8bfdfc73fa4",
    /// 
    ///       "typ": "JWT",
    /// 
    ///       "alg": "RS256"
    /// 
    ///     }
    /// 
    /// 
    /// 
    /// That you can get the jwks by api /platform/jwks, if the configured private key is same as IAM,
    /// 
    /// you can also get jwks from IAM endpoint.
    /// 
    /// The decoded ownership token payload like below:
    /// 
    /// 
    ///     {
    /// 
    ///      "namespace": "accelbyte",
    /// 
    ///      "entitlements": [
    /// 
    ///       {
    /// 
    ///         "itemId": "4c1296291f604c199f7bb7f0ee02e5f8",
    /// 
    ///         "appType": null,
    /// 
    ///         "appId": null,
    /// 
    ///         "namespace": "accelbyte",
    /// 
    ///         "itemNamespace": "accelbyte",
    /// 
    ///         "sku": "prime-plus"
    /// 
    ///       },
    /// 
    ///       {
    /// 
    ///         "itemId": "e8f4974cf45c4e1f8d4f0c6990c518bd",
    /// 
    ///         "appType": "GAME",
    /// 
    ///         "appId": "omeganebula",
    /// 
    ///         "namespace": "accelbyte",
    /// 
    ///         "itemNamespace": "accelbyte",
    /// 
    ///         "sku": "APPG005ON"
    /// 
    ///       }
    /// 
    ///      ],
    /// 
    ///     "sub": "66459eb6a4e44e6fb0040bd20c1079a5",
    /// 
    ///     "exp": 1619624360,
    /// 
    ///     "iat": 1619624060
    /// 
    ///     }
    /// 
    /// 
    /// 
    /// if there's no active entitlement for the specific params, the entitlements section will be omitted.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class PublicGetEntitlementOwnershipToken : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetEntitlementOwnershipTokenBuilder Builder = new PublicGetEntitlementOwnershipTokenBuilder();

        public class PublicGetEntitlementOwnershipTokenBuilder
        {
            
            public List<string>? AppIds { get; set; }
            
            public List<string>? ItemIds { get; set; }
            
            public List<string>? Skus { get; set; }
            
            internal PublicGetEntitlementOwnershipTokenBuilder() { }


            public PublicGetEntitlementOwnershipTokenBuilder SetAppIds(List<string> _appIds)
            {
                AppIds = _appIds;
                return this;
            }

            public PublicGetEntitlementOwnershipTokenBuilder SetItemIds(List<string> _itemIds)
            {
                ItemIds = _itemIds;
                return this;
            }

            public PublicGetEntitlementOwnershipTokenBuilder SetSkus(List<string> _skus)
            {
                Skus = _skus;
                return this;
            }




            public PublicGetEntitlementOwnershipToken Build(
                string namespace_
            )
            {
                return new PublicGetEntitlementOwnershipToken(this,
                    namespace_                    
                );
            }
        }

        private PublicGetEntitlementOwnershipToken(PublicGetEntitlementOwnershipTokenBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.AppIds != null) QueryParams["appIds"] = builder.AppIds;
            if (builder.ItemIds != null) QueryParams["itemIds"] = builder.ItemIds;
            if (builder.Skus != null) QueryParams["skus"] = builder.Skus;
            
            
            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";
            
            
        }
        #endregion

        public PublicGetEntitlementOwnershipToken(
            string namespace_,            
            List<string>? appIds,            
            List<string>? itemIds,            
            List<string>? skus            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (appIds != null) QueryParams["appIds"] = appIds;
            if (itemIds != null) QueryParams["itemIds"] = itemIds;
            if (skus != null) QueryParams["skus"] = skus;
            
            
            CollectionFormatMap["appIds"] = "multi";
            CollectionFormatMap["itemIds"] = "multi";
            CollectionFormatMap["skus"] = "multi";
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/entitlements/ownershipToken";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OwnershipToken? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OwnershipToken>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OwnershipToken>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}