// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminCreateInventoryConfiguration
    ///
    /// 
    /// Creating inventory configuration.
    /// There cannot be one inventory configuration duplicate code per namespace.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:CONFIGURATION [CREATE]
    /// </summary>
    public class AdminCreateInventoryConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateInventoryConfigurationBuilder Builder { get => new AdminCreateInventoryConfigurationBuilder(); }

        public class AdminCreateInventoryConfigurationBuilder
            : OperationBuilder<AdminCreateInventoryConfigurationBuilder>
        {





            internal AdminCreateInventoryConfigurationBuilder() { }






            public AdminCreateInventoryConfiguration Build(
                ApimodelsCreateInventoryConfigurationReq body,
                string namespace_
            )
            {
                AdminCreateInventoryConfiguration op = new AdminCreateInventoryConfiguration(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminCreateInventoryConfiguration(AdminCreateInventoryConfigurationBuilder builder,
            ApimodelsCreateInventoryConfigurationReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateInventoryConfiguration(
            string namespace_,
            Model.ApimodelsCreateInventoryConfigurationReq body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsInventoryConfigurationResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsInventoryConfigurationResp>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsInventoryConfigurationResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsInventoryConfigurationResp>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}