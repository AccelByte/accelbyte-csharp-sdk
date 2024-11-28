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
    /// AdminBulkSaveItem
    ///
    /// **This endpoint is used used for bulk saving purchased items to the playerâs inventory based on the inventoryConfigurationCode with the following conditions:**
    /// - If the player doesn't have the inventory for the specified inventoryConfigurationCode, a new inventory will be created for the player.
    /// - If the player already has one, it will be added to the existing inventory.
    /// >- If the same item exists within the inventory, the quantity (qty) will be increased.
    /// >- If the inventory is full, the item cannot be added and the request will return the âFailedâ response.
    /// >- If a player has more than one inventory and the initial inventory is full, the service will check the available slot in the other inventory following the order of their creation date and time (createdAt).
    /// 
    /// - For E-commerce items:
    /// >- Attributes such as slotUsed, serverCustomAttributes, customAttributes, and type will be overridden by the attributes configured in the AccelByte Gaming Services (AGS) Store.
    /// >- Storing E-commerce items in a particular slot will follow its entitlement and item configuration, such as durable, consumable, stackable and non-stackable.
    /// >- The quantity is dynamically set based on an itemâs useCount configured in Store. When saving an item, the specified quantity will be multiplied by configured useCount for that particular item. For example, if an Item is configured with a useCount of 5 in the AGS Store and it is saved with a qty of 2, the itemâs quantity will be stored as 2 in the playerâs inventory.
    /// 
    /// **When configuring your request, note the following:**
    /// - The source field is mandatory for determining the source of the item. The supported values are OTHER (for items coming from other sources) and E-commerce for items coming from the E-commerce integration.
    /// - For other-sourced items, the type can be manually defined when saving the item.
    /// - A maximum of 10 items can be saved in a single bulk call.
    /// 
    /// You must have this permission to access this endpoint:
    /// **Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [CREATE]**
    /// </summary>
    public class AdminBulkSaveItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkSaveItemBuilder Builder { get => new AdminBulkSaveItemBuilder(); }

        public class AdminBulkSaveItemBuilder
            : OperationBuilder<AdminBulkSaveItemBuilder>
        {





            internal AdminBulkSaveItemBuilder() { }






            public AdminBulkSaveItem Build(
                List<ApimodelsSaveItemReq> body,
                string namespace_,
                string userId
            )
            {
                AdminBulkSaveItem op = new AdminBulkSaveItem(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminBulkSaveItem(AdminBulkSaveItemBuilder builder,
            List<ApimodelsSaveItemReq> body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminBulkSaveItem(
            string namespace_,
            string userId,
            List<Model.ApimodelsSaveItemReq> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/items/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ApimodelsBulkSaveItemResp>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ApimodelsBulkSaveItemResp>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ApimodelsBulkSaveItemResp>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsBulkSaveItemResp>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}