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
    /// updateCategory
    ///
    /// This API is used to update category.
    /// 
    /// The category update data is a category object, example as:
    /// 
    /// 
    ///     {
    /// 
    ///         "storeId": "store-id",
    /// 
    ///         "localizationDisplayNames": {"en" : "Games"}
    /// 
    ///     }
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CATEGORY", action=4 (UPDATE)
    ///   *  Returns : the updated category data
    /// </summary>
    public class UpdateCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCategoryBuilder Builder = new UpdateCategoryBuilder();

        public class UpdateCategoryBuilder
            : OperationBuilder<UpdateCategoryBuilder>
        {


            public Model.CategoryUpdate? Body { get; set; }




            internal UpdateCategoryBuilder() { }



            public UpdateCategoryBuilder SetBody(Model.CategoryUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateCategory Build(
                string categoryPath,
                string namespace_,
                string storeId
            )
            {
                UpdateCategory op = new UpdateCategory(this,
                    categoryPath,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateCategory(UpdateCategoryBuilder builder,
            string categoryPath,
            string namespace_,
            string storeId
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateCategory(
            string categoryPath,
            string namespace_,
            string storeId,
            Model.CategoryUpdate body
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories/{categoryPath}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

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