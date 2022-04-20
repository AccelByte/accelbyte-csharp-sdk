// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        public GetStadiaIAPConfig.GetStadiaIAPConfigBuilder GetStadiaIAPConfigOp
        {
            get { return Operation.GetStadiaIAPConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteStadiaIAPConfig.DeleteStadiaIAPConfigBuilder DeleteStadiaIAPConfigOp
        {
            get { return Operation.DeleteStadiaIAPConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateStadiaJsonConfigFile.UpdateStadiaJsonConfigFileBuilder UpdateStadiaJsonConfigFileOp
        {
            get { return Operation.UpdateStadiaJsonConfigFile.Builder.SetWrapperObject(this); }
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
        public MockFulfillIAPItem.MockFulfillIAPItemBuilder MockFulfillIAPItemOp
        {
            get { return Operation.MockFulfillIAPItem.Builder.SetWrapperObject(this); }
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
        public SyncStadiaEntitlement.SyncStadiaEntitlementBuilder SyncStadiaEntitlementOp
        {
            get { return Operation.SyncStadiaEntitlement.Builder.SetWrapperObject(this); }
        }
        public SyncSteamInventory.SyncSteamInventoryBuilder SyncSteamInventoryOp
        {
            get { return Operation.SyncSteamInventory.Builder.SetWrapperObject(this); }
        }
        public SyncTwitchDropsEntitlement.SyncTwitchDropsEntitlementBuilder SyncTwitchDropsEntitlementOp
        {
            get { return Operation.SyncTwitchDropsEntitlement.Builder.SetWrapperObject(this); }
        }
        public SyncXboxInventory.SyncXboxInventoryBuilder SyncXboxInventoryOp
        {
            get { return Operation.SyncXboxInventory.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.AppleIAPConfigInfo? GetAppleIAPConfig(GetAppleIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppleIAPConfigInfo? UpdateAppleIAPConfig(UpdateAppleIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAppleIAPConfig(DeleteAppleIAPConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EpicGamesIAPConfigInfo? GetEpicGamesIAPConfig(GetEpicGamesIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.EpicGamesIAPConfigInfo? UpdateEpicGamesIAPConfig(UpdateEpicGamesIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteEpicGamesIAPConfig(DeleteEpicGamesIAPConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.GoogleIAPConfigInfo? GetGoogleIAPConfig(GetGoogleIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.GoogleIAPConfigInfo? UpdateGoogleIAPConfig(UpdateGoogleIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteGoogleIAPConfig(DeleteGoogleIAPConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.GoogleIAPConfigInfo? UpdateGoogleP12File(UpdateGoogleP12File input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPItemConfigInfo? GetIAPItemConfig(GetIAPItemConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPItemConfigInfo? UpdateIAPItemConfig(UpdateIAPItemConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteIAPItemConfig(DeleteIAPItemConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlayStationIAPConfigInfo? GetPlayStationIAPConfig(GetPlayStationIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlayStationIAPConfigInfo? UpdatePlaystationIAPConfig(UpdatePlaystationIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePlaystationIAPConfig(DeletePlaystationIAPConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StadiaIAPConfigInfo? GetStadiaIAPConfig(GetStadiaIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteStadiaIAPConfig(DeleteStadiaIAPConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.StadiaIAPConfigInfo? UpdateStadiaJsonConfigFile(UpdateStadiaJsonConfigFile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SteamIAPConfig? GetSteamIAPConfig(GetSteamIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.SteamIAPConfigInfo? UpdateSteamIAPConfig(UpdateSteamIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSteamIAPConfig(DeleteSteamIAPConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TwitchIAPConfigInfo? GetTwitchIAPConfig(GetTwitchIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.TwitchIAPConfigInfo? UpdateTwitchIAPConfig(UpdateTwitchIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteTwitchIAPConfig(DeleteTwitchIAPConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.XblIAPConfigInfo? GetXblIAPConfig(GetXblIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.XblIAPConfigInfo? UpdateXblIAPConfig(UpdateXblIAPConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteXblAPConfig(DeleteXblAPConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.XblIAPConfigInfo? UpdateXblBPCertFile(UpdateXblBPCertFile input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPOrderPagingSlicedResult? QueryUserIAPOrders(QueryUserIAPOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.IAPOrderPagingSlicedResult? QueryAllUserIAPOrders(QueryAllUserIAPOrders input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void MockFulfillIAPItem(MockFulfillIAPItem input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicFulfillAppleIAPItem(PublicFulfillAppleIAPItem input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.EpicGamesReconcileResult>? SyncEpicGamesInventory(SyncEpicGamesInventory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.GoogleReceiptResolveResult? PublicFulfillGoogleIAPItem(PublicFulfillGoogleIAPItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.PlayStationReconcileResult>? PublicReconcilePlayStationStore(PublicReconcilePlayStationStore input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SyncStadiaEntitlement(SyncStadiaEntitlement input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SyncSteamInventory(SyncSteamInventory input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SyncTwitchDropsEntitlement(SyncTwitchDropsEntitlement input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.XblReconcileResult>? SyncXboxInventory(SyncXboxInventory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class IAP_OperationExtensions
    {
        public static Model.AppleIAPConfigInfo? Execute(
            this GetAppleIAPConfig.GetAppleIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetAppleIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).GetAppleIAPConfig(op);
        }

        public static Model.AppleIAPConfigInfo? Execute(
            this UpdateAppleIAPConfig.UpdateAppleIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateAppleIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateAppleIAPConfig(op);
        }

        public static void Execute(
            this DeleteAppleIAPConfig.DeleteAppleIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteAppleIAPConfig op = builder.Build(
                namespace_
            );

            ((IAP)builder.WrapperObject!).DeleteAppleIAPConfig(op);
        }

        public static Model.EpicGamesIAPConfigInfo? Execute(
            this GetEpicGamesIAPConfig.GetEpicGamesIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetEpicGamesIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).GetEpicGamesIAPConfig(op);
        }

        public static Model.EpicGamesIAPConfigInfo? Execute(
            this UpdateEpicGamesIAPConfig.UpdateEpicGamesIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateEpicGamesIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateEpicGamesIAPConfig(op);
        }

        public static void Execute(
            this DeleteEpicGamesIAPConfig.DeleteEpicGamesIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteEpicGamesIAPConfig op = builder.Build(
                namespace_
            );

            ((IAP)builder.WrapperObject!).DeleteEpicGamesIAPConfig(op);
        }

        public static Model.GoogleIAPConfigInfo? Execute(
            this GetGoogleIAPConfig.GetGoogleIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetGoogleIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).GetGoogleIAPConfig(op);
        }

        public static Model.GoogleIAPConfigInfo? Execute(
            this UpdateGoogleIAPConfig.UpdateGoogleIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateGoogleIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateGoogleIAPConfig(op);
        }

        public static void Execute(
            this DeleteGoogleIAPConfig.DeleteGoogleIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteGoogleIAPConfig op = builder.Build(
                namespace_
            );

            ((IAP)builder.WrapperObject!).DeleteGoogleIAPConfig(op);
        }

        public static Model.GoogleIAPConfigInfo? Execute(
            this UpdateGoogleP12File.UpdateGoogleP12FileBuilder builder,
            string namespace_
        )
        {
            UpdateGoogleP12File op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateGoogleP12File(op);
        }

        public static Model.IAPItemConfigInfo? Execute(
            this GetIAPItemConfig.GetIAPItemConfigBuilder builder,
            string namespace_
        )
        {
            GetIAPItemConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).GetIAPItemConfig(op);
        }

        public static Model.IAPItemConfigInfo? Execute(
            this UpdateIAPItemConfig.UpdateIAPItemConfigBuilder builder,
            string namespace_
        )
        {
            UpdateIAPItemConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateIAPItemConfig(op);
        }

        public static void Execute(
            this DeleteIAPItemConfig.DeleteIAPItemConfigBuilder builder,
            string namespace_
        )
        {
            DeleteIAPItemConfig op = builder.Build(
                namespace_
            );

            ((IAP)builder.WrapperObject!).DeleteIAPItemConfig(op);
        }

        public static Model.PlayStationIAPConfigInfo? Execute(
            this GetPlayStationIAPConfig.GetPlayStationIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetPlayStationIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).GetPlayStationIAPConfig(op);
        }

        public static Model.PlayStationIAPConfigInfo? Execute(
            this UpdatePlaystationIAPConfig.UpdatePlaystationIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdatePlaystationIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdatePlaystationIAPConfig(op);
        }

        public static void Execute(
            this DeletePlaystationIAPConfig.DeletePlaystationIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeletePlaystationIAPConfig op = builder.Build(
                namespace_
            );

            ((IAP)builder.WrapperObject!).DeletePlaystationIAPConfig(op);
        }

        public static Model.StadiaIAPConfigInfo? Execute(
            this GetStadiaIAPConfig.GetStadiaIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetStadiaIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).GetStadiaIAPConfig(op);
        }

        public static void Execute(
            this DeleteStadiaIAPConfig.DeleteStadiaIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteStadiaIAPConfig op = builder.Build(
                namespace_
            );

            ((IAP)builder.WrapperObject!).DeleteStadiaIAPConfig(op);
        }

        public static Model.StadiaIAPConfigInfo? Execute(
            this UpdateStadiaJsonConfigFile.UpdateStadiaJsonConfigFileBuilder builder,
            string namespace_
        )
        {
            UpdateStadiaJsonConfigFile op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateStadiaJsonConfigFile(op);
        }

        public static Model.SteamIAPConfig? Execute(
            this GetSteamIAPConfig.GetSteamIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetSteamIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).GetSteamIAPConfig(op);
        }

        public static Model.SteamIAPConfigInfo? Execute(
            this UpdateSteamIAPConfig.UpdateSteamIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateSteamIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateSteamIAPConfig(op);
        }

        public static void Execute(
            this DeleteSteamIAPConfig.DeleteSteamIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteSteamIAPConfig op = builder.Build(
                namespace_
            );

            ((IAP)builder.WrapperObject!).DeleteSteamIAPConfig(op);
        }

        public static Model.TwitchIAPConfigInfo? Execute(
            this GetTwitchIAPConfig.GetTwitchIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetTwitchIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).GetTwitchIAPConfig(op);
        }

        public static Model.TwitchIAPConfigInfo? Execute(
            this UpdateTwitchIAPConfig.UpdateTwitchIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateTwitchIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateTwitchIAPConfig(op);
        }

        public static void Execute(
            this DeleteTwitchIAPConfig.DeleteTwitchIAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteTwitchIAPConfig op = builder.Build(
                namespace_
            );

            ((IAP)builder.WrapperObject!).DeleteTwitchIAPConfig(op);
        }

        public static Model.XblIAPConfigInfo? Execute(
            this GetXblIAPConfig.GetXblIAPConfigBuilder builder,
            string namespace_
        )
        {
            GetXblIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).GetXblIAPConfig(op);
        }

        public static Model.XblIAPConfigInfo? Execute(
            this UpdateXblIAPConfig.UpdateXblIAPConfigBuilder builder,
            string namespace_
        )
        {
            UpdateXblIAPConfig op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateXblIAPConfig(op);
        }

        public static void Execute(
            this DeleteXblAPConfig.DeleteXblAPConfigBuilder builder,
            string namespace_
        )
        {
            DeleteXblAPConfig op = builder.Build(
                namespace_
            );

            ((IAP)builder.WrapperObject!).DeleteXblAPConfig(op);
        }

        public static Model.XblIAPConfigInfo? Execute(
            this UpdateXblBPCertFile.UpdateXblBPCertFileBuilder builder,
            string namespace_
        )
        {
            UpdateXblBPCertFile op = builder.Build(
                namespace_
            );

            return ((IAP)builder.WrapperObject!).UpdateXblBPCertFile(op);
        }

        public static Model.IAPOrderPagingSlicedResult? Execute(
            this QueryUserIAPOrders.QueryUserIAPOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryUserIAPOrders op = builder.Build(
                namespace_,
                userId
            );

            return ((IAP)builder.WrapperObject!).QueryUserIAPOrders(op);
        }

        public static Model.IAPOrderPagingSlicedResult? Execute(
            this QueryAllUserIAPOrders.QueryAllUserIAPOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            QueryAllUserIAPOrders op = builder.Build(
                namespace_,
                userId
            );

            return ((IAP)builder.WrapperObject!).QueryAllUserIAPOrders(op);
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

            ((IAP)builder.WrapperObject!).MockFulfillIAPItem(op);
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

            ((IAP)builder.WrapperObject!).PublicFulfillAppleIAPItem(op);
        }

        public static List<Model.EpicGamesReconcileResult>? Execute(
            this SyncEpicGamesInventory.SyncEpicGamesInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncEpicGamesInventory op = builder.Build(
                namespace_,
                userId
            );

            return ((IAP)builder.WrapperObject!).SyncEpicGamesInventory(op);
        }

        public static Model.GoogleReceiptResolveResult? Execute(
            this PublicFulfillGoogleIAPItem.PublicFulfillGoogleIAPItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicFulfillGoogleIAPItem op = builder.Build(
                namespace_,
                userId
            );

            return ((IAP)builder.WrapperObject!).PublicFulfillGoogleIAPItem(op);
        }

        public static List<Model.PlayStationReconcileResult>? Execute(
            this PublicReconcilePlayStationStore.PublicReconcilePlayStationStoreBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicReconcilePlayStationStore op = builder.Build(
                namespace_,
                userId
            );

            return ((IAP)builder.WrapperObject!).PublicReconcilePlayStationStore(op);
        }

        public static void Execute(
            this SyncStadiaEntitlement.SyncStadiaEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncStadiaEntitlement op = builder.Build(
                namespace_,
                userId
            );

            ((IAP)builder.WrapperObject!).SyncStadiaEntitlement(op);
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

            ((IAP)builder.WrapperObject!).SyncSteamInventory(op);
        }

        public static void Execute(
            this SyncTwitchDropsEntitlement.SyncTwitchDropsEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncTwitchDropsEntitlement op = builder.Build(
                namespace_,
                userId
            );

            ((IAP)builder.WrapperObject!).SyncTwitchDropsEntitlement(op);
        }

        public static List<Model.XblReconcileResult>? Execute(
            this SyncXboxInventory.SyncXboxInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            SyncXboxInventory op = builder.Build(
                namespace_,
                userId
            );

            return ((IAP)builder.WrapperObject!).SyncXboxInventory(op);
        }

    }
}