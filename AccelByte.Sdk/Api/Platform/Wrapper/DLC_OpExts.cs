// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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

    }
}