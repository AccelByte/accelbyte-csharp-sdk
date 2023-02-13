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
    public static class PlatformItem_OpExts
    {
        public static List<Platform.Model.ItemTypeConfigInfo>? Execute(
            this ListItemTypeConfigs.ListItemTypeConfigsBuilder builder
        )
        {
            ListItemTypeConfigs op = builder.Build(
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).ListItemTypeConfigs(op);
        }
        public static void Execute(
            this CreateItemTypeConfig.CreateItemTypeConfigBuilder builder
        )
        {
            CreateItemTypeConfig op = builder.Build(
            );

            ((Platform.Wrapper.Item)builder.WrapperObject!).CreateItemTypeConfig(op);
        }
        public static Platform.Model.ItemTypeConfigInfo? Execute(
            this SearchItemTypeConfig.SearchItemTypeConfigBuilder builder,
            string itemType
        )
        {
            SearchItemTypeConfig op = builder.Build(
                itemType
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).SearchItemTypeConfig(op);
        }
        public static Platform.Model.ItemTypeConfigInfo? Execute(
            this GetItemTypeConfig.GetItemTypeConfigBuilder builder,
            string id
        )
        {
            GetItemTypeConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetItemTypeConfig(op);
        }
        public static Platform.Model.ItemTypeConfigInfo? Execute(
            this UpdateItemTypeConfig.UpdateItemTypeConfigBuilder builder,
            string id
        )
        {
            UpdateItemTypeConfig op = builder.Build(
                id
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).UpdateItemTypeConfig(op);
        }
        public static void Execute(
            this DeleteItemTypeConfig.DeleteItemTypeConfigBuilder builder,
            string id
        )
        {
            DeleteItemTypeConfig op = builder.Build(
                id
            );

            ((Platform.Wrapper.Item)builder.WrapperObject!).DeleteItemTypeConfig(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this SyncInGameItem.SyncInGameItemBuilder builder,
            string namespace_,
            string storeId
        )
        {
            SyncInGameItem op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).SyncInGameItem(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this SyncInGameItem.SyncInGameItemBuilder builder,
            string namespace_,
            string storeId
        )
        {
            SyncInGameItem op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).SyncInGameItem<T1>(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this CreateItem.CreateItemBuilder builder,
            string namespace_,
            string storeId
        )
        {
            CreateItem op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).CreateItem(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this CreateItem.CreateItemBuilder builder,
            string namespace_,
            string storeId
        )
        {
            CreateItem op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).CreateItem<T1>(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this GetItemByAppId.GetItemByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            GetItemByAppId op = builder.Build(
                namespace_,
                appId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetItemByAppId(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this GetItemByAppId.GetItemByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            GetItemByAppId op = builder.Build(
                namespace_,
                appId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetItemByAppId<T1>(op);
        }
        public static Platform.Model.FullItemPagingSlicedResult? Execute(
            this QueryItems.QueryItemsBuilder builder,
            string namespace_
        )
        {
            QueryItems op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).QueryItems(op);
        }
        public static List<Platform.Model.BasicItem>? Execute(
            this ListBasicItemsByFeatures.ListBasicItemsByFeaturesBuilder builder,
            string namespace_
        )
        {
            ListBasicItemsByFeatures op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).ListBasicItemsByFeatures(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this GetItemBySku.GetItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            GetItemBySku op = builder.Build(
                namespace_,
                sku
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetItemBySku(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this GetItemBySku.GetItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            GetItemBySku op = builder.Build(
                namespace_,
                sku
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetItemBySku<T1>(op);
        }
        public static Platform.Model.PopulatedItemInfo? Execute(
            this GetLocaleItemBySku.GetLocaleItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            GetLocaleItemBySku op = builder.Build(
                namespace_,
                sku
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetLocaleItemBySku(op);
        }

        public static Platform.Model.PopulatedItemInfo<T1, T2>? Execute<T1, T2>(
            this GetLocaleItemBySku.GetLocaleItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            GetLocaleItemBySku op = builder.Build(
                namespace_,
                sku
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetLocaleItemBySku<T1, T2>(op);
        }
        public static Platform.Model.ItemId? Execute(
            this GetItemIdBySku.GetItemIdBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            GetItemIdBySku op = builder.Build(
                namespace_,
                sku
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetItemIdBySku(op);
        }
        public static List<Platform.Model.ItemId>? Execute(
            this GetBulkItemIdBySkus.GetBulkItemIdBySkusBuilder builder,
            string namespace_
        )
        {
            GetBulkItemIdBySkus op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetBulkItemIdBySkus(op);
        }
        public static List<Platform.Model.ItemInfo>? Execute(
            this BulkGetLocaleItems.BulkGetLocaleItemsBuilder builder,
            string namespace_,
            string itemIds
        )
        {
            BulkGetLocaleItems op = builder.Build(
                namespace_,
                itemIds
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).BulkGetLocaleItems(op);
        }

        public static List<Platform.Model.ItemInfo<T1, T2>>? Execute<T1, T2>(
            this BulkGetLocaleItems.BulkGetLocaleItemsBuilder builder,
            string namespace_,
            string itemIds
        )
        {
            BulkGetLocaleItems op = builder.Build(
                namespace_,
                itemIds
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).BulkGetLocaleItems<T1, T2>(op);
        }
        public static List<Platform.Model.AvailablePredicateObject>? Execute(
            this GetAvailablePredicateTypes.GetAvailablePredicateTypesBuilder builder,
            string namespace_
        )
        {
            GetAvailablePredicateTypes op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetAvailablePredicateTypes(op);
        }
        public static List<Platform.Model.ItemPurchaseConditionValidateResult>? Execute(
            this ValidateItemPurchaseCondition.ValidateItemPurchaseConditionBuilder builder,
            string namespace_,
            string userId
        )
        {
            ValidateItemPurchaseCondition op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).ValidateItemPurchaseCondition(op);
        }
        public static Platform.Model.FullItemPagingSlicedResult? Execute(
            this SearchItems.SearchItemsBuilder builder,
            string namespace_,
            string keyword,
            string language
        )
        {
            SearchItems op = builder.Build(
                namespace_,
                keyword,
                language
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).SearchItems(op);
        }
        public static Platform.Model.FullItemPagingSlicedResult? Execute(
            this QueryUncategorizedItems.QueryUncategorizedItemsBuilder builder,
            string namespace_
        )
        {
            QueryUncategorizedItems op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).QueryUncategorizedItems(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this GetItem.GetItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            GetItem op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetItem(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this GetItem.GetItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            GetItem op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetItem<T1>(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this UpdateItem.UpdateItemBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            UpdateItem op = builder.Build(
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).UpdateItem(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this UpdateItem.UpdateItemBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            UpdateItem op = builder.Build(
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).UpdateItem<T1>(op);
        }
        public static void Execute(
            this DeleteItem.DeleteItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            DeleteItem op = builder.Build(
                itemId,
                namespace_
            );

            ((Platform.Wrapper.Item)builder.WrapperObject!).DeleteItem(op);
        }
        public static Platform.Model.ItemAcquireResult? Execute(
            this AcquireItem.AcquireItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            AcquireItem op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).AcquireItem(op);
        }
        public static Platform.Model.FullAppInfo? Execute(
            this GetApp.GetAppBuilder builder,
            string itemId,
            string namespace_
        )
        {
            GetApp op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetApp(op);
        }
        public static Platform.Model.FullAppInfo? Execute(
            this UpdateApp.UpdateAppBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            UpdateApp op = builder.Build(
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).UpdateApp(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this DisableItem.DisableItemBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            DisableItem op = builder.Build(
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).DisableItem(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this DisableItem.DisableItemBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            DisableItem op = builder.Build(
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).DisableItem<T1>(op);
        }
        public static Platform.Model.ItemDynamicDataInfo? Execute(
            this GetItemDynamicData.GetItemDynamicDataBuilder builder,
            string itemId,
            string namespace_
        )
        {
            GetItemDynamicData op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetItemDynamicData(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this EnableItem.EnableItemBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            EnableItem op = builder.Build(
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).EnableItem(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this EnableItem.EnableItemBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            EnableItem op = builder.Build(
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).EnableItem<T1>(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this FeatureItem.FeatureItemBuilder builder,
            string feature,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            FeatureItem op = builder.Build(
                feature,
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).FeatureItem(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this FeatureItem.FeatureItemBuilder builder,
            string feature,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            FeatureItem op = builder.Build(
                feature,
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).FeatureItem<T1>(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this DefeatureItem.DefeatureItemBuilder builder,
            string feature,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            DefeatureItem op = builder.Build(
                feature,
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).DefeatureItem(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this DefeatureItem.DefeatureItemBuilder builder,
            string feature,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            DefeatureItem op = builder.Build(
                feature,
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).DefeatureItem<T1>(op);
        }
        public static Platform.Model.PopulatedItemInfo? Execute(
            this GetLocaleItem.GetLocaleItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            GetLocaleItem op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetLocaleItem(op);
        }

        public static Platform.Model.PopulatedItemInfo<T1, T2>? Execute<T1, T2>(
            this GetLocaleItem.GetLocaleItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            GetLocaleItem op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).GetLocaleItem<T1, T2>(op);
        }
        public static Platform.Model.FullItemInfo? Execute(
            this UpdateItemPurchaseCondition.UpdateItemPurchaseConditionBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            UpdateItemPurchaseCondition op = builder.Build(
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).UpdateItemPurchaseCondition(op);
        }

        public static Platform.Model.FullItemInfo<T1>? Execute<T1>(
            this UpdateItemPurchaseCondition.UpdateItemPurchaseConditionBuilder builder,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            UpdateItemPurchaseCondition op = builder.Build(
                itemId,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).UpdateItemPurchaseCondition<T1>(op);
        }
        public static void Execute(
            this ReturnItem.ReturnItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            ReturnItem op = builder.Build(
                itemId,
                namespace_
            );

            ((Platform.Wrapper.Item)builder.WrapperObject!).ReturnItem(op);
        }
        public static Platform.Model.ItemInfo? Execute(
            this PublicGetItemByAppId.PublicGetItemByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            PublicGetItemByAppId op = builder.Build(
                namespace_,
                appId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicGetItemByAppId(op);
        }

        public static Platform.Model.ItemInfo<T1, T2>? Execute<T1, T2>(
            this PublicGetItemByAppId.PublicGetItemByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            PublicGetItemByAppId op = builder.Build(
                namespace_,
                appId
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicGetItemByAppId<T1, T2>(op);
        }
        public static Platform.Model.ItemPagingSlicedResult? Execute(
            this PublicQueryItems.PublicQueryItemsBuilder builder,
            string namespace_
        )
        {
            PublicQueryItems op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicQueryItems(op);
        }
        public static Platform.Model.ItemInfo? Execute(
            this PublicGetItemBySku.PublicGetItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PublicGetItemBySku op = builder.Build(
                namespace_,
                sku
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicGetItemBySku(op);
        }

        public static Platform.Model.ItemInfo<T1, T2>? Execute<T1, T2>(
            this PublicGetItemBySku.PublicGetItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PublicGetItemBySku op = builder.Build(
                namespace_,
                sku
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicGetItemBySku<T1, T2>(op);
        }
        public static List<Platform.Model.ItemInfo>? Execute(
            this PublicBulkGetItems.PublicBulkGetItemsBuilder builder,
            string namespace_,
            string itemIds
        )
        {
            PublicBulkGetItems op = builder.Build(
                namespace_,
                itemIds
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicBulkGetItems(op);
        }

        public static List<Platform.Model.ItemInfo<T1, T2>>? Execute<T1, T2>(
            this PublicBulkGetItems.PublicBulkGetItemsBuilder builder,
            string namespace_,
            string itemIds
        )
        {
            PublicBulkGetItems op = builder.Build(
                namespace_,
                itemIds
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicBulkGetItems<T1, T2>(op);
        }
        public static List<Platform.Model.ItemPurchaseConditionValidateResult>? Execute(
            this PublicValidateItemPurchaseCondition.PublicValidateItemPurchaseConditionBuilder builder,
            string namespace_
        )
        {
            PublicValidateItemPurchaseCondition op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicValidateItemPurchaseCondition(op);
        }
        public static Platform.Model.ItemPagingSlicedResult? Execute(
            this PublicSearchItems.PublicSearchItemsBuilder builder,
            string namespace_,
            string keyword,
            string language
        )
        {
            PublicSearchItems op = builder.Build(
                namespace_,
                keyword,
                language
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicSearchItems(op);
        }
        public static Platform.Model.AppInfo? Execute(
            this PublicGetApp.PublicGetAppBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PublicGetApp op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicGetApp(op);
        }
        public static Platform.Model.ItemDynamicDataInfo? Execute(
            this PublicGetItemDynamicData.PublicGetItemDynamicDataBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PublicGetItemDynamicData op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicGetItemDynamicData(op);
        }
        public static Platform.Model.PopulatedItemInfo? Execute(
            this PublicGetItem.PublicGetItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PublicGetItem op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicGetItem(op);
        }

        public static Platform.Model.PopulatedItemInfo<T1, T2>? Execute<T1, T2>(
            this PublicGetItem.PublicGetItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PublicGetItem op = builder.Build(
                itemId,
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).PublicGetItem<T1, T2>(op);
        }
        public static Platform.Model.FullItemPagingSlicedResult? Execute(
            this QueryItems1.QueryItems1Builder builder,
            string namespace_
        )
        {
            QueryItems1 op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Item)builder.WrapperObject!).QueryItems1(op);
        }
    }
}