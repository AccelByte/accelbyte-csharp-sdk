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
    /// publicGetItemBySku
    ///
    /// This API is used to get the item by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Returns : the item with sku
    /// </summary>
    public class PublicGetItemBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetItemBySkuBuilder Builder = new PublicGetItemBySkuBuilder();

        public class PublicGetItemBySkuBuilder
        {
            
            public string? Language { get; set; }
            
            public string? Region { get; set; }
            
            public string? StoreId { get; set; }
            
            
            internal PublicGetItemBySkuBuilder() { }


            public PublicGetItemBySkuBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetItemBySkuBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicGetItemBySkuBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public PublicGetItemBySku Build(
                string namespace_,
                string sku
            )
            {
                return new PublicGetItemBySku(this,
                    namespace_,                    
                    sku                    
                );
            }
        }

        private PublicGetItemBySku(PublicGetItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            
        }
        #endregion

        public PublicGetItemBySku(
            string namespace_,            
            string? language,            
            string? region,            
            string? storeId,            
            string sku            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            if (region != null) QueryParams["region"] = region;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/bySku";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}