// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
}