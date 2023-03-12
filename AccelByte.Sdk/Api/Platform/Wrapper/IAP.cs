// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class IAP
    {
        private readonly AccelByteSDK _sdk;

        public IAP(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetAppleIAPConfig.GetAppleIAPConfigBuilder GetAppleIAPConfigOp
        {
            get { return Operation.GetAppleIAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateAppleIAPConfig.UpdateAppleIAPConfigBuilder UpdateAppleIAPConfigOp
        {
            get { return Operation.UpdateAppleIAPConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteAppleIAPConfig.DeleteAppleIAPConfigBuilder DeleteAppleIAPConfigOp
        {
            get { return Operation.DeleteAppleIAPConfig.Builder.SetWrapperObject(this); }
        }
        public GetEpicGamesIAPConfig.GetEpicGamesIAPConfigBuilder GetEpicGamesIAPConfigOp
        {
            get { return Operation.GetEpicGamesIAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateEpicGamesIAPConfig.UpdateEpicGamesIAPConfigBuilder UpdateEpicGamesIAPConfigOp
        {
            get { return Operation.UpdateEpicGamesIAPConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteEpicGamesIAPConfig.DeleteEpicGamesIAPConfigBuilder DeleteEpicGamesIAPConfigOp
        {
            get { return Operation.DeleteEpicGamesIAPConfig.Builder.SetWrapperObject(this); }
        }
        public GetGoogleIAPConfig.GetGoogleIAPConfigBuilder GetGoogleIAPConfigOp
        {
            get { return Operation.GetGoogleIAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateGoogleIAPConfig.UpdateGoogleIAPConfigBuilder UpdateGoogleIAPConfigOp
        {
            get { return Operation.UpdateGoogleIAPConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteGoogleIAPConfig.DeleteGoogleIAPConfigBuilder DeleteGoogleIAPConfigOp
        {
            get { return Operation.DeleteGoogleIAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateGoogleP12File.UpdateGoogleP12FileBuilder UpdateGoogleP12FileOp
        {
            get { return Operation.UpdateGoogleP12File.Builder.SetWrapperObject(this); }
        }
        public GetIAPItemConfig.GetIAPItemConfigBuilder GetIAPItemConfigOp
        {
            get { return Operation.GetIAPItemConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateIAPItemConfig.UpdateIAPItemConfigBuilder UpdateIAPItemConfigOp
        {
            get { return Operation.UpdateIAPItemConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteIAPItemConfig.DeleteIAPItemConfigBuilder DeleteIAPItemConfigOp
        {
            get { return Operation.DeleteIAPItemConfig.Builder.SetWrapperObject(this); }
        }
        public GetPlayStationIAPConfig.GetPlayStationIAPConfigBuilder GetPlayStationIAPConfigOp
        {
            get { return Operation.GetPlayStationIAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdatePlaystationIAPConfig.UpdatePlaystationIAPConfigBuilder UpdatePlaystationIAPConfigOp
        {
            get { return Operation.UpdatePlaystationIAPConfig.Builder.SetWrapperObject(this); }
        }
        public DeletePlaystationIAPConfig.DeletePlaystationIAPConfigBuilder DeletePlaystationIAPConfigOp
        {
            get { return Operation.DeletePlaystationIAPConfig.Builder.SetWrapperObject(this); }
        }
        public GetSteamIAPConfig.GetSteamIAPConfigBuilder GetSteamIAPConfigOp
        {
            get { return Operation.GetSteamIAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateSteamIAPConfig.UpdateSteamIAPConfigBuilder UpdateSteamIAPConfigOp
        {
            get { return Operation.UpdateSteamIAPConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteSteamIAPConfig.DeleteSteamIAPConfigBuilder DeleteSteamIAPConfigOp
        {
            get { return Operation.DeleteSteamIAPConfig.Builder.SetWrapperObject(this); }
        }
        public GetTwitchIAPConfig.GetTwitchIAPConfigBuilder GetTwitchIAPConfigOp
        {
            get { return Operation.GetTwitchIAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateTwitchIAPConfig.UpdateTwitchIAPConfigBuilder UpdateTwitchIAPConfigOp
        {
            get { return Operation.UpdateTwitchIAPConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteTwitchIAPConfig.DeleteTwitchIAPConfigBuilder DeleteTwitchIAPConfigOp
        {
            get { return Operation.DeleteTwitchIAPConfig.Builder.SetWrapperObject(this); }
        }
        public GetXblIAPConfig.GetXblIAPConfigBuilder GetXblIAPConfigOp
        {
            get { return Operation.GetXblIAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateXblIAPConfig.UpdateXblIAPConfigBuilder UpdateXblIAPConfigOp
        {
            get { return Operation.UpdateXblIAPConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteXblAPConfig.DeleteXblAPConfigBuilder DeleteXblAPConfigOp
        {
            get { return Operation.DeleteXblAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateXblBPCertFile.UpdateXblBPCertFileBuilder UpdateXblBPCertFileOp
        {
            get { return Operation.UpdateXblBPCertFile.Builder.SetWrapperObject(this); }
        }
        public QueryUserIAPOrders.QueryUserIAPOrdersBuilder QueryUserIAPOrdersOp
        {
            get { return Operation.QueryUserIAPOrders.Builder.SetWrapperObject(this); }
        }
        public QueryAllUserIAPOrders.QueryAllUserIAPOrdersBuilder QueryAllUserIAPOrdersOp
        {
            get { return Operation.QueryAllUserIAPOrders.Builder.SetWrapperObject(this); }
        }
        public QueryUserIAPConsumeHistory.QueryUserIAPConsumeHistoryBuilder QueryUserIAPConsumeHistoryOp
        {
            get { return Operation.QueryUserIAPConsumeHistory.Builder.SetWrapperObject(this); }
        }
        public MockFulfillIAPItem.MockFulfillIAPItemBuilder MockFulfillIAPItemOp
        {
            get { return Operation.MockFulfillIAPItem.Builder.SetWrapperObject(this); }
        }
        public GetIAPItemMapping.GetIAPItemMappingBuilder GetIAPItemMappingOp
        {
            get { return Operation.GetIAPItemMapping.Builder.SetWrapperObject(this); }
        }
        public SyncTwitchDropsEntitlement.SyncTwitchDropsEntitlementBuilder SyncTwitchDropsEntitlementOp
        {
            get { return Operation.SyncTwitchDropsEntitlement.Builder.SetWrapperObject(this); }
        }
        public PublicFulfillAppleIAPItem.PublicFulfillAppleIAPItemBuilder PublicFulfillAppleIAPItemOp
        {
            get { return Operation.PublicFulfillAppleIAPItem.Builder.SetWrapperObject(this); }
        }
        public SyncEpicGamesInventory.SyncEpicGamesInventoryBuilder SyncEpicGamesInventoryOp
        {
            get { return Operation.SyncEpicGamesInventory.Builder.SetWrapperObject(this); }
        }
        public PublicFulfillGoogleIAPItem.PublicFulfillGoogleIAPItemBuilder PublicFulfillGoogleIAPItemOp
        {
            get { return Operation.PublicFulfillGoogleIAPItem.Builder.SetWrapperObject(this); }
        }
        public PublicReconcilePlayStationStore.PublicReconcilePlayStationStoreBuilder PublicReconcilePlayStationStoreOp
        {
            get { return Operation.PublicReconcilePlayStationStore.Builder.SetWrapperObject(this); }
        }
        public PublicReconcilePlayStationStoreWithMultipleServiceLabels.PublicReconcilePlayStationStoreWithMultipleServiceLabelsBuilder PublicReconcilePlayStationStoreWithMultipleServiceLabelsOp
        {
            get { return Operation.PublicReconcilePlayStationStoreWithMultipleServiceLabels.Builder.SetWrapperObject(this); }
        }
        public SyncSteamInventory.SyncSteamInventoryBuilder SyncSteamInventoryOp
        {
            get { return Operation.SyncSteamInventory.Builder.SetWrapperObject(this); }
        }
        public SyncTwitchDropsEntitlement1.SyncTwitchDropsEntitlement1Builder SyncTwitchDropsEntitlement1Op
        {
            get { return Operation.SyncTwitchDropsEntitlement1.Builder.SetWrapperObject(this); }
        }
        public SyncXboxInventory.SyncXboxInventoryBuilder SyncXboxInventoryOp
        {
            get { return Operation.SyncXboxInventory.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.AppleIAPConfigInfo? GetAppleIAPConfig(GetAppleIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppleIAPConfigInfo? UpdateAppleIAPConfig(UpdateAppleIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAppleIAPConfig(DeleteAppleIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EpicGamesIAPConfigInfo? GetEpicGamesIAPConfig(GetEpicGamesIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EpicGamesIAPConfigInfo? UpdateEpicGamesIAPConfig(UpdateEpicGamesIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteEpicGamesIAPConfig(DeleteEpicGamesIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GoogleIAPConfigInfo? GetGoogleIAPConfig(GetGoogleIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GoogleIAPConfigInfo? UpdateGoogleIAPConfig(UpdateGoogleIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGoogleIAPConfig(DeleteGoogleIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GoogleIAPConfigInfo? UpdateGoogleP12File(UpdateGoogleP12File input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPItemConfigInfo? GetIAPItemConfig(GetIAPItemConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPItemConfigInfo? UpdateIAPItemConfig(UpdateIAPItemConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteIAPItemConfig(DeleteIAPItemConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlayStationIAPConfigInfo? GetPlayStationIAPConfig(GetPlayStationIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlayStationIAPConfigInfo? UpdatePlaystationIAPConfig(UpdatePlaystationIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePlaystationIAPConfig(DeletePlaystationIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SteamIAPConfig? GetSteamIAPConfig(GetSteamIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SteamIAPConfigInfo? UpdateSteamIAPConfig(UpdateSteamIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSteamIAPConfig(DeleteSteamIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TwitchIAPConfigInfo? GetTwitchIAPConfig(GetTwitchIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TwitchIAPConfigInfo? UpdateTwitchIAPConfig(UpdateTwitchIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTwitchIAPConfig(DeleteTwitchIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.XblIAPConfigInfo? GetXblIAPConfig(GetXblIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.XblIAPConfigInfo? UpdateXblIAPConfig(UpdateXblIAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteXblAPConfig(DeleteXblAPConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.XblIAPConfigInfo? UpdateXblBPCertFile(UpdateXblBPCertFile input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPOrderPagingSlicedResult? QueryUserIAPOrders(QueryUserIAPOrders input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPOrderPagingSlicedResult? QueryAllUserIAPOrders(QueryAllUserIAPOrders input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPConsumeHistoryPagingSlicedResult? QueryUserIAPConsumeHistory(QueryUserIAPConsumeHistory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void MockFulfillIAPItem(MockFulfillIAPItem input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPItemMappingInfo? GetIAPItemMapping(GetIAPItemMapping input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.TwitchSyncResult>? SyncTwitchDropsEntitlement(SyncTwitchDropsEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicFulfillAppleIAPItem(PublicFulfillAppleIAPItem input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.EpicGamesReconcileResult>? SyncEpicGamesInventory(SyncEpicGamesInventory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GoogleReceiptResolveResult? PublicFulfillGoogleIAPItem(PublicFulfillGoogleIAPItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.PlayStationReconcileResult>? PublicReconcilePlayStationStore(PublicReconcilePlayStationStore input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.PlayStationReconcileResult>? PublicReconcilePlayStationStoreWithMultipleServiceLabels(PublicReconcilePlayStationStoreWithMultipleServiceLabels input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncSteamInventory(SyncSteamInventory input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SyncTwitchDropsEntitlement1(SyncTwitchDropsEntitlement1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.XblReconcileResult>? SyncXboxInventory(SyncXboxInventory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}