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
    /// downloadCategories
    ///
    /// This API is used to download store's structured categories.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store content)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store content)
    ///   *  Returns : structured categories
    /// </summary>
    public class DownloadCategories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DownloadCategoriesBuilder Builder = new DownloadCategoriesBuilder();

        public class DownloadCategoriesBuilder
            : OperationBuilder<DownloadCategoriesBuilder>
        {
            
            public string? Language { get; set; }
            
            public string? StoreId { get; set; }
            
            internal DownloadCategoriesBuilder() { }


            public DownloadCategoriesBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public DownloadCategoriesBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public DownloadCategories Build(
                string namespace_
            )
            {
                DownloadCategories op = new DownloadCategories(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DownloadCategories(DownloadCategoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            

        }
        #endregion

        public DownloadCategories(
            string namespace_,            
            string? language,            
            string? storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/categories/download";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.HierarchicalCategoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.HierarchicalCategoryInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.HierarchicalCategoryInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}