// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Item
    {
        private readonly AccelByteSDK _sdk;

        public Item(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public SyncInGameItem.SyncInGameItemBuilder SyncInGameItemOp
        {
            get { return Operation.SyncInGameItem.Builder.SetWrapperObject(this); }
        }
        public CreateItem.CreateItemBuilder CreateItemOp
        {
            get { return Operation.CreateItem.Builder.SetWrapperObject(this); }
        }
        public GetItemByAppId.GetItemByAppIdBuilder GetItemByAppIdOp
        {
            get { return Operation.GetItemByAppId.Builder.SetWrapperObject(this); }
        }
        public QueryItems.QueryItemsBuilder QueryItemsOp
        {
            get { return Operation.QueryItems.Builder.SetWrapperObject(this); }
        }
        public ListBasicItemsByFeatures.ListBasicItemsByFeaturesBuilder ListBasicItemsByFeaturesOp
        {
            get { return Operation.ListBasicItemsByFeatures.Builder.SetWrapperObject(this); }
        }
        public GetItemBySku.GetItemBySkuBuilder GetItemBySkuOp
        {
            get { return Operation.GetItemBySku.Builder.SetWrapperObject(this); }
        }
        public GetLocaleItemBySku.GetLocaleItemBySkuBuilder GetLocaleItemBySkuOp
        {
            get { return Operation.GetLocaleItemBySku.Builder.SetWrapperObject(this); }
        }
        public GetItemIdBySku.GetItemIdBySkuBuilder GetItemIdBySkuOp
        {
            get { return Operation.GetItemIdBySku.Builder.SetWrapperObject(this); }
        }
        public BulkGetLocaleItems.BulkGetLocaleItemsBuilder BulkGetLocaleItemsOp
        {
            get { return Operation.BulkGetLocaleItems.Builder.SetWrapperObject(this); }
        }
        public SearchItems.SearchItemsBuilder SearchItemsOp
        {
            get { return Operation.SearchItems.Builder.SetWrapperObject(this); }
        }
        public QueryUncategorizedItems.QueryUncategorizedItemsBuilder QueryUncategorizedItemsOp
        {
            get { return Operation.QueryUncategorizedItems.Builder.SetWrapperObject(this); }
        }
        public GetItem.GetItemBuilder GetItemOp
        {
            get { return Operation.GetItem.Builder.SetWrapperObject(this); }
        }
        public UpdateItem.UpdateItemBuilder UpdateItemOp
        {
            get { return Operation.UpdateItem.Builder.SetWrapperObject(this); }
        }
        public DeleteItem.DeleteItemBuilder DeleteItemOp
        {
            get { return Operation.DeleteItem.Builder.SetWrapperObject(this); }
        }
        public AcquireItem.AcquireItemBuilder AcquireItemOp
        {
            get { return Operation.AcquireItem.Builder.SetWrapperObject(this); }
        }
        public GetApp.GetAppBuilder GetAppOp
        {
            get { return Operation.GetApp.Builder.SetWrapperObject(this); }
        }
        public UpdateApp.UpdateAppBuilder UpdateAppOp
        {
            get { return Operation.UpdateApp.Builder.SetWrapperObject(this); }
        }
        public DisableItem.DisableItemBuilder DisableItemOp
        {
            get { return Operation.DisableItem.Builder.SetWrapperObject(this); }
        }
        public GetItemDynamicData.GetItemDynamicDataBuilder GetItemDynamicDataOp
        {
            get { return Operation.GetItemDynamicData.Builder.SetWrapperObject(this); }
        }
        public EnableItem.EnableItemBuilder EnableItemOp
        {
            get { return Operation.EnableItem.Builder.SetWrapperObject(this); }
        }
        public FeatureItem.FeatureItemBuilder FeatureItemOp
        {
            get { return Operation.FeatureItem.Builder.SetWrapperObject(this); }
        }
        public DefeatureItem.DefeatureItemBuilder DefeatureItemOp
        {
            get { return Operation.DefeatureItem.Builder.SetWrapperObject(this); }
        }
        public GetLocaleItem.GetLocaleItemBuilder GetLocaleItemOp
        {
            get { return Operation.GetLocaleItem.Builder.SetWrapperObject(this); }
        }
        public ReturnItem.ReturnItemBuilder ReturnItemOp
        {
            get { return Operation.ReturnItem.Builder.SetWrapperObject(this); }
        }
        public PublicGetItemByAppId.PublicGetItemByAppIdBuilder PublicGetItemByAppIdOp
        {
            get { return Operation.PublicGetItemByAppId.Builder.SetWrapperObject(this); }
        }
        public PublicQueryItems.PublicQueryItemsBuilder PublicQueryItemsOp
        {
            get { return Operation.PublicQueryItems.Builder.SetWrapperObject(this); }
        }
        public PublicGetItemBySku.PublicGetItemBySkuBuilder PublicGetItemBySkuOp
        {
            get { return Operation.PublicGetItemBySku.Builder.SetWrapperObject(this); }
        }
        public PublicBulkGetItems.PublicBulkGetItemsBuilder PublicBulkGetItemsOp
        {
            get { return Operation.PublicBulkGetItems.Builder.SetWrapperObject(this); }
        }
        public PublicSearchItems.PublicSearchItemsBuilder PublicSearchItemsOp
        {
            get { return Operation.PublicSearchItems.Builder.SetWrapperObject(this); }
        }
        public PublicGetApp.PublicGetAppBuilder PublicGetAppOp
        {
            get { return Operation.PublicGetApp.Builder.SetWrapperObject(this); }
        }
        public PublicGetItemDynamicData.PublicGetItemDynamicDataBuilder PublicGetItemDynamicDataOp
        {
            get { return Operation.PublicGetItemDynamicData.Builder.SetWrapperObject(this); }
        }
        public PublicGetItem.PublicGetItemBuilder PublicGetItemOp
        {
            get { return Operation.PublicGetItem.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.FullItemInfo? SyncInGameItem(SyncInGameItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? CreateItem(CreateItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? GetItemByAppId(GetItemByAppId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemPagingSlicedResult? QueryItems(QueryItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BasicItem>? ListBasicItemsByFeatures(ListBasicItemsByFeatures input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? GetItemBySku(GetItemBySku input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PopulatedItemInfo? GetLocaleItemBySku(GetLocaleItemBySku input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemId? GetItemIdBySku(GetItemIdBySku input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ItemInfo>? BulkGetLocaleItems(BulkGetLocaleItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemPagingSlicedResult? SearchItems(SearchItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemPagingSlicedResult? QueryUncategorizedItems(QueryUncategorizedItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? GetItem(GetItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? UpdateItem(UpdateItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteItem(DeleteItem input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemAcquireResult? AcquireItem(AcquireItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullAppInfo? GetApp(GetApp input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullAppInfo? UpdateApp(UpdateApp input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? DisableItem(DisableItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemDynamicDataInfo? GetItemDynamicData(GetItemDynamicData input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? EnableItem(EnableItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? FeatureItem(FeatureItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? DefeatureItem(DefeatureItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PopulatedItemInfo? GetLocaleItem(GetLocaleItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ReturnItem(ReturnItem input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemInfo? PublicGetItemByAppId(PublicGetItemByAppId input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemPagingSlicedResult? PublicQueryItems(PublicQueryItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemInfo? PublicGetItemBySku(PublicGetItemBySku input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ItemInfo>? PublicBulkGetItems(PublicBulkGetItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemPagingSlicedResult? PublicSearchItems(PublicSearchItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppInfo? PublicGetApp(PublicGetApp input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemDynamicDataInfo? PublicGetItemDynamicData(PublicGetItemDynamicData input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.PopulatedItemInfo? PublicGetItem(PublicGetItem input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}