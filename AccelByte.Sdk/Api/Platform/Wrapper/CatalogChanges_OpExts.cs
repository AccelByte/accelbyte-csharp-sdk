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
    public static class PlatformCatalogChanges_OpExts
    {
        public static Platform.Model.CatalogChangePagingResult? Execute(
            this QueryChanges.QueryChangesBuilder builder,
            string namespace_,
            string storeId
        )
        {
            QueryChanges op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.CatalogChanges)builder.WrapperObject!).QueryChanges(op);
        }
        public static Platform.Model.StoreInfo? Execute(
            this PublishAll.PublishAllBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PublishAll op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.CatalogChanges)builder.WrapperObject!).PublishAll(op);
        }
        public static Platform.Model.StoreInfo? Execute(
            this PublishSelected.PublishSelectedBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PublishSelected op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.CatalogChanges)builder.WrapperObject!).PublishSelected(op);
        }
        public static void Execute(
            this SelectAllRecords.SelectAllRecordsBuilder builder,
            string namespace_,
            string storeId
        )
        {
            SelectAllRecords op = builder.Build(
                namespace_,
                storeId
            );

            ((Platform.Wrapper.CatalogChanges)builder.WrapperObject!).SelectAllRecords(op);
        }
        public static void Execute(
            this SelectAllRecordsByCriteria.SelectAllRecordsByCriteriaBuilder builder,
            string namespace_,
            string storeId
        )
        {
            SelectAllRecordsByCriteria op = builder.Build(
                namespace_,
                storeId
            );

            ((Platform.Wrapper.CatalogChanges)builder.WrapperObject!).SelectAllRecordsByCriteria(op);
        }
        public static Platform.Model.CatalogChangeStatistics? Execute(
            this GetStatistic.GetStatisticBuilder builder,
            string namespace_,
            string storeId
        )
        {
            GetStatistic op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.CatalogChanges)builder.WrapperObject!).GetStatistic(op);
        }
        public static void Execute(
            this UnselectAllRecords.UnselectAllRecordsBuilder builder,
            string namespace_,
            string storeId
        )
        {
            UnselectAllRecords op = builder.Build(
                namespace_,
                storeId
            );

            ((Platform.Wrapper.CatalogChanges)builder.WrapperObject!).UnselectAllRecords(op);
        }
        public static void Execute(
            this SelectRecord.SelectRecordBuilder builder,
            string changeId,
            string namespace_,
            string storeId
        )
        {
            SelectRecord op = builder.Build(
                changeId,
                namespace_,
                storeId
            );

            ((Platform.Wrapper.CatalogChanges)builder.WrapperObject!).SelectRecord(op);
        }
        public static void Execute(
            this UnselectRecord.UnselectRecordBuilder builder,
            string changeId,
            string namespace_,
            string storeId
        )
        {
            UnselectRecord op = builder.Build(
                changeId,
                namespace_,
                storeId
            );

            ((Platform.Wrapper.CatalogChanges)builder.WrapperObject!).UnselectRecord(op);
        }
    }
}