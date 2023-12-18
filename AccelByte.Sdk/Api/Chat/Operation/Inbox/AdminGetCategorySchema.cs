// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminGetCategorySchema
    ///
    /// Get category schema.
    /// </summary>
    public class AdminGetCategorySchema : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetCategorySchemaBuilder Builder { get => new AdminGetCategorySchemaBuilder(); }

        public class AdminGetCategorySchemaBuilder
            : OperationBuilder<AdminGetCategorySchemaBuilder>
        {





            internal AdminGetCategorySchemaBuilder() { }






            public AdminGetCategorySchema Build(
                string category,
                string namespace_
            )
            {
                AdminGetCategorySchema op = new AdminGetCategorySchema(this,
                    category,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetCategorySchema(AdminGetCategorySchemaBuilder builder,
            string category,
            string namespace_
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetCategorySchema(
            string category,
            string namespace_
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/categories/{category}/schema.json";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsJSONSchemaType? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsJSONSchemaType>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsJSONSchemaType>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsJSONSchemaType>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}