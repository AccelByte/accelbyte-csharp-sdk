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
    /// getCategory
    ///
    /// This API is used to get category by category path.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CATEGORY", action=2 (READ)
    ///   *  Returns : category data
    /// </summary>
    public class GetCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCategoryBuilder Builder = new GetCategoryBuilder();

        public class GetCategoryBuilder
        {
            
            
            public string? StoreId { get; set; }
            
            internal GetCategoryBuilder() { }


            public GetCategoryBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public GetCategory Build(
                string categoryPath,
                string namespace_
            )
            {
                return new GetCategory(this,
                    categoryPath,                    
                    namespace_                    
                );
            }
        }

        private GetCategory(GetCategoryBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            
        }
        #endregion

        public GetCategory(
            string categoryPath,            
            string namespace_,            
            string? storeId            
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories/{categoryPath}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.FullCategoryInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullCategoryInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullCategoryInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}