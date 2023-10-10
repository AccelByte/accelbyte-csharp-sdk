// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Inventory.Wrapper
{
    public class PublicItems
    {
        private readonly AccelByteSDK _sdk;

        public PublicItems(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public PublicConsumeMyItem.PublicConsumeMyItemBuilder PublicConsumeMyItemOp
        {
            get { return Operation.PublicConsumeMyItem.Builder.SetWrapperObject(this); }
        }
        public PublicListItems.PublicListItemsBuilder PublicListItemsOp
        {
            get { return Operation.PublicListItems.Builder.SetWrapperObject(this); }
        }
        public PublicBulkUpdateMyItems.PublicBulkUpdateMyItemsBuilder PublicBulkUpdateMyItemsOp
        {
            get { return Operation.PublicBulkUpdateMyItems.Builder.SetWrapperObject(this); }
        }
        public PublicBulkRemoveMyItems.PublicBulkRemoveMyItemsBuilder PublicBulkRemoveMyItemsOp
        {
            get { return Operation.PublicBulkRemoveMyItems.Builder.SetWrapperObject(this); }
        }
        public PublicMoveMyItems.PublicMoveMyItemsBuilder PublicMoveMyItemsOp
        {
            get { return Operation.PublicMoveMyItems.Builder.SetWrapperObject(this); }
        }
        public PublicGetItem.PublicGetItemBuilder PublicGetItemOp
        {
            get { return Operation.PublicGetItem.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelsItemResp? PublicConsumeMyItem(PublicConsumeMyItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2>? PublicConsumeMyItem<T1, T2>(PublicConsumeMyItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsListItemResp? PublicListItems(PublicListItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsUpdateItemResp>? PublicBulkUpdateMyItems(PublicBulkUpdateMyItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsUpdateItemResp>? PublicBulkRemoveMyItems(PublicBulkRemoveMyItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsMoveItemsResp? PublicMoveMyItems(PublicMoveMyItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsItemResp? PublicGetItem(PublicGetItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2>? PublicGetItem<T1, T2>(PublicGetItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}