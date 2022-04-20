// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class DLC
    {
        private readonly AccelByteSDK _sdk;

        public DLC(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetDLCItemConfig.GetDLCItemConfigBuilder GetDLCItemConfigOp
        {
            get { return Operation.GetDLCItemConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateDLCItemConfig.UpdateDLCItemConfigBuilder UpdateDLCItemConfigOp
        {
            get { return Operation.UpdateDLCItemConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteDLCItemConfig.DeleteDLCItemConfigBuilder DeleteDLCItemConfigOp
        {
            get { return Operation.DeleteDLCItemConfig.Builder.SetWrapperObject(this); }
        }
        public GetPlatformDLCConfig.GetPlatformDLCConfigBuilder GetPlatformDLCConfigOp
        {
            get { return Operation.GetPlatformDLCConfig.Builder.SetWrapperObject(this); }
        }
        public UpdatePlatformDLCConfig.UpdatePlatformDLCConfigBuilder UpdatePlatformDLCConfigOp
        {
            get { return Operation.UpdatePlatformDLCConfig.Builder.SetWrapperObject(this); }
        }
        public DeletePlatformDLCConfig.DeletePlatformDLCConfigBuilder DeletePlatformDLCConfigOp
        {
            get { return Operation.DeletePlatformDLCConfig.Builder.SetWrapperObject(this); }
        }
        public PublicSyncPsnDlcInventory.PublicSyncPsnDlcInventoryBuilder PublicSyncPsnDlcInventoryOp
        {
            get { return Operation.PublicSyncPsnDlcInventory.Builder.SetWrapperObject(this); }
        }
        public SyncSteamDLC.SyncSteamDLCBuilder SyncSteamDLCOp
        {
            get { return Operation.SyncSteamDLC.Builder.SetWrapperObject(this); }
        }
        public SyncXboxDLC.SyncXboxDLCBuilder SyncXboxDLCOp
        {
            get { return Operation.SyncXboxDLC.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.DLCItemConfigInfo? GetDLCItemConfig(GetDLCItemConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.DLCItemConfigInfo? UpdateDLCItemConfig(UpdateDLCItemConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteDLCItemConfig(DeleteDLCItemConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformDLCConfigInfo? GetPlatformDLCConfig(GetPlatformDLCConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformDLCConfigInfo? UpdatePlatformDLCConfig(UpdatePlatformDLCConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePlatformDLCConfig(DeletePlatformDLCConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSyncPsnDlcInventory(PublicSyncPsnDlcInventory input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SyncSteamDLC(SyncSteamDLC input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SyncXboxDLC(SyncXboxDLC input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class DLC_OperationExtensions
    {
        public static Model.DLCItemConfigInfo? Execute(
            this GetDLCItemConfig.GetDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            GetDLCItemConfig op = builder.Build(
                namespace_
            );

            return ((DLC)builder.WrapperObject!).GetDLCItemConfig(op);
        }

        public static Model.DLCItemConfigInfo? Execute(
            this UpdateDLCItemConfig.UpdateDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            UpdateDLCItemConfig op = builder.Build(
                namespace_
            );

            return ((DLC)builder.WrapperObject!).UpdateDLCItemConfig(op);
        }

        public static void Execute(
            this DeleteDLCItemConfig.DeleteDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            DeleteDLCItemConfig op = builder.Build(
                namespace_
            );

            ((DLC)builder.WrapperObject!).DeleteDLCItemConfig(op);
        }

        public static Model.PlatformDLCConfigInfo? Execute(
            this GetPlatformDLCConfig.GetPlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            GetPlatformDLCConfig op = builder.Build(
                namespace_
            );

            return ((DLC)builder.WrapperObject!).GetPlatformDLCConfig(op);
        }

        public static Model.PlatformDLCConfigInfo? Execute(
            this UpdatePlatformDLCConfig.UpdatePlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            UpdatePlatformDLCConfig op = builder.Build(
                namespace_
            );

            return ((DLC)builder.WrapperObject!).UpdatePlatformDLCConfig(op);
        }

        public static void Execute(
            this DeletePlatformDLCConfig.DeletePlatformDLCConfigBuilder builder,
            string namespace_
        )
        {
            DeletePlatformDLCConfig op = builder.Build(
                namespace_
            );

            ((DLC)builder.WrapperObject!).DeletePlatformDLCConfig(op);
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

            ((DLC)builder.WrapperObject!).PublicSyncPsnDlcInventory(op);
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

            ((DLC)builder.WrapperObject!).SyncSteamDLC(op);
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

            ((DLC)builder.WrapperObject!).SyncXboxDLC(op);
        }

    }
}