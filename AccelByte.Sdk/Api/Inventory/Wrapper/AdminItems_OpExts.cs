// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;
using AccelByte.Sdk.Api.Inventory.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class InventoryAdminItems_OpExts
    {
        public static Inventory.Model.ApimodelsListItemResp? Execute(
            this AdminListItems.AdminListItemsBuilder builder,
            string inventoryId,
            string namespace_
        )
        {
            AdminListItems op = builder.Build(
                inventoryId,
                namespace_
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminListItems(op);
        }
        public static Inventory.Model.ApimodelsItemResp? Execute(
            this AdminGetInventoryItem.AdminGetInventoryItemBuilder builder,
            string inventoryId,
            string namespace_,
            string slotId,
            string sourceItemId
        )
        {
            AdminGetInventoryItem op = builder.Build(
                inventoryId,
                namespace_,
                slotId,
                sourceItemId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminGetInventoryItem(op);
        }

        public static Inventory.Model.ApimodelsItemResp<T1, T2>? Execute<T1, T2>(
            this AdminGetInventoryItem.AdminGetInventoryItemBuilder builder,
            string inventoryId,
            string namespace_,
            string slotId,
            string sourceItemId
        )
        {
            AdminGetInventoryItem op = builder.Build(
                inventoryId,
                namespace_,
                slotId,
                sourceItemId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminGetInventoryItem<T1, T2>(op);
        }
        public static Inventory.Model.ApimodelsItemResp? Execute(
            this AdminConsumeUserItem.AdminConsumeUserItemBuilder builder,
            ApimodelsConsumeItemReq body,
            string inventoryId,
            string namespace_,
            string userId
        )
        {
            AdminConsumeUserItem op = builder.Build(
                body,
                inventoryId,
                namespace_,
                userId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminConsumeUserItem(op);
        }

        public static Inventory.Model.ApimodelsItemResp<T1, T2>? Execute<T1, T2>(
            this AdminConsumeUserItem.AdminConsumeUserItemBuilder builder,
            ApimodelsConsumeItemReq body,
            string inventoryId,
            string namespace_,
            string userId
        )
        {
            AdminConsumeUserItem op = builder.Build(
                body,
                inventoryId,
                namespace_,
                userId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminConsumeUserItem<T1, T2>(op);
        }
        public static List<Inventory.Model.ApimodelsUpdateItemResp>? Execute(
            this AdminBulkUpdateMyItems.AdminBulkUpdateMyItemsBuilder builder,
            List<ApimodelsAdminUpdateItemReq> body,
            string inventoryId,
            string namespace_,
            string userId
        )
        {
            AdminBulkUpdateMyItems op = builder.Build(
                body,
                inventoryId,
                namespace_,
                userId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminBulkUpdateMyItems(op);
        }
        public static Inventory.Model.ApimodelsItemResp? Execute(
            this AdminSaveItemToInventory.AdminSaveItemToInventoryBuilder builder,
            ApimodelsSaveItemToInventoryReq body,
            string inventoryId,
            string namespace_,
            string userId
        )
        {
            AdminSaveItemToInventory op = builder.Build(
                body,
                inventoryId,
                namespace_,
                userId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminSaveItemToInventory(op);
        }

        public static Inventory.Model.ApimodelsItemResp<T1, T2>? Execute<T1, T2>(
            this AdminSaveItemToInventory.AdminSaveItemToInventoryBuilder builder,
            ApimodelsSaveItemToInventoryReq body,
            string inventoryId,
            string namespace_,
            string userId
        )
        {
            AdminSaveItemToInventory op = builder.Build(
                body,
                inventoryId,
                namespace_,
                userId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminSaveItemToInventory<T1, T2>(op);
        }
        public static List<Inventory.Model.ApimodelsUpdateItemResp>? Execute(
            this AdminBulkRemoveItems.AdminBulkRemoveItemsBuilder builder,
            List<ApimodelsRemoveInventoryItemReq> body,
            string inventoryId,
            string namespace_,
            string userId
        )
        {
            AdminBulkRemoveItems op = builder.Build(
                body,
                inventoryId,
                namespace_,
                userId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminBulkRemoveItems(op);
        }
        public static Inventory.Model.ApimodelsItemResp? Execute(
            this AdminSaveItem.AdminSaveItemBuilder builder,
            ApimodelsSaveItemReq body,
            string namespace_,
            string userId
        )
        {
            AdminSaveItem op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminSaveItem(op);
        }

        public static Inventory.Model.ApimodelsItemResp<T1, T2>? Execute<T1, T2>(
            this AdminSaveItem.AdminSaveItemBuilder builder,
            ApimodelsSaveItemReq body,
            string namespace_,
            string userId
        )
        {
            AdminSaveItem op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Inventory.Wrapper.AdminItems)builder.WrapperObject!).AdminSaveItem<T1, T2>(op);
        }
    }
}