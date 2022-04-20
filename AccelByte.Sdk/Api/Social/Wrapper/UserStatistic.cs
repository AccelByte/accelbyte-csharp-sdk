// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class UserStatistic
    {
        private readonly AccelByteSDK _sdk;

        public UserStatistic(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public BulkFetchStatItems.BulkFetchStatItemsBuilder BulkFetchStatItemsOp
        {
            get { return Operation.BulkFetchStatItems.Builder.SetWrapperObject(this); }
        }
        public BulkIncUserStatItem.BulkIncUserStatItemBuilder BulkIncUserStatItemOp
        {
            get { return Operation.BulkIncUserStatItem.Builder.SetWrapperObject(this); }
        }
        public BulkIncUserStatItemValue.BulkIncUserStatItemValueBuilder BulkIncUserStatItemValueOp
        {
            get { return Operation.BulkIncUserStatItemValue.Builder.SetWrapperObject(this); }
        }
        public BulkResetUserStatItem.BulkResetUserStatItemBuilder BulkResetUserStatItemOp
        {
            get { return Operation.BulkResetUserStatItem.Builder.SetWrapperObject(this); }
        }
        public GetUserStatItems.GetUserStatItemsBuilder GetUserStatItemsOp
        {
            get { return Operation.GetUserStatItems.Builder.SetWrapperObject(this); }
        }
        public BulkCreateUserStatItems.BulkCreateUserStatItemsBuilder BulkCreateUserStatItemsOp
        {
            get { return Operation.BulkCreateUserStatItems.Builder.SetWrapperObject(this); }
        }
        public BulkIncUserStatItem1.BulkIncUserStatItem1Builder BulkIncUserStatItem1Op
        {
            get { return Operation.BulkIncUserStatItem1.Builder.SetWrapperObject(this); }
        }
        public BulkIncUserStatItemValue1.BulkIncUserStatItemValue1Builder BulkIncUserStatItemValue1Op
        {
            get { return Operation.BulkIncUserStatItemValue1.Builder.SetWrapperObject(this); }
        }
        public BulkResetUserStatItem1.BulkResetUserStatItem1Builder BulkResetUserStatItem1Op
        {
            get { return Operation.BulkResetUserStatItem1.Builder.SetWrapperObject(this); }
        }
        public CreateUserStatItem.CreateUserStatItemBuilder CreateUserStatItemOp
        {
            get { return Operation.CreateUserStatItem.Builder.SetWrapperObject(this); }
        }
        public DeleteUserStatItems.DeleteUserStatItemsBuilder DeleteUserStatItemsOp
        {
            get { return Operation.DeleteUserStatItems.Builder.SetWrapperObject(this); }
        }
        public IncUserStatItemValue.IncUserStatItemValueBuilder IncUserStatItemValueOp
        {
            get { return Operation.IncUserStatItemValue.Builder.SetWrapperObject(this); }
        }
        public ResetUserStatItemValue.ResetUserStatItemValueBuilder ResetUserStatItemValueOp
        {
            get { return Operation.ResetUserStatItemValue.Builder.SetWrapperObject(this); }
        }
        public BulkFetchStatItems1.BulkFetchStatItems1Builder BulkFetchStatItems1Op
        {
            get { return Operation.BulkFetchStatItems1.Builder.SetWrapperObject(this); }
        }
        public PublicBulkIncUserStatItem.PublicBulkIncUserStatItemBuilder PublicBulkIncUserStatItemOp
        {
            get { return Operation.PublicBulkIncUserStatItem.Builder.SetWrapperObject(this); }
        }
        public PublicBulkIncUserStatItemValue.PublicBulkIncUserStatItemValueBuilder PublicBulkIncUserStatItemValueOp
        {
            get { return Operation.PublicBulkIncUserStatItemValue.Builder.SetWrapperObject(this); }
        }
        public BulkResetUserStatItem2.BulkResetUserStatItem2Builder BulkResetUserStatItem2Op
        {
            get { return Operation.BulkResetUserStatItem2.Builder.SetWrapperObject(this); }
        }
        public PublicQueryUserStatItems.PublicQueryUserStatItemsBuilder PublicQueryUserStatItemsOp
        {
            get { return Operation.PublicQueryUserStatItems.Builder.SetWrapperObject(this); }
        }
        public PublicBulkCreateUserStatItems.PublicBulkCreateUserStatItemsBuilder PublicBulkCreateUserStatItemsOp
        {
            get { return Operation.PublicBulkCreateUserStatItems.Builder.SetWrapperObject(this); }
        }
        public PublicBulkIncUserStatItem1.PublicBulkIncUserStatItem1Builder PublicBulkIncUserStatItem1Op
        {
            get { return Operation.PublicBulkIncUserStatItem1.Builder.SetWrapperObject(this); }
        }
        public BulkIncUserStatItemValue2.BulkIncUserStatItemValue2Builder BulkIncUserStatItemValue2Op
        {
            get { return Operation.BulkIncUserStatItemValue2.Builder.SetWrapperObject(this); }
        }
        public BulkResetUserStatItem3.BulkResetUserStatItem3Builder BulkResetUserStatItem3Op
        {
            get { return Operation.BulkResetUserStatItem3.Builder.SetWrapperObject(this); }
        }
        public PublicCreateUserStatItem.PublicCreateUserStatItemBuilder PublicCreateUserStatItemOp
        {
            get { return Operation.PublicCreateUserStatItem.Builder.SetWrapperObject(this); }
        }
        public DeleteUserStatItems1.DeleteUserStatItems1Builder DeleteUserStatItems1Op
        {
            get { return Operation.DeleteUserStatItems1.Builder.SetWrapperObject(this); }
        }
        public PublicIncUserStatItem.PublicIncUserStatItemBuilder PublicIncUserStatItemOp
        {
            get { return Operation.PublicIncUserStatItem.Builder.SetWrapperObject(this); }
        }
        public PublicIncUserStatItemValue.PublicIncUserStatItemValueBuilder PublicIncUserStatItemValueOp
        {
            get { return Operation.PublicIncUserStatItemValue.Builder.SetWrapperObject(this); }
        }
        public ResetUserStatItemValue1.ResetUserStatItemValue1Builder ResetUserStatItemValue1Op
        {
            get { return Operation.ResetUserStatItemValue1.Builder.SetWrapperObject(this); }
        }
        public BulkUpdateUserStatItemV2.BulkUpdateUserStatItemV2Builder BulkUpdateUserStatItemV2Op
        {
            get { return Operation.BulkUpdateUserStatItemV2.Builder.SetWrapperObject(this); }
        }
        public BulkUpdateUserStatItem.BulkUpdateUserStatItemBuilder BulkUpdateUserStatItemOp
        {
            get { return Operation.BulkUpdateUserStatItem.Builder.SetWrapperObject(this); }
        }
        public BulkResetUserStatItemValues.BulkResetUserStatItemValuesBuilder BulkResetUserStatItemValuesOp
        {
            get { return Operation.BulkResetUserStatItemValues.Builder.SetWrapperObject(this); }
        }
        public DeleteUserStatItems2.DeleteUserStatItems2Builder DeleteUserStatItems2Op
        {
            get { return Operation.DeleteUserStatItems2.Builder.SetWrapperObject(this); }
        }
        public UpdateUserStatItemValue.UpdateUserStatItemValueBuilder UpdateUserStatItemValueOp
        {
            get { return Operation.UpdateUserStatItemValue.Builder.SetWrapperObject(this); }
        }
        public BulkUpdateUserStatItem1.BulkUpdateUserStatItem1Builder BulkUpdateUserStatItem1Op
        {
            get { return Operation.BulkUpdateUserStatItem1.Builder.SetWrapperObject(this); }
        }
        public BulkUpdateUserStatItem2.BulkUpdateUserStatItem2Builder BulkUpdateUserStatItem2Op
        {
            get { return Operation.BulkUpdateUserStatItem2.Builder.SetWrapperObject(this); }
        }
        public UpdateUserStatItemValue1.UpdateUserStatItemValue1Builder UpdateUserStatItemValue1Op
        {
            get { return Operation.UpdateUserStatItemValue1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.UserStatItemInfo>? BulkFetchStatItems(BulkFetchStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItem(BulkIncUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItemValue(BulkIncUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItem(BulkResetUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserStatItemPagingSlicedResult? GetUserStatItems(GetUserStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkCreateUserStatItems(BulkCreateUserStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItem1(BulkIncUserStatItem1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItemValue1(BulkIncUserStatItemValue1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItem1(BulkResetUserStatItem1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CreateUserStatItem(CreateUserStatItem input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserStatItems(DeleteUserStatItems input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? IncUserStatItemValue(IncUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? ResetUserStatItemValue(ResetUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.UserStatItemInfo>? BulkFetchStatItems1(BulkFetchStatItems1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? PublicBulkIncUserStatItem(PublicBulkIncUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? PublicBulkIncUserStatItemValue(PublicBulkIncUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItem2(BulkResetUserStatItem2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserStatItemPagingSlicedResult? PublicQueryUserStatItems(PublicQueryUserStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? PublicBulkCreateUserStatItems(PublicBulkCreateUserStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? PublicBulkIncUserStatItem1(PublicBulkIncUserStatItem1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkIncUserStatItemValue2(BulkIncUserStatItemValue2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItem3(BulkResetUserStatItem3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicCreateUserStatItem(PublicCreateUserStatItem input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserStatItems1(DeleteUserStatItems1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? PublicIncUserStatItem(PublicIncUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? PublicIncUserStatItemValue(PublicIncUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? ResetUserStatItemValue1(ResetUserStatItemValue1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkUpdateUserStatItemV2(BulkUpdateUserStatItemV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkUpdateUserStatItem(BulkUpdateUserStatItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkResetUserStatItemValues(BulkResetUserStatItemValues input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserStatItems2(DeleteUserStatItems2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? UpdateUserStatItemValue(UpdateUserStatItemValue input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkUpdateUserStatItem1(BulkUpdateUserStatItem1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BulkStatItemOperationResult>? BulkUpdateUserStatItem2(BulkUpdateUserStatItem2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StatItemIncResult? UpdateUserStatItemValue1(UpdateUserStatItemValue1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}