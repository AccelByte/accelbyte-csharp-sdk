// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformEntitlement_OpExts
    {
        public static Platform.Model.EntitlementPagingSlicedResult? Execute(
            this QueryEntitlements.QueryEntitlementsBuilder builder,
            string namespace_
        )
        {
            QueryEntitlements op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).QueryEntitlements(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this GetEntitlement.GetEntitlementBuilder builder,
            string entitlementId,
            string namespace_
        )
        {
            GetEntitlement op = builder.Build(
                entitlementId,
                namespace_
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GetEntitlement(op);
        }

        public static Platform.Model.EntitlementPagingSlicedResult? Execute(
            this QueryUserEntitlements.QueryUserEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserEntitlements op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).QueryUserEntitlements(op);
        }

        public static List<Platform.Model.StackableEntitlementInfo>? Execute(
            this GrantUserEntitlement.GrantUserEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            GrantUserEntitlement op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GrantUserEntitlement(op);
        }

        public static Platform.Model.AppEntitlementInfo? Execute(
            this GetUserAppEntitlementByAppId.GetUserAppEntitlementByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            GetUserAppEntitlementByAppId op = builder.Build(
                namespace_,
                userId,
                appId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GetUserAppEntitlementByAppId(op);
        }

        public static Platform.Model.AppEntitlementPagingSlicedResult? Execute(
            this QueryUserEntitlementsByAppType.QueryUserEntitlementsByAppTypeBuilder builder,
            string namespace_,
            string userId,
            string appType
        )
        {
            QueryUserEntitlementsByAppType op = builder.Build(
                namespace_,
                userId,
                appType
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).QueryUserEntitlementsByAppType(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this GetUserEntitlementByItemId.GetUserEntitlementByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            GetUserEntitlementByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GetUserEntitlementByItemId(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this GetUserEntitlementBySku.GetUserEntitlementBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            GetUserEntitlementBySku op = builder.Build(
                namespace_,
                userId,
                sku
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GetUserEntitlementBySku(op);
        }

        public static Platform.Model.Ownership? Execute(
            this ExistsAnyUserActiveEntitlement.ExistsAnyUserActiveEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            ExistsAnyUserActiveEntitlement op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).ExistsAnyUserActiveEntitlement(op);
        }

        public static Platform.Model.Ownership? Execute(
            this ExistsAnyUserActiveEntitlementByItemIds.ExistsAnyUserActiveEntitlementByItemIdsBuilder builder,
            string namespace_,
            string userId,
            List<string> itemIds
        )
        {
            ExistsAnyUserActiveEntitlementByItemIds op = builder.Build(
                namespace_,
                userId,
                itemIds
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).ExistsAnyUserActiveEntitlementByItemIds(op);
        }

        public static Platform.Model.Ownership? Execute(
            this GetUserAppEntitlementOwnershipByAppId.GetUserAppEntitlementOwnershipByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            GetUserAppEntitlementOwnershipByAppId op = builder.Build(
                namespace_,
                userId,
                appId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GetUserAppEntitlementOwnershipByAppId(op);
        }

        public static Platform.Model.TimedOwnership? Execute(
            this GetUserEntitlementOwnershipByItemId.GetUserEntitlementOwnershipByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            GetUserEntitlementOwnershipByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GetUserEntitlementOwnershipByItemId(op);
        }

        public static Platform.Model.TimedOwnership? Execute(
            this GetUserEntitlementOwnershipBySku.GetUserEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            GetUserEntitlementOwnershipBySku op = builder.Build(
                namespace_,
                userId,
                sku
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GetUserEntitlementOwnershipBySku(op);
        }

        public static Platform.Model.BulkOperationResult? Execute(
            this RevokeUserEntitlements.RevokeUserEntitlementsBuilder builder,
            string namespace_,
            string userId,
            string entitlementIds
        )
        {
            RevokeUserEntitlements op = builder.Build(
                namespace_,
                userId,
                entitlementIds
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).RevokeUserEntitlements(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this GetUserEntitlement.GetUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            GetUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GetUserEntitlement(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this UpdateUserEntitlement.UpdateUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            UpdateUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).UpdateUserEntitlement(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this ConsumeUserEntitlement.ConsumeUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            ConsumeUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).ConsumeUserEntitlement(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this DisableUserEntitlement.DisableUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            DisableUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).DisableUserEntitlement(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this EnableUserEntitlement.EnableUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            EnableUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).EnableUserEntitlement(op);
        }

        public static List<Platform.Model.EntitlementHistoryInfo>? Execute(
            this GetUserEntitlementHistories.GetUserEntitlementHistoriesBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            GetUserEntitlementHistories op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).GetUserEntitlementHistories(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this RevokeUserEntitlement.RevokeUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            RevokeUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).RevokeUserEntitlement(op);
        }

        public static Platform.Model.Ownership? Execute(
            this PublicExistsAnyMyActiveEntitlement.PublicExistsAnyMyActiveEntitlementBuilder builder,
            string namespace_
        )
        {
            PublicExistsAnyMyActiveEntitlement op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicExistsAnyMyActiveEntitlement(op);
        }

        public static Platform.Model.Ownership? Execute(
            this PublicGetMyAppEntitlementOwnershipByAppId.PublicGetMyAppEntitlementOwnershipByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            PublicGetMyAppEntitlementOwnershipByAppId op = builder.Build(
                namespace_,
                appId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetMyAppEntitlementOwnershipByAppId(op);
        }

        public static Platform.Model.TimedOwnership? Execute(
            this PublicGetMyEntitlementOwnershipByItemId.PublicGetMyEntitlementOwnershipByItemIdBuilder builder,
            string namespace_,
            string itemId
        )
        {
            PublicGetMyEntitlementOwnershipByItemId op = builder.Build(
                namespace_,
                itemId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetMyEntitlementOwnershipByItemId(op);
        }

        public static Platform.Model.TimedOwnership? Execute(
            this PublicGetMyEntitlementOwnershipBySku.PublicGetMyEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PublicGetMyEntitlementOwnershipBySku op = builder.Build(
                namespace_,
                sku
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetMyEntitlementOwnershipBySku(op);
        }

        public static Platform.Model.OwnershipToken? Execute(
            this PublicGetEntitlementOwnershipToken.PublicGetEntitlementOwnershipTokenBuilder builder,
            string namespace_
        )
        {
            PublicGetEntitlementOwnershipToken op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetEntitlementOwnershipToken(op);
        }

        public static Platform.Model.EntitlementPagingSlicedResult? Execute(
            this PublicQueryUserEntitlements.PublicQueryUserEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicQueryUserEntitlements op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicQueryUserEntitlements(op);
        }

        public static Platform.Model.AppEntitlementInfo? Execute(
            this PublicGetUserAppEntitlementByAppId.PublicGetUserAppEntitlementByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            PublicGetUserAppEntitlementByAppId op = builder.Build(
                namespace_,
                userId,
                appId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetUserAppEntitlementByAppId(op);
        }

        public static Platform.Model.AppEntitlementPagingSlicedResult? Execute(
            this PublicQueryUserEntitlementsByAppType.PublicQueryUserEntitlementsByAppTypeBuilder builder,
            string namespace_,
            string userId,
            string appType
        )
        {
            PublicQueryUserEntitlementsByAppType op = builder.Build(
                namespace_,
                userId,
                appType
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicQueryUserEntitlementsByAppType(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this PublicGetUserEntitlementByItemId.PublicGetUserEntitlementByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PublicGetUserEntitlementByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetUserEntitlementByItemId(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this PublicGetUserEntitlementBySku.PublicGetUserEntitlementBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            PublicGetUserEntitlementBySku op = builder.Build(
                namespace_,
                userId,
                sku
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetUserEntitlementBySku(op);
        }

        public static Platform.Model.Ownership? Execute(
            this PublicExistsAnyUserActiveEntitlement.PublicExistsAnyUserActiveEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicExistsAnyUserActiveEntitlement op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicExistsAnyUserActiveEntitlement(op);
        }

        public static Platform.Model.Ownership? Execute(
            this PublicGetUserAppEntitlementOwnershipByAppId.PublicGetUserAppEntitlementOwnershipByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            PublicGetUserAppEntitlementOwnershipByAppId op = builder.Build(
                namespace_,
                userId,
                appId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetUserAppEntitlementOwnershipByAppId(op);
        }

        public static Platform.Model.TimedOwnership? Execute(
            this PublicGetUserEntitlementOwnershipByItemId.PublicGetUserEntitlementOwnershipByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PublicGetUserEntitlementOwnershipByItemId op = builder.Build(
                namespace_,
                userId,
                itemId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetUserEntitlementOwnershipByItemId(op);
        }

        public static Platform.Model.TimedOwnership? Execute(
            this PublicGetUserEntitlementOwnershipBySku.PublicGetUserEntitlementOwnershipBySkuBuilder builder,
            string namespace_,
            string userId,
            string sku
        )
        {
            PublicGetUserEntitlementOwnershipBySku op = builder.Build(
                namespace_,
                userId,
                sku
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetUserEntitlementOwnershipBySku(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this PublicGetUserEntitlement.PublicGetUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PublicGetUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicGetUserEntitlement(op);
        }

        public static Platform.Model.EntitlementInfo? Execute(
            this PublicConsumeUserEntitlement.PublicConsumeUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PublicConsumeUserEntitlement op = builder.Build(
                entitlementId,
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Entitlement)builder.WrapperObject!).PublicConsumeUserEntitlement(op);
        }

    }
}