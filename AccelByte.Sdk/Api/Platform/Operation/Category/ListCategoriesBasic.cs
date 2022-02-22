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
    /// listCategoriesBasic
    ///
    /// This API is used to list all categories' basic info of a store ordered by category path.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CATEGORY", action=2 (READ)
    ///   *  Returns : list of categories' paths
    /// </summary>
    public class ListCategoriesBasic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListCategoriesBasicBuilder Builder = new ListCategoriesBasicBuilder();

        public class ListCategoriesBasicBuilder
        {
            
            public string? StoreId { get; set; }
            
            internal ListCategoriesBasicBuilder() { }


            public ListCategoriesBasicBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public ListCategoriesBasic Build(
                string namespace_
            )
            {
                return new ListCategoriesBasic(this,
                    namespace_                    
                );
            }
        }

        private ListCategoriesBasic(ListCategoriesBasicBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            
        }
        #endregion

        public ListCategoriesBasic(
            string namespace_,            
            string? storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories/basic";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.BasicCategoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BasicCategoryInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BasicCategoryInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}