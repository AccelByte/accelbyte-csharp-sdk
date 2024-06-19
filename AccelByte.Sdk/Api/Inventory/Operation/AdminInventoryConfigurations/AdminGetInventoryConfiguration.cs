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
    /// AdminGetInventoryConfiguration
    ///
    /// 
    /// Getting an inventory configuration info.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:CONFIGURATION [READ]
    /// </summary>
    public class AdminGetInventoryConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetInventoryConfigurationBuilder Builder { get => new AdminGetInventoryConfigurationBuilder(); }

        public class AdminGetInventoryConfigurationBuilder
            : OperationBuilder<AdminGetInventoryConfigurationBuilder>
        {





            internal AdminGetInventoryConfigurationBuilder() { }






            public AdminGetInventoryConfiguration Build(
                string inventoryConfigurationId,
                string namespace_
            )
            {
                AdminGetInventoryConfiguration op = new AdminGetInventoryConfiguration(this,
                    inventoryConfigurationId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetInventoryConfiguration(AdminGetInventoryConfigurationBuilder builder,
            string inventoryConfigurationId,
            string namespace_
        )
        {
            PathParams["inventoryConfigurationId"] = inventoryConfigurationId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetInventoryConfiguration(
            string inventoryConfigurationId,
            string namespace_
        )
        {
            PathParams["inventoryConfigurationId"] = inventoryConfigurationId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations/{inventoryConfigurationId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

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