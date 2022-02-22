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
    /// publicGetRootCategories
    ///
    /// This API is used to get root categories.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store category)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store category)
    ///   *  Returns : root category data
    /// </summary>
    public class PublicGetRootCategories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetRootCategoriesBuilder Builder = new PublicGetRootCategoriesBuilder();

        public class PublicGetRootCategoriesBuilder
        {
            
            public string? Language { get; set; }
            
            public string? StoreId { get; set; }
            
            internal PublicGetRootCategoriesBuilder() { }


            public PublicGetRootCategoriesBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetRootCategoriesBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public PublicGetRootCategories Build(
                string namespace_
            )
            {
                return new PublicGetRootCategories(this,
                    namespace_                    
                );
            }
        }

        private PublicGetRootCategories(PublicGetRootCategoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            
        }
        #endregion

        public PublicGetRootCategories(
            string namespace_,            
            string? language,            
            string? storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/categories";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.CategoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.CategoryInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.CategoryInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}