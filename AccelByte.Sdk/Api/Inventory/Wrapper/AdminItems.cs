// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Inventory.Wrapper
{
    public class AdminItems
    {
        private readonly AccelByteSDK _sdk;

        public AdminItems(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListItems.AdminListItemsBuilder AdminListItemsOp
        {
            get { return Operation.AdminListItems.Builder.SetWrapperObject(this); }
        }
        public AdminGetInventoryItem.AdminGetInventoryItemBuilder AdminGetInventoryItemOp
        {
            get { return Operation.AdminGetInventoryItem.Builder.SetWrapperObject(this); }
        }
        public AdminConsumeUserItem.AdminConsumeUserItemBuilder AdminConsumeUserItemOp
        {
            get { return Operation.AdminConsumeUserItem.Builder.SetWrapperObject(this); }
        }
        public AdminBulkUpdateMyItems.AdminBulkUpdateMyItemsBuilder AdminBulkUpdateMyItemsOp
        {
            get { return Operation.AdminBulkUpdateMyItems.Builder.SetWrapperObject(this); }
        }
        public AdminSaveItemToInventory.AdminSaveItemToInventoryBuilder AdminSaveItemToInventoryOp
        {
            get { return Operation.AdminSaveItemToInventory.Builder.SetWrapperObject(this); }
        }
        public AdminBulkRemoveItems.AdminBulkRemoveItemsBuilder AdminBulkRemoveItemsOp
        {
            get { return Operation.AdminBulkRemoveItems.Builder.SetWrapperObject(this); }
        }
        public AdminSaveItem.AdminSaveItemBuilder AdminSaveItemOp
        {
            get { return Operation.AdminSaveItem.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelsListItemResp? AdminListItems(AdminListItems input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsListItemResp?> AdminListItemsAsync(AdminListItems input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsItemResp? AdminGetInventoryItem(AdminGetInventoryItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp?> AdminGetInventoryItemAsync(AdminGetInventoryItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2>? AdminGetInventoryItem<T1, T2>(AdminGetInventoryItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp<T1, T2>?> AdminGetInventoryItemAsync<T1, T2>(AdminGetInventoryItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsItemResp? AdminConsumeUserItem(AdminConsumeUserItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp?> AdminConsumeUserItemAsync(AdminConsumeUserItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2>? AdminConsumeUserItem<T1, T2>(AdminConsumeUserItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp<T1, T2>?> AdminConsumeUserItemAsync<T1, T2>(AdminConsumeUserItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsUpdateItemResp>? AdminBulkUpdateMyItems(AdminBulkUpdateMyItems input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ApimodelsUpdateItemResp>?> AdminBulkUpdateMyItemsAsync(AdminBulkUpdateMyItems input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsItemResp? AdminSaveItemToInventory(AdminSaveItemToInventory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp?> AdminSaveItemToInventoryAsync(AdminSaveItemToInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2>? AdminSaveItemToInventory<T1, T2>(AdminSaveItemToInventory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp<T1, T2>?> AdminSaveItemToInventoryAsync<T1, T2>(AdminSaveItemToInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsUpdateItemResp>? AdminBulkRemoveItems(AdminBulkRemoveItems input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ApimodelsUpdateItemResp>?> AdminBulkRemoveItemsAsync(AdminBulkRemoveItems input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsItemResp? AdminSaveItem(AdminSaveItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp?> AdminSaveItemAsync(AdminSaveItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2>? AdminSaveItem<T1, T2>(AdminSaveItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp<T1, T2>?> AdminSaveItemAsync<T1, T2>(AdminSaveItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}