// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformDLC_OpExts
    {
        public static Platform.Model.DLCItemConfigInfo? Execute(
            this GetDLCItemConfig.GetDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            GetDLCItemConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.DLC)builder.WrapperObject!).GetDLCItemConfig(op);
        }
        public static async Task<Platform.Model.DLCItemConfigInfo?> ExecuteAsync(
            this GetDLCItemConfig.GetDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            GetDLCItemConfig op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.DLC)builder.WrapperObject!).GetDLCItemConfigAsync(op);
        }
        public static Platform.Model.DLCItemConfigInfo? Execute(
            this UpdateDLCItemConfig.UpdateDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            UpdateDLCItemConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.DLC)builder.WrapperObject!).UpdateDLCItemConfig(op);
        }
        public static async Task<Platform.Model.DLCItemConfigInfo?> ExecuteAsync(
            this UpdateDLCItemConfig.UpdateDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            UpdateDLCItemConfig op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.DLC)builder.WrapperObject!).UpdateDLCItemConfigAsync(op);
        }
        public static void Execute(
            this DeleteDLCItemConfig.DeleteDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            DeleteDLCItemConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.DLC)builder.WrapperObject!).DeleteDLCItemConfig(op);
        }
        public static async Task ExecuteAsync(
            this DeleteDLCItemConfig.DeleteDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            DeleteDLCItemConfig op = builder.Build(
                namespace_
            );

            await ((Platform.Wrapper.DLC)builder.WrapperObject!).DeleteDLCItemConfigAsync(op);
        }
        public static Platform.Model.PlatformDLCConfigInfo? Execute(
            this GetPlatformDLCConfig.GetPlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            GetPlatformDLCConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.DLC)builder.WrapperObject!).GetPlatformDLCConfig(op);
        }
        public static async Task<Platform.Model.PlatformDLCConfigInfo?> ExecuteAsync(
            this GetPlatformDLCConfig.GetPlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            GetPlatformDLCConfig op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.DLC)builder.WrapperObject!).GetPlatformDLCConfigAsync(op);
        }
        public static Platform.Model.PlatformDLCConfigInfo? Execute(
            this UpdatePlatformDLCConfig.UpdatePlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            UpdatePlatformDLCConfig op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.DLC)builder.WrapperObject!).UpdatePlatformDLCConfig(op);
        }
        public static async Task<Platform.Model.PlatformDLCConfigInfo?> ExecuteAsync(
            this UpdatePlatformDLCConfig.UpdatePlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            UpdatePlatformDLCConfig op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.DLC)builder.WrapperObject!).UpdatePlatformDLCConfigAsync(op);
        }
        public static void Execute(
            this DeletePlatformDLCConfig.DeletePlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            DeletePlatformDLCConfig op = builder.Build(
                namespace_
            );

            ((Platform.Wrapper.DLC)builder.WrapperObject!).DeletePlatformDLCConfig(op);
        }
        public static async Task ExecuteAsync(
            this DeletePlatformDLCConfig.DeletePlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            DeletePlatformDLCConfig op = builder.Build(
                namespace_
            );

            await ((Platform.Wrapper.DLC)builder.WrapperObject!).DeletePlatformDLCConfigAsync(op);
        }
        public static Platform.Model.UserDLC? Execute(
            this GetUserDLCByPlatform.GetUserDLCByPlatformBuilder builder,
            string namespace_,
            string userId,
            string type
        )
        {
            GetUserDLCByPlatform op = builder.Build(
                namespace_,
                userId,
                type
            );

            return ((Platform.Wrapper.DLC)builder.WrapperObject!).GetUserDLCByPlatform(op);
        }
        public static async Task<Platform.Model.UserDLC?> ExecuteAsync(
            this GetUserDLCByPlatform.GetUserDLCByPlatformBuilder builder,
            string namespace_,
            string userId,
            string type
        )
        {
            GetUserDLCByPlatform op = builder.Build(
                namespace_,
                userId,
                type
            );

            return await ((Platform.Wrapper.DLC)builder.WrapperObject!).GetUserDLCByPlatformAsync(op);
        }
        public static List<Platform.Model.UserDLCRecord>? Execute(
            this GetUserDLC.GetUserDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserDLC op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.DLC)builder.WrapperObject!).GetUserDLC(op);
        }
        public static async Task<List<Platform.Model.UserDLCRecord>?> ExecuteAsync(
            this GetUserDLC.GetUserDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserDLC op = builder.Build(
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.DLC)builder.WrapperObject!).GetUserDLCAsync(op);
        }

        public static List<Platform.Model.UserDLCRecord<T1>>? Execute<T1>(
            this GetUserDLC.GetUserDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserDLC op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.DLC)builder.WrapperObject!).GetUserDLC<T1>(op);
        }
        public static async Task<List<Platform.Model.UserDLCRecord<T1>>?> ExecuteAsync<T1>(
            this GetUserDLC.GetUserDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserDLC op = builder.Build(
                namespace_,
                userId
            );

            return await ((Platform.Wrapper.DLC)builder.WrapperObject!).GetUserDLCAsync<T1>(op);
        }
        public static Platform.Model.DLCConfigRewardShortInfo? Execute(
            this GeDLCDurableRewardShortMap.GeDLCDurableRewardShortMapBuilder builder,
            string namespace_,
            string dlcType
        )
        {
            GeDLCDurableRewardShortMap op = builder.Build(
                namespace_,
                dlcType
            );

            return ((Platform.Wrapper.DLC)builder.WrapperObject!).GeDLCDurableRewardShortMap(op);
        }
        public static async Task<Platform.Model.DLCConfigRewardShortInfo?> ExecuteAsync(
            this GeDLCDurableRewardShortMap.GeDLCDurableRewardShortMapBuilder builder,
            string namespace_,
            string dlcType
        )
        {
            GeDLCDurableRewardShortMap op = builder.Build(
                namespace_,
                dlcType
            );

            return await ((Platform.Wrapper.DLC)builder.WrapperObject!).GeDLCDurableRewardShortMapAsync(op);
        }
        public static void Execute(
            this SyncEpicGameDLC.SyncEpicGameDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncEpicGameDLC op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.DLC)builder.WrapperObject!).SyncEpicGameDLC(op);
        }
        public static async Task ExecuteAsync(
            this SyncEpicGameDLC.SyncEpicGameDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncEpicGameDLC op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.DLC)builder.WrapperObject!).SyncEpicGameDLCAsync(op);
        }
        public static void Execute(
            this SyncOculusDLC.SyncOculusDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncOculusDLC op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.DLC)builder.WrapperObject!).SyncOculusDLC(op);
        }
        public static async Task ExecuteAsync(
            this SyncOculusDLC.SyncOculusDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncOculusDLC op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.DLC)builder.WrapperObject!).SyncOculusDLCAsync(op);
        }
        public static void Execute(
            this PublicSyncPsnDlcInventory.PublicSyncPsnDlcInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicSyncPsnDlcInventory op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.DLC)builder.WrapperObject!).PublicSyncPsnDlcInventory(op);
        }
        public static async Task ExecuteAsync(
            this PublicSyncPsnDlcInventory.PublicSyncPsnDlcInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicSyncPsnDlcInventory op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.DLC)builder.WrapperObject!).PublicSyncPsnDlcInventoryAsync(op);
        }
        public static void Execute(
            this PublicSyncPsnDlcInventoryWithMultipleServiceLabels.PublicSyncPsnDlcInventoryWithMultipleServiceLabelsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicSyncPsnDlcInventoryWithMultipleServiceLabels op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.DLC)builder.WrapperObject!).PublicSyncPsnDlcInventoryWithMultipleServiceLabels(op);
        }
        public static async Task ExecuteAsync(
            this PublicSyncPsnDlcInventoryWithMultipleServiceLabels.PublicSyncPsnDlcInventoryWithMultipleServiceLabelsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicSyncPsnDlcInventoryWithMultipleServiceLabels op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.DLC)builder.WrapperObject!).PublicSyncPsnDlcInventoryWithMultipleServiceLabelsAsync(op);
        }
        public static void Execute(
            this SyncSteamDLC.SyncSteamDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncSteamDLC op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.DLC)builder.WrapperObject!).SyncSteamDLC(op);
        }
        public static async Task ExecuteAsync(
            this SyncSteamDLC.SyncSteamDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncSteamDLC op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.DLC)builder.WrapperObject!).SyncSteamDLCAsync(op);
        }
        public static void Execute(
            this SyncXboxDLC.SyncXboxDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncXboxDLC op = builder.Build(
                namespace_,
                userId
            );

            ((Platform.Wrapper.DLC)builder.WrapperObject!).SyncXboxDLC(op);
        }
        public static async Task ExecuteAsync(
            this SyncXboxDLC.SyncXboxDLCBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncXboxDLC op = builder.Build(
                namespace_,
                userId
            );

            await ((Platform.Wrapper.DLC)builder.WrapperObject!).SyncXboxDLCAsync(op);
        }
        public static Platform.Model.SimpleUserDLCRewardContentsResponse? Execute(
            this PublicGetMyDLCContent.PublicGetMyDLCContentBuilder builder,
            string type
        )
        {
            PublicGetMyDLCContent op = builder.Build(
                type
            );

            return ((Platform.Wrapper.DLC)builder.WrapperObject!).PublicGetMyDLCContent(op);
        }
        public static async Task<Platform.Model.SimpleUserDLCRewardContentsResponse?> ExecuteAsync(
            this PublicGetMyDLCContent.PublicGetMyDLCContentBuilder builder,
            string type
        )
        {
            PublicGetMyDLCContent op = builder.Build(
                type
            );

            return await ((Platform.Wrapper.DLC)builder.WrapperObject!).PublicGetMyDLCContentAsync(op);
        }
    }
}