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
    /// createCategory
    ///
    /// This API is used to create category.
    /// 
    /// A category is a path separated by "/". A category also has localized display names. Example:
    /// 
    /// 
    ///     {
    /// 
    ///         "categoryPath": "/games",
    /// 
    ///         "localizationDisplayNames": {"en" : "Games"}
    /// 
    ///     }
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CATEGORY", action=1 (CREATE)
    ///   *  Returns : created category data
    /// </summary>
    public class CreateCategory : AccelByte.Sdk.Core.Operation
    {
        public CreateCategory(
            string namespace_,            
            string storeId,            
            Model.CategoryCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

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