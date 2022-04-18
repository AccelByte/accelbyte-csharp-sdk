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
    /// publicGetItem
    ///
    /// This API is used to get an item in locale. If item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Returns : item data
    /// </summary>
    public class PublicGetItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetItemBuilder Builder = new PublicGetItemBuilder();

        public class PublicGetItemBuilder
            : OperationBuilder<PublicGetItemBuilder>
        {
            
            
            public string? Language { get; set; }
            
            public bool? PopulateBundle { get; set; }
            
            public string? Region { get; set; }
            
            public string? StoreId { get; set; }
            
            internal PublicGetItemBuilder() { }


            public PublicGetItemBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetItemBuilder SetPopulateBundle(bool _populateBundle)
            {
                PopulateBundle = _populateBundle;
                return this;
            }

            public PublicGetItemBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicGetItemBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public PublicGetItem Build(
                string itemId,
                string namespace_
            )
            {
                PublicGetItem op = new PublicGetItem(this,
                    itemId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetItem(PublicGetItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.PopulateBundle != null) QueryParams["populateBundle"] = Convert.ToString(builder.PopulateBundle)!;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            

        }
        #endregion

        public PublicGetItem(
            string itemId,            
            string namespace_,            
            string? language,            
            bool? populateBundle,            
            string? region,            
            string? storeId            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            if (populateBundle != null) QueryParams["populateBundle"] = Convert.ToString(populateBundle)!;
            if (region != null) QueryParams["region"] = region;
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/{itemId}/locale";

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