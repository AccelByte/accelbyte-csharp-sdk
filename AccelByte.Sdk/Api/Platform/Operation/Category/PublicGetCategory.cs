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
    /// publicGetCategory
    ///
    /// This API is used to get category by category path.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store category)
    ///   *  Optional permission : resource="SANDBOX", action=1 (CREATE)(user with this permission can view draft store category)
    ///   *  Returns : category data
    /// </summary>
    public class PublicGetCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCategoryBuilder Builder = new PublicGetCategoryBuilder();

        public class PublicGetCategoryBuilder
        {
            
            
            public string? Language { get; set; }
            
            public string? StoreId { get; set; }
            
            internal PublicGetCategoryBuilder() { }


            public PublicGetCategoryBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetCategoryBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public PublicGetCategory Build(
                string categoryPath,
                string namespace_
            )
            {
                return new PublicGetCategory(this,
                    categoryPath,                    
                    namespace_                    
                );
            }
        }

        private PublicGetCategory(PublicGetCategoryBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            
        }
        #endregion

        public PublicGetCategory(
            string categoryPath,            
            string namespace_,            
            string? language,            
            string? storeId            
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/categories/{categoryPath}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CategoryInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CategoryInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CategoryInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}