// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
        public GetUserDLCByPlatform.GetUserDLCByPlatformBuilder GetUserDLCByPlatformOp
        {
            get { return Operation.GetUserDLCByPlatform.Builder.SetWrapperObject(this); }
        }
        public GetUserDLC.GetUserDLCBuilder GetUserDLCOp
        {
            get { return Operation.GetUserDLC.Builder.SetWrapperObject(this); }
        }
        public GeDLCDurableRewardShortMap.GeDLCDurableRewardShortMapBuilder GeDLCDurableRewardShortMapOp
        {
            get { return Operation.GeDLCDurableRewardShortMap.Builder.SetWrapperObject(this); }
        }
        public SyncEpicGameDLC.SyncEpicGameDLCBuilder SyncEpicGameDLCOp
        {
            get { return Operation.SyncEpicGameDLC.Builder.SetWrapperObject(this); }
        }
        public SyncOculusDLC.SyncOculusDLCBuilder SyncOculusDLCOp
        {
            get { return Operation.SyncOculusDLC.Builder.SetWrapperObject(this); }
        }
        public PublicSyncPsnDlcInventory.PublicSyncPsnDlcInventoryBuilder PublicSyncPsnDlcInventoryOp
        {
            get { return Operation.PublicSyncPsnDlcInventory.Builder.SetWrapperObject(this); }
        }
        public PublicSyncPsnDlcInventoryWithMultipleServiceLabels.PublicSyncPsnDlcInventoryWithMultipleServiceLabelsBuilder PublicSyncPsnDlcInventoryWithMultipleServiceLabelsOp
        {
            get { return Operation.PublicSyncPsnDlcInventoryWithMultipleServiceLabels.Builder.SetWrapperObject(this); }
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

        public Model.DLCItemConfigInfo? GetDLCItemConfig(GetDLCItemConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DLCItemConfigInfo?> GetDLCItemConfigAsync(GetDLCItemConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.DLCItemConfigInfo? UpdateDLCItemConfig(UpdateDLCItemConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DLCItemConfigInfo?> UpdateDLCItemConfigAsync(UpdateDLCItemConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteDLCItemConfig(DeleteDLCItemConfig input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteDLCItemConfigAsync(DeleteDLCItemConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformDLCConfigInfo? GetPlatformDLCConfig(GetPlatformDLCConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PlatformDLCConfigInfo?> GetPlatformDLCConfigAsync(GetPlatformDLCConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformDLCConfigInfo? UpdatePlatformDLCConfig(UpdatePlatformDLCConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PlatformDLCConfigInfo?> UpdatePlatformDLCConfigAsync(UpdatePlatformDLCConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePlatformDLCConfig(DeletePlatformDLCConfig input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeletePlatformDLCConfigAsync(DeletePlatformDLCConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserDLC? GetUserDLCByPlatform(GetUserDLCByPlatform input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.UserDLC?> GetUserDLCByPlatformAsync(GetUserDLCByPlatform input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.UserDLCRecord>? GetUserDLC(GetUserDLC input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.UserDLCRecord>?> GetUserDLCAsync(GetUserDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.UserDLCRecord<T1>>? GetUserDLC<T1>(GetUserDLC input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.UserDLCRecord<T1>>?> GetUserDLCAsync<T1>(GetUserDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.DLCConfigRewardShortInfo? GeDLCDurableRewardShortMap(GeDLCDurableRewardShortMap input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DLCConfigRewardShortInfo?> GeDLCDurableRewardShortMapAsync(GeDLCDurableRewardShortMap input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncEpicGameDLC(SyncEpicGameDLC input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SyncEpicGameDLCAsync(SyncEpicGameDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncOculusDLC(SyncOculusDLC input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SyncOculusDLCAsync(SyncOculusDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSyncPsnDlcInventory(PublicSyncPsnDlcInventory input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicSyncPsnDlcInventoryAsync(PublicSyncPsnDlcInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSyncPsnDlcInventoryWithMultipleServiceLabels(PublicSyncPsnDlcInventoryWithMultipleServiceLabels input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublicSyncPsnDlcInventoryWithMultipleServiceLabelsAsync(PublicSyncPsnDlcInventoryWithMultipleServiceLabels input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncSteamDLC(SyncSteamDLC input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SyncSteamDLCAsync(SyncSteamDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncXboxDLC(SyncXboxDLC input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SyncXboxDLCAsync(SyncXboxDLC input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}