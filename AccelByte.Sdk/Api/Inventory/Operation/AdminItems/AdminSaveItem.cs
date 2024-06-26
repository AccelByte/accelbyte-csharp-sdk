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
    /// AdminSaveItem
    ///
    /// 
    /// Saving an item.
    /// The item will be saved in user's inventory,
    /// If it doesn't exist it'll be created.
    /// 
    /// If the item already exists, its qty will be increased,
    /// so no new item with same sourceItemId will be created
    /// 
    /// Tags will be auto-created.
    /// ItemType will be auto-created.
    /// 
    /// For Ecommerce item, this fields will be override by ecommerce configuration
    /// (slotUsed, serverCustomAttributes, customAttributes, type)
    /// 
    /// For Ecommerce items, the quantity saved is dynamically adjusted based on an item's useCount configured in Store.
    /// When saving items, the quantity specified for each item will be multiplied by the useCount.
    /// i.e. If the store item is configured with a useCount of 5
    /// and the quantity of a particular item is set to 2 during saving, it will be stored as 10.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [CREATE]
    /// </summary>
    public class AdminSaveItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSaveItemBuilder Builder { get => new AdminSaveItemBuilder(); }

        public class AdminSaveItemBuilder
            : OperationBuilder<AdminSaveItemBuilder>
        {





            internal AdminSaveItemBuilder() { }






            public AdminSaveItem Build(
                ApimodelsSaveItemReq body,
                string namespace_,
                string userId
            )
            {
                AdminSaveItem op = new AdminSaveItem(this,
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

        private AdminSaveItem(AdminSaveItemBuilder builder,
            ApimodelsSaveItemReq body,
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

        public AdminSaveItem(
            string namespace_,
            string userId,
            Model.ApimodelsSaveItemReq body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/items";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsItemResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsItemResp<T1, T2, T3>? ParseResponse<T1, T2, T3>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2, T3>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2, T3>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}