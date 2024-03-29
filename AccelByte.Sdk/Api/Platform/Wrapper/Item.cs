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
        public ListItemTypeConfigs.ListItemTypeConfigsBuilder ListItemTypeConfigsOp
        {
            get { return Operation.ListItemTypeConfigs.Builder.SetWrapperObject(this); }
        }
        public CreateItemTypeConfig.CreateItemTypeConfigBuilder CreateItemTypeConfigOp
        {
            get { return Operation.CreateItemTypeConfig.Builder.SetWrapperObject(this); }
        }
        public SearchItemTypeConfig.SearchItemTypeConfigBuilder SearchItemTypeConfigOp
        {
            get { return Operation.SearchItemTypeConfig.Builder.SetWrapperObject(this); }
        }
        public GetItemTypeConfig.GetItemTypeConfigBuilder GetItemTypeConfigOp
        {
            get { return Operation.GetItemTypeConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateItemTypeConfig.UpdateItemTypeConfigBuilder UpdateItemTypeConfigOp
        {
            get { return Operation.UpdateItemTypeConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteItemTypeConfig.DeleteItemTypeConfigBuilder DeleteItemTypeConfigOp
        {
            get { return Operation.DeleteItemTypeConfig.Builder.SetWrapperObject(this); }
        }
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
        public GetItems.GetItemsBuilder GetItemsOp
        {
            get { return Operation.GetItems.Builder.SetWrapperObject(this); }
        }
        public GetItemBySku.GetItemBySkuBuilder GetItemBySkuOp
        {
            get { return Operation.GetItemBySku.Builder.SetWrapperObject(this); }
        }
        public GetLocaleItemBySku.GetLocaleItemBySkuBuilder GetLocaleItemBySkuOp
        {
            get { return Operation.GetLocaleItemBySku.Builder.SetWrapperObject(this); }
        }
        public GetEstimatedPrice.GetEstimatedPriceBuilder GetEstimatedPriceOp
        {
            get { return Operation.GetEstimatedPrice.Builder.SetWrapperObject(this); }
        }
        public GetItemIdBySku.GetItemIdBySkuBuilder GetItemIdBySkuOp
        {
            get { return Operation.GetItemIdBySku.Builder.SetWrapperObject(this); }
        }
        public GetBulkItemIdBySkus.GetBulkItemIdBySkusBuilder GetBulkItemIdBySkusOp
        {
            get { return Operation.GetBulkItemIdBySkus.Builder.SetWrapperObject(this); }
        }
        public BulkGetLocaleItems.BulkGetLocaleItemsBuilder BulkGetLocaleItemsOp
        {
            get { return Operation.BulkGetLocaleItems.Builder.SetWrapperObject(this); }
        }
        public GetAvailablePredicateTypes.GetAvailablePredicateTypesBuilder GetAvailablePredicateTypesOp
        {
            get { return Operation.GetAvailablePredicateTypes.Builder.SetWrapperObject(this); }
        }
        public ValidateItemPurchaseCondition.ValidateItemPurchaseConditionBuilder ValidateItemPurchaseConditionOp
        {
            get { return Operation.ValidateItemPurchaseCondition.Builder.SetWrapperObject(this); }
        }
        public BulkUpdateRegionData.BulkUpdateRegionDataBuilder BulkUpdateRegionDataOp
        {
            get { return Operation.BulkUpdateRegionData.Builder.SetWrapperObject(this); }
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
        public UpdateItemPurchaseCondition.UpdateItemPurchaseConditionBuilder UpdateItemPurchaseConditionOp
        {
            get { return Operation.UpdateItemPurchaseCondition.Builder.SetWrapperObject(this); }
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
        public PublicGetEstimatedPrice.PublicGetEstimatedPriceBuilder PublicGetEstimatedPriceOp
        {
            get { return Operation.PublicGetEstimatedPrice.Builder.SetWrapperObject(this); }
        }
        public PublicBulkGetItems.PublicBulkGetItemsBuilder PublicBulkGetItemsOp
        {
            get { return Operation.PublicBulkGetItems.Builder.SetWrapperObject(this); }
        }
        public PublicValidateItemPurchaseCondition.PublicValidateItemPurchaseConditionBuilder PublicValidateItemPurchaseConditionOp
        {
            get { return Operation.PublicValidateItemPurchaseCondition.Builder.SetWrapperObject(this); }
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
        public QueryItems1.QueryItems1Builder QueryItems1Op
        {
            get { return Operation.QueryItems1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<Model.ItemTypeConfigInfo>? ListItemTypeConfigs(ListItemTypeConfigs input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CreateItemTypeConfig(CreateItemTypeConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemTypeConfigInfo? SearchItemTypeConfig(SearchItemTypeConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemTypeConfigInfo? GetItemTypeConfig(GetItemTypeConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemTypeConfigInfo? UpdateItemTypeConfig(UpdateItemTypeConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteItemTypeConfig(DeleteItemTypeConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? SyncInGameItem(SyncInGameItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? SyncInGameItem<T1>(SyncInGameItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? CreateItem(CreateItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? CreateItem<T1>(CreateItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? GetItemByAppId(GetItemByAppId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? GetItemByAppId<T1>(GetItemByAppId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemPagingSlicedResult? QueryItems(QueryItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BasicItem>? ListBasicItemsByFeatures(ListBasicItemsByFeatures input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.FullItemInfo>? GetItems(GetItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.FullItemInfo<T1>>? GetItems<T1>(GetItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? GetItemBySku(GetItemBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? GetItemBySku<T1>(GetItemBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PopulatedItemInfo? GetLocaleItemBySku(GetLocaleItemBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.PopulatedItemInfo<T1, T2>? GetLocaleItemBySku<T1, T2>(GetLocaleItemBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EstimatedPriceInfo? GetEstimatedPrice(GetEstimatedPrice input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemId? GetItemIdBySku(GetItemIdBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ItemId>? GetBulkItemIdBySkus(GetBulkItemIdBySkus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ItemInfo>? BulkGetLocaleItems(BulkGetLocaleItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.ItemInfo<T1, T2>>? BulkGetLocaleItems<T1, T2>(BulkGetLocaleItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.AvailablePredicate>? GetAvailablePredicateTypes(GetAvailablePredicateTypes input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ItemPurchaseConditionValidateResult>? ValidateItemPurchaseCondition(ValidateItemPurchaseCondition input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void BulkUpdateRegionData(BulkUpdateRegionData input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemPagingSlicedResult? SearchItems(SearchItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemPagingSlicedResult? QueryUncategorizedItems(QueryUncategorizedItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? GetItem(GetItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? GetItem<T1>(GetItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? UpdateItem(UpdateItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? UpdateItem<T1>(UpdateItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteItem(DeleteItem input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemAcquireResult? AcquireItem(AcquireItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullAppInfo? GetApp(GetApp input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullAppInfo? UpdateApp(UpdateApp input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? DisableItem(DisableItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? DisableItem<T1>(DisableItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemDynamicDataInfo? GetItemDynamicData(GetItemDynamicData input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? EnableItem(EnableItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? EnableItem<T1>(EnableItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? FeatureItem(FeatureItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? FeatureItem<T1>(FeatureItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? DefeatureItem(DefeatureItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? DefeatureItem<T1>(DefeatureItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PopulatedItemInfo? GetLocaleItem(GetLocaleItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.PopulatedItemInfo<T1, T2>? GetLocaleItem<T1, T2>(GetLocaleItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemInfo? UpdateItemPurchaseCondition(UpdateItemPurchaseCondition input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.FullItemInfo<T1>? UpdateItemPurchaseCondition<T1>(UpdateItemPurchaseCondition input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ReturnItem(ReturnItem input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemInfo? PublicGetItemByAppId(PublicGetItemByAppId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ItemInfo<T1, T2>? PublicGetItemByAppId<T1, T2>(PublicGetItemByAppId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemPagingSlicedResult? PublicQueryItems(PublicQueryItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemInfo? PublicGetItemBySku(PublicGetItemBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ItemInfo<T1, T2>? PublicGetItemBySku<T1, T2>(PublicGetItemBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.EstimatedPriceInfo>? PublicGetEstimatedPrice(PublicGetEstimatedPrice input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ItemInfo>? PublicBulkGetItems(PublicBulkGetItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public List<Model.ItemInfo<T1, T2>>? PublicBulkGetItems<T1, T2>(PublicBulkGetItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ItemPurchaseConditionValidateResult>? PublicValidateItemPurchaseCondition(PublicValidateItemPurchaseCondition input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemPagingSlicedResult? PublicSearchItems(PublicSearchItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppInfo? PublicGetApp(PublicGetApp input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ItemDynamicDataInfo? PublicGetItemDynamicData(PublicGetItemDynamicData input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PopulatedItemInfo? PublicGetItem(PublicGetItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.PopulatedItemInfo<T1, T2>? PublicGetItem<T1, T2>(PublicGetItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullItemPagingResult? QueryItems1(QueryItems1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}