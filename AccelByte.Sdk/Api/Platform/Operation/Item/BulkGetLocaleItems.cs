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
    /// bulkGetLocaleItems
    ///
    /// This API is used to bulk get locale items. If item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the list of items info
    /// </summary>
    public class BulkGetLocaleItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetLocaleItemsBuilder Builder { get => new BulkGetLocaleItemsBuilder(); }

        public class BulkGetLocaleItemsBuilder
            : OperationBuilder<BulkGetLocaleItemsBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? Language { get; set; }

            public string? Region { get; set; }

            public string? StoreId { get; set; }





            internal BulkGetLocaleItemsBuilder() { }


            public BulkGetLocaleItemsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public BulkGetLocaleItemsBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public BulkGetLocaleItemsBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public BulkGetLocaleItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public BulkGetLocaleItems Build(
                string namespace_,
                string itemIds
            )
            {
                BulkGetLocaleItems op = new BulkGetLocaleItems(this,
                    namespace_,                    
                    itemIds                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkGetLocaleItems(BulkGetLocaleItemsBuilder builder,
            string namespace_,
            string itemIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetLocaleItems(
            string namespace_,            
            bool? activeOnly,            
            string? language,            
            string? region,            
            string? storeId,            
            string itemIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (language is not null) QueryParams["language"] = language;
            if (region is not null) QueryParams["region"] = region;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/locale/byIds";

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