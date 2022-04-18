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
    /// getLocaleItemBySku
    ///
    /// This API is used to get an item by sku in specific locale. If item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : item data
    /// </summary>
    public class GetLocaleItemBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLocaleItemBySkuBuilder Builder = new GetLocaleItemBySkuBuilder();

        public class GetLocaleItemBySkuBuilder
            : OperationBuilder<GetLocaleItemBySkuBuilder>
        {
            
            public bool? ActiveOnly { get; set; }
            
            public string? Language { get; set; }
            
            public bool? PopulateBundle { get; set; }
            
            public string? Region { get; set; }
            
            public string? StoreId { get; set; }
            
            
            internal GetLocaleItemBySkuBuilder() { }


            public GetLocaleItemBySkuBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetLocaleItemBySkuBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public GetLocaleItemBySkuBuilder SetPopulateBundle(bool _populateBundle)
            {
                PopulateBundle = _populateBundle;
                return this;
            }

            public GetLocaleItemBySkuBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public GetLocaleItemBySkuBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public GetLocaleItemBySku Build(
                string namespace_,
                string sku
            )
            {
                GetLocaleItemBySku op = new GetLocaleItemBySku(this,
                    namespace_,                    
                    sku                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetLocaleItemBySku(GetLocaleItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.PopulateBundle != null) QueryParams["populateBundle"] = Convert.ToString(builder.PopulateBundle)!;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLocaleItemBySku(
            string namespace_,            
            bool? activeOnly,            
            string? language,            
            bool? populateBundle,            
            string? region,            
            string? storeId,            
            string sku            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (language != null) QueryParams["language"] = language;
            if (populateBundle != null) QueryParams["populateBundle"] = Convert.ToString(populateBundle)!;
            if (region != null) QueryParams["region"] = region;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/bySku/locale";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.PopulatedItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PopulatedItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PopulatedItemInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}