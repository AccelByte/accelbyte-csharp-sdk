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
    /// publicSearchItems
    ///
    /// This API is used to search items by keyword in title, description and long description, It's language constrained, also if item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Returns : the list of items
    /// </summary>
    public class PublicSearchItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSearchItemsBuilder Builder = new PublicSearchItemsBuilder();

        public class PublicSearchItemsBuilder
            : OperationBuilder<PublicSearchItemsBuilder>
        {
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? Region { get; set; }
            
            public string? StoreId { get; set; }
            
            
            
            internal PublicSearchItemsBuilder() { }


            public PublicSearchItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicSearchItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicSearchItemsBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicSearchItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public PublicSearchItems Build(
                string namespace_,
                string keyword,
                string language
            )
            {
                PublicSearchItems op = new PublicSearchItems(this,
                    namespace_,                    
                    keyword,                    
                    language                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicSearchItems(PublicSearchItemsBuilder builder,
            string namespace_,
            string keyword,
            string language
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (keyword != null) QueryParams["keyword"] = keyword;
            if (language != null) QueryParams["language"] = language;
            
            
            
            

        }
        #endregion

        public PublicSearchItems(
            string namespace_,            
            int? limit,            
            int? offset,            
            string? region,            
            string? storeId,            
            string keyword,            
            string language            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region != null) QueryParams["region"] = region;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (keyword != null) QueryParams["keyword"] = keyword;
            if (language != null) QueryParams["language"] = language;
            
            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}