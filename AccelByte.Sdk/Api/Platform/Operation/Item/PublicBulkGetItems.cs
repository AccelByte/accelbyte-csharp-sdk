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
    /// publicBulkGetItems
    ///
    /// This API is used to bulk get locale items. If item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store items)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store items)
    ///   *  Returns : the list of items info
    /// </summary>
    public class PublicBulkGetItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBulkGetItemsBuilder Builder = new PublicBulkGetItemsBuilder();

        public class PublicBulkGetItemsBuilder
            : OperationBuilder<PublicBulkGetItemsBuilder>
        {
            
            public string? Language { get; set; }
            
            public string? Region { get; set; }
            
            public string? StoreId { get; set; }
            
            
            internal PublicBulkGetItemsBuilder() { }


            public PublicBulkGetItemsBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicBulkGetItemsBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicBulkGetItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public PublicBulkGetItems Build(
                string namespace_,
                string itemIds
            )
            {
                PublicBulkGetItems op = new PublicBulkGetItems(this,
                    namespace_,                    
                    itemIds                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicBulkGetItems(PublicBulkGetItemsBuilder builder,
            string namespace_,
            string itemIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (itemIds != null) QueryParams["itemIds"] = itemIds;
            
            
            
            

        }
        #endregion

        public PublicBulkGetItems(
            string namespace_,            
            string? language,            
            string? region,            
            string? storeId,            
            string itemIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            if (region != null) QueryParams["region"] = region;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (itemIds != null) QueryParams["itemIds"] = itemIds;
            
            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/locale/byIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ItemInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ItemInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ItemInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}