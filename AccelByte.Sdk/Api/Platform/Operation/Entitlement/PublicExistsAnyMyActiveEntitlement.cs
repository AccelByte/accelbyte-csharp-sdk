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
    /// publicExistsAnyMyActiveEntitlement
    ///
    /// Exists any my active entitlement of specified itemIds, skus and appIds
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class PublicExistsAnyMyActiveEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicExistsAnyMyActiveEntitlementBuilder Builder = new PublicExistsAnyMyActiveEntitlementBuilder();

        public class PublicExistsAnyMyActiveEntitlementBuilder
        {
            
            public List<string>? AppIds { get; set; }
            
            public List<string>? ItemIds { get; set; }
            
            public List<string>? Skus { get; set; }
            
            internal PublicExistsAnyMyActiveEntitlementBuilder() { }


            public PublicExistsAnyMyActiveEntitlementBuilder SetAppIds(List<string> _appIds)
            {
                AppIds = _appIds;
                return this;
            }

            public PublicExistsAnyMyActiveEntitlementBuilder SetItemIds(List<string> _itemIds)
            {
                ItemIds = _itemIds;
                return this;
            }

            public PublicExistsAnyMyActiveEntitlementBuilder SetSkus(List<string> _skus)
            {
                Skus = _skus;
                return this;
            }




            public PublicExistsAnyMyActiveEntitlement Build(
                string namespace_
            )
            {
                return new PublicExistsAnyMyActiveEntitlement(this,
                    namespace_                    
                );
            }
        }

        private PublicExistsAnyMyActiveEntitlement(PublicExistsAnyMyActiveEntitlementBuilder builder,
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

        public PublicExistsAnyMyActiveEntitlement(
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

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/any";

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