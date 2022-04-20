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

    public static class UserStatistic_OperationExtensions
    {
        public static List<Model.UserStatItemInfo>? Execute(
            this BulkFetchStatItems.BulkFetchStatItemsBuilder builder,
            string namespace_,
            string statCode,
            string userIds
        )
        {
            BulkFetchStatItems op = builder.Build(
                namespace_,
                statCode,
                userIds
            );

            return ((UserStatistic)builder.WrapperObject!).BulkFetchStatItems(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItem.BulkIncUserStatItemBuilder builder,
            string namespace_
        )
        {
            BulkIncUserStatItem op = builder.Build(
                namespace_
            );

            return ((UserStatistic)builder.WrapperObject!).BulkIncUserStatItem(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItemValue.BulkIncUserStatItemValueBuilder builder,
            string namespace_
        )
        {
            BulkIncUserStatItemValue op = builder.Build(
                namespace_
            );

            return ((UserStatistic)builder.WrapperObject!).BulkIncUserStatItemValue(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItem.BulkResetUserStatItemBuilder builder,
            string namespace_
        )
        {
            BulkResetUserStatItem op = builder.Build(
                namespace_
            );

            return ((UserStatistic)builder.WrapperObject!).BulkResetUserStatItem(op);
        }

        public static Model.UserStatItemPagingSlicedResult? Execute(
            this GetUserStatItems.GetUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserStatItems op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).GetUserStatItems(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkCreateUserStatItems.BulkCreateUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            BulkCreateUserStatItems op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).BulkCreateUserStatItems(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItem1.BulkIncUserStatItem1Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkIncUserStatItem1 op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).BulkIncUserStatItem1(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItemValue1.BulkIncUserStatItemValue1Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkIncUserStatItemValue1 op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).BulkIncUserStatItemValue1(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItem1.BulkResetUserStatItem1Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkResetUserStatItem1 op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).BulkResetUserStatItem1(op);
        }

        public static void Execute(
            this CreateUserStatItem.CreateUserStatItemBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            CreateUserStatItem op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            ((UserStatistic)builder.WrapperObject!).CreateUserStatItem(op);
        }

        public static void Execute(
            this DeleteUserStatItems.DeleteUserStatItemsBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            DeleteUserStatItems op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            ((UserStatistic)builder.WrapperObject!).DeleteUserStatItems(op);
        }

        public static Model.StatItemIncResult? Execute(
            this IncUserStatItemValue.IncUserStatItemValueBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            IncUserStatItemValue op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).IncUserStatItemValue(op);
        }

        public static Model.StatItemIncResult? Execute(
            this ResetUserStatItemValue.ResetUserStatItemValueBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            ResetUserStatItemValue op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).ResetUserStatItemValue(op);
        }

        public static List<Model.UserStatItemInfo>? Execute(
            this BulkFetchStatItems1.BulkFetchStatItems1Builder builder,
            string namespace_,
            string statCode,
            string userIds
        )
        {
            BulkFetchStatItems1 op = builder.Build(
                namespace_,
                statCode,
                userIds
            );

            return ((UserStatistic)builder.WrapperObject!).BulkFetchStatItems1(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this PublicBulkIncUserStatItem.PublicBulkIncUserStatItemBuilder builder,
            string namespace_
        )
        {
            PublicBulkIncUserStatItem op = builder.Build(
                namespace_
            );

            return ((UserStatistic)builder.WrapperObject!).PublicBulkIncUserStatItem(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this PublicBulkIncUserStatItemValue.PublicBulkIncUserStatItemValueBuilder builder,
            string namespace_
        )
        {
            PublicBulkIncUserStatItemValue op = builder.Build(
                namespace_
            );

            return ((UserStatistic)builder.WrapperObject!).PublicBulkIncUserStatItemValue(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItem2.BulkResetUserStatItem2Builder builder,
            string namespace_
        )
        {
            BulkResetUserStatItem2 op = builder.Build(
                namespace_
            );

            return ((UserStatistic)builder.WrapperObject!).BulkResetUserStatItem2(op);
        }

        public static Model.UserStatItemPagingSlicedResult? Execute(
            this PublicQueryUserStatItems.PublicQueryUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicQueryUserStatItems op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).PublicQueryUserStatItems(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this PublicBulkCreateUserStatItems.PublicBulkCreateUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicBulkCreateUserStatItems op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).PublicBulkCreateUserStatItems(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this PublicBulkIncUserStatItem1.PublicBulkIncUserStatItem1Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicBulkIncUserStatItem1 op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).PublicBulkIncUserStatItem1(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItemValue2.BulkIncUserStatItemValue2Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkIncUserStatItemValue2 op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).BulkIncUserStatItemValue2(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItem3.BulkResetUserStatItem3Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkResetUserStatItem3 op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).BulkResetUserStatItem3(op);
        }

        public static void Execute(
            this PublicCreateUserStatItem.PublicCreateUserStatItemBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PublicCreateUserStatItem op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            ((UserStatistic)builder.WrapperObject!).PublicCreateUserStatItem(op);
        }

        public static void Execute(
            this DeleteUserStatItems1.DeleteUserStatItems1Builder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            DeleteUserStatItems1 op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            ((UserStatistic)builder.WrapperObject!).DeleteUserStatItems1(op);
        }

        public static Model.StatItemIncResult? Execute(
            this PublicIncUserStatItem.PublicIncUserStatItemBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PublicIncUserStatItem op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).PublicIncUserStatItem(op);
        }

        public static Model.StatItemIncResult? Execute(
            this PublicIncUserStatItemValue.PublicIncUserStatItemValueBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PublicIncUserStatItemValue op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).PublicIncUserStatItemValue(op);
        }

        public static Model.StatItemIncResult? Execute(
            this ResetUserStatItemValue1.ResetUserStatItemValue1Builder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            ResetUserStatItemValue1 op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).ResetUserStatItemValue1(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkUpdateUserStatItemV2.BulkUpdateUserStatItemV2Builder builder,
            string namespace_
        )
        {
            BulkUpdateUserStatItemV2 op = builder.Build(
                namespace_
            );

            return ((UserStatistic)builder.WrapperObject!).BulkUpdateUserStatItemV2(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkUpdateUserStatItem.BulkUpdateUserStatItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            BulkUpdateUserStatItem op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).BulkUpdateUserStatItem(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItemValues.BulkResetUserStatItemValuesBuilder builder,
            string namespace_,
            string userId
        )
        {
            BulkResetUserStatItemValues op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).BulkResetUserStatItemValues(op);
        }

        public static void Execute(
            this DeleteUserStatItems2.DeleteUserStatItems2Builder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            DeleteUserStatItems2 op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            ((UserStatistic)builder.WrapperObject!).DeleteUserStatItems2(op);
        }

        public static Model.StatItemIncResult? Execute(
            this UpdateUserStatItemValue.UpdateUserStatItemValueBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            UpdateUserStatItemValue op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).UpdateUserStatItemValue(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkUpdateUserStatItem1.BulkUpdateUserStatItem1Builder builder,
            string namespace_
        )
        {
            BulkUpdateUserStatItem1 op = builder.Build(
                namespace_
            );

            return ((UserStatistic)builder.WrapperObject!).BulkUpdateUserStatItem1(op);
        }

        public static List<Model.BulkStatItemOperationResult>? Execute(
            this BulkUpdateUserStatItem2.BulkUpdateUserStatItem2Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkUpdateUserStatItem2 op = builder.Build(
                namespace_,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).BulkUpdateUserStatItem2(op);
        }

        public static Model.StatItemIncResult? Execute(
            this UpdateUserStatItemValue1.UpdateUserStatItemValue1Builder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            UpdateUserStatItemValue1 op = builder.Build(
                namespace_,
                statCode,
                userId
            );

            return ((UserStatistic)builder.WrapperObject!).UpdateUserStatItemValue1(op);
        }

    }
}