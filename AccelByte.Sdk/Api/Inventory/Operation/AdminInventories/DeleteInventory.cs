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
    /// deleteInventory
    ///
    /// 
    /// Deleting an inventory.
    /// If an inventory still has items, it cannot be deleted.
    /// 
    /// ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY [DELETE]
    /// </summary>
    public class DeleteInventory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteInventoryBuilder Builder { get => new DeleteInventoryBuilder(); }

        public class DeleteInventoryBuilder
            : OperationBuilder<DeleteInventoryBuilder>
        {





            internal DeleteInventoryBuilder() { }






            public DeleteInventory Build(
                ApimodelsDeleteInventoryReq body,
                string inventoryId,
                string namespace_
            )
            {
                DeleteInventory op = new DeleteInventory(this,
                    body,
                    inventoryId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private DeleteInventory(DeleteInventoryBuilder builder,
            ApimodelsDeleteInventoryReq body,
            string inventoryId,
            string namespace_
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteInventory(
            string inventoryId,
            string namespace_,
            Model.ApimodelsDeleteInventoryReq body
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}