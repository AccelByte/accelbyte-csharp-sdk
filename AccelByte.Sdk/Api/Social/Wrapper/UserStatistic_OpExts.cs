// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SocialUserStatistic_OpExts
    {
        public static List<Social.Model.UserStatItemInfo>? Execute(
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

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkFetchStatItems(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItem.BulkIncUserStatItemBuilder builder,
            string namespace_
        )
        {
            BulkIncUserStatItem op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkIncUserStatItem(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItemValue.BulkIncUserStatItemValueBuilder builder,
            string namespace_
        )
        {
            BulkIncUserStatItemValue op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkIncUserStatItemValue(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItem.BulkResetUserStatItemBuilder builder,
            string namespace_
        )
        {
            BulkResetUserStatItem op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkResetUserStatItem(op);
        }

        public static Social.Model.UserStatItemPagingSlicedResult? Execute(
            this GetUserStatItems.GetUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserStatItems op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).GetUserStatItems(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkCreateUserStatItems.BulkCreateUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            BulkCreateUserStatItems op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkCreateUserStatItems(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItem1.BulkIncUserStatItem1Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkIncUserStatItem1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkIncUserStatItem1(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItemValue1.BulkIncUserStatItemValue1Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkIncUserStatItemValue1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkIncUserStatItemValue1(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItem1.BulkResetUserStatItem1Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkResetUserStatItem1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkResetUserStatItem1(op);
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

            ((Social.Wrapper.UserStatistic)builder.WrapperObject!).CreateUserStatItem(op);
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

            ((Social.Wrapper.UserStatistic)builder.WrapperObject!).DeleteUserStatItems(op);
        }

        public static Social.Model.StatItemIncResult? Execute(
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

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).IncUserStatItemValue(op);
        }

        public static Social.Model.StatItemIncResult? Execute(
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

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).ResetUserStatItemValue(op);
        }

        public static List<Social.Model.UserStatItemInfo>? Execute(
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

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkFetchStatItems1(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this PublicBulkIncUserStatItem.PublicBulkIncUserStatItemBuilder builder,
            string namespace_
        )
        {
            PublicBulkIncUserStatItem op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).PublicBulkIncUserStatItem(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this PublicBulkIncUserStatItemValue.PublicBulkIncUserStatItemValueBuilder builder,
            string namespace_
        )
        {
            PublicBulkIncUserStatItemValue op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).PublicBulkIncUserStatItemValue(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItem2.BulkResetUserStatItem2Builder builder,
            string namespace_
        )
        {
            BulkResetUserStatItem2 op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkResetUserStatItem2(op);
        }

        public static Social.Model.UserStatItemPagingSlicedResult? Execute(
            this PublicQueryUserStatItems.PublicQueryUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicQueryUserStatItems op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).PublicQueryUserStatItems(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this PublicBulkCreateUserStatItems.PublicBulkCreateUserStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicBulkCreateUserStatItems op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).PublicBulkCreateUserStatItems(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this PublicBulkIncUserStatItem1.PublicBulkIncUserStatItem1Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicBulkIncUserStatItem1 op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).PublicBulkIncUserStatItem1(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkIncUserStatItemValue2.BulkIncUserStatItemValue2Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkIncUserStatItemValue2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkIncUserStatItemValue2(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItem3.BulkResetUserStatItem3Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkResetUserStatItem3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkResetUserStatItem3(op);
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

            ((Social.Wrapper.UserStatistic)builder.WrapperObject!).PublicCreateUserStatItem(op);
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

            ((Social.Wrapper.UserStatistic)builder.WrapperObject!).DeleteUserStatItems1(op);
        }

        public static Social.Model.StatItemIncResult? Execute(
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

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).PublicIncUserStatItem(op);
        }

        public static Social.Model.StatItemIncResult? Execute(
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

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).PublicIncUserStatItemValue(op);
        }

        public static Social.Model.StatItemIncResult? Execute(
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

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).ResetUserStatItemValue1(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkUpdateUserStatItemV2.BulkUpdateUserStatItemV2Builder builder,
            string namespace_
        )
        {
            BulkUpdateUserStatItemV2 op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkUpdateUserStatItemV2(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkUpdateUserStatItem.BulkUpdateUserStatItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            BulkUpdateUserStatItem op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkUpdateUserStatItem(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkResetUserStatItemValues.BulkResetUserStatItemValuesBuilder builder,
            string namespace_,
            string userId
        )
        {
            BulkResetUserStatItemValues op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkResetUserStatItemValues(op);
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

            ((Social.Wrapper.UserStatistic)builder.WrapperObject!).DeleteUserStatItems2(op);
        }

        public static Social.Model.StatItemIncResult? Execute(
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

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).UpdateUserStatItemValue(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkUpdateUserStatItem1.BulkUpdateUserStatItem1Builder builder,
            string namespace_
        )
        {
            BulkUpdateUserStatItem1 op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkUpdateUserStatItem1(op);
        }

        public static List<Social.Model.BulkStatItemOperationResult>? Execute(
            this BulkUpdateUserStatItem2.BulkUpdateUserStatItem2Builder builder,
            string namespace_,
            string userId
        )
        {
            BulkUpdateUserStatItem2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).BulkUpdateUserStatItem2(op);
        }

        public static Social.Model.StatItemIncResult? Execute(
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

            return ((Social.Wrapper.UserStatistic)builder.WrapperObject!).UpdateUserStatItemValue1(op);
        }

    }
}