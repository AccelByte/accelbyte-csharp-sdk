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
    public static class PlatformIAP_OpExts
    {
        public static Platform.Model.AppleIAPConfigInfo? Execute(
            this GetAppleIAPConfig.GetAppleIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetAppleIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).GetAppleIAPConfig(op);
        }
        public static Platform.Model.AppleIAPConfigInfo? Execute(
            this UpdateAppleIAPConfig.UpdateAppleIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateAppleIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdateAppleIAPConfig(op);
        }
        public static void Execute(
            this DeleteAppleIAPConfig.DeleteAppleIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteAppleIAPConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).DeleteAppleIAPConfig(op);
        }
        public static Platform.Model.EpicGamesIAPConfigInfo? Execute(
            this GetEpicGamesIAPConfig.GetEpicGamesIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetEpicGamesIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).GetEpicGamesIAPConfig(op);
        }
        public static Platform.Model.EpicGamesIAPConfigInfo? Execute(
            this UpdateEpicGamesIAPConfig.UpdateEpicGamesIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateEpicGamesIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdateEpicGamesIAPConfig(op);
        }
        public static void Execute(
            this DeleteEpicGamesIAPConfig.DeleteEpicGamesIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteEpicGamesIAPConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).DeleteEpicGamesIAPConfig(op);
        }
        public static Platform.Model.GoogleIAPConfigInfo? Execute(
            this GetGoogleIAPConfig.GetGoogleIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetGoogleIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).GetGoogleIAPConfig(op);
        }
        public static Platform.Model.GoogleIAPConfigInfo? Execute(
            this UpdateGoogleIAPConfig.UpdateGoogleIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateGoogleIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdateGoogleIAPConfig(op);
        }
        public static void Execute(
            this DeleteGoogleIAPConfig.DeleteGoogleIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteGoogleIAPConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).DeleteGoogleIAPConfig(op);
        }
        public static Platform.Model.GoogleIAPConfigInfo? Execute(
            this UpdateGoogleP12File.UpdateGoogleP12FileBuilder builder,
            string namespace_
        )
        {
            UpdateGoogleP12File op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdateGoogleP12File(op);
        }
        public static Platform.Model.IAPItemConfigInfo? Execute(
            this GetIAPItemConfig.GetIAPItemConfigBuilder builder,
            string namespace_
        )
        {
            GetIAPItemConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).GetIAPItemConfig(op);
        }
        public static Platform.Model.IAPItemConfigInfo? Execute(
            this UpdateIAPItemConfig.UpdateIAPItemConfigBuilder builder,
            string namespace_
        )
        {
            UpdateIAPItemConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdateIAPItemConfig(op);
        }
        public static void Execute(
            this DeleteIAPItemConfig.DeleteIAPItemConfigBuilder builder,
            string namespace_
        )
        {
            DeleteIAPItemConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).DeleteIAPItemConfig(op);
        }
        public static Platform.Model.PlayStationIAPConfigInfo? Execute(
            this GetPlayStationIAPConfig.GetPlayStationIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetPlayStationIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).GetPlayStationIAPConfig(op);
        }
        public static Platform.Model.PlayStationIAPConfigInfo? Execute(
            this UpdatePlaystationIAPConfig.UpdatePlaystationIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdatePlaystationIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdatePlaystationIAPConfig(op);
        }
        public static void Execute(
            this DeletePlaystationIAPConfig.DeletePlaystationIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeletePlaystationIAPConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).DeletePlaystationIAPConfig(op);
        }
        public static Platform.Model.SteamIAPConfig? Execute(
            this GetSteamIAPConfig.GetSteamIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetSteamIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).GetSteamIAPConfig(op);
        }
        public static Platform.Model.SteamIAPConfigInfo? Execute(
            this UpdateSteamIAPConfig.UpdateSteamIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateSteamIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdateSteamIAPConfig(op);
        }
        public static void Execute(
            this DeleteSteamIAPConfig.DeleteSteamIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteSteamIAPConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).DeleteSteamIAPConfig(op);
        }
        public static Platform.Model.TwitchIAPConfigInfo? Execute(
            this GetTwitchIAPConfig.GetTwitchIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetTwitchIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).GetTwitchIAPConfig(op);
        }
        public static Platform.Model.TwitchIAPConfigInfo? Execute(
            this UpdateTwitchIAPConfig.UpdateTwitchIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateTwitchIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdateTwitchIAPConfig(op);
        }
        public static void Execute(
            this DeleteTwitchIAPConfig.DeleteTwitchIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteTwitchIAPConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).DeleteTwitchIAPConfig(op);
        }
        public static Platform.Model.XblIAPConfigInfo? Execute(
            this GetXblIAPConfig.GetXblIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetXblIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).GetXblIAPConfig(op);
        }
        public static Platform.Model.XblIAPConfigInfo? Execute(
            this UpdateXblIAPConfig.UpdateXblIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateXblIAPConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdateXblIAPConfig(op);
        }
        public static void Execute(
            this DeleteXblAPConfig.DeleteXblAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteXblAPConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).DeleteXblAPConfig(op);
        }
        public static Platform.Model.XblIAPConfigInfo? Execute(
            this UpdateXblBPCertFile.UpdateXblBPCertFileBuilder builder,
            string namespace_
        )
        {
            UpdateXblBPCertFile op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).UpdateXblBPCertFile(op);
        }
        public static Platform.Model.IAPOrderPagingSlicedResult? Execute(
            this QueryUserIAPOrders.QueryUserIAPOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserIAPOrders op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).QueryUserIAPOrders(op);
        }
        public static Platform.Model.IAPOrderPagingSlicedResult? Execute(
            this QueryAllUserIAPOrders.QueryAllUserIAPOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryAllUserIAPOrders op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).QueryAllUserIAPOrders(op);
        }
        public static Platform.Model.IAPConsumeHistoryPagingSlicedResult? Execute(
            this QueryUserIAPConsumeHistory.QueryUserIAPConsumeHistoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserIAPConsumeHistory op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).QueryUserIAPConsumeHistory(op);
        }
        public static void Execute(
            this MockFulfillIAPItem.MockFulfillIAPItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            MockFulfillIAPItem op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).MockFulfillIAPItem(op);
        }
        public static Platform.Model.IAPItemMappingInfo? Execute(
            this GetIAPItemMapping.GetIAPItemMappingBuilder builder,
            string namespace_
        )
        {
            GetIAPItemMapping op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).GetIAPItemMapping(op);
        }
        public static List<Platform.Model.TwitchSyncResult>? Execute(
            this SyncTwitchDropsEntitlement.SyncTwitchDropsEntitlementBuilder builder,
            string namespace_
        )
        {
            SyncTwitchDropsEntitlement op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).SyncTwitchDropsEntitlement(op);
        }
        public static void Execute(
            this PublicFulfillAppleIAPItem.PublicFulfillAppleIAPItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicFulfillAppleIAPItem op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).PublicFulfillAppleIAPItem(op);
        }
        public static List<Platform.Model.EpicGamesReconcileResult>? Execute(
            this SyncEpicGamesInventory.SyncEpicGamesInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncEpicGamesInventory op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).SyncEpicGamesInventory(op);
        }
        public static Platform.Model.GoogleReceiptResolveResult? Execute(
            this PublicFulfillGoogleIAPItem.PublicFulfillGoogleIAPItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicFulfillGoogleIAPItem op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).PublicFulfillGoogleIAPItem(op);
        }
        public static List<Platform.Model.PlayStationReconcileResult>? Execute(
            this PublicReconcilePlayStationStore.PublicReconcilePlayStationStoreBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicReconcilePlayStationStore op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).PublicReconcilePlayStationStore(op);
        }
        public static List<Platform.Model.PlayStationReconcileResult>? Execute(
            this PublicReconcilePlayStationStoreWithMultipleServiceLabels.PublicReconcilePlayStationStoreWithMultipleServiceLabelsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicReconcilePlayStationStoreWithMultipleServiceLabels op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).PublicReconcilePlayStationStoreWithMultipleServiceLabels(op);
        }
        public static void Execute(
            this SyncSteamInventory.SyncSteamInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncSteamInventory op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).SyncSteamInventory(op);
        }
        public static void Execute(
            this SyncTwitchDropsEntitlement1.SyncTwitchDropsEntitlement1Builder builder,
            string namespace_,
            string userId
        )
        {
            SyncTwitchDropsEntitlement1 op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.IAP)builder.WrapperObject!).SyncTwitchDropsEntitlement1(op);
        }
        public static List<Platform.Model.XblReconcileResult>? Execute(
            this SyncXboxInventory.SyncXboxInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncXboxInventory op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.IAP)builder.WrapperObject!).SyncXboxInventory(op);
        }
    }
}