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
    public static class PlatformStore_OpExts
    {
        public static List<Platform.Model.StoreInfo>? Execute(
            this ListStores.ListStoresBuilder builder,
            string namespace_
        )
        {
            ListStores op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).ListStores(op);
        }

        public static Platform.Model.StoreInfo? Execute(
            this CreateStore.CreateStoreBuilder builder,
            string namespace_
        )
        {
            CreateStore op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).CreateStore(op);
        }

        public static Platform.Model.StoreInfo? Execute(
            this ImportStore.ImportStoreBuilder builder,
            string namespace_
        )
        {
            ImportStore op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).ImportStore(op);
        }

        public static Platform.Model.StoreInfo? Execute(
            this GetPublishedStore.GetPublishedStoreBuilder builder,
            string namespace_
        )
        {
            GetPublishedStore op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).GetPublishedStore(op);
        }

        public static Platform.Model.StoreInfo? Execute(
            this DeletePublishedStore.DeletePublishedStoreBuilder builder,
            string namespace_
        )
        {
            DeletePublishedStore op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).DeletePublishedStore(op);
        }

        public static Platform.Model.StoreBackupInfo? Execute(
            this GetPublishedStoreBackup.GetPublishedStoreBackupBuilder builder,
            string namespace_
        )
        {
            GetPublishedStoreBackup op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).GetPublishedStoreBackup(op);
        }

        public static Platform.Model.StoreInfo? Execute(
            this RollbackPublishedStore.RollbackPublishedStoreBuilder builder,
            string namespace_
        )
        {
            RollbackPublishedStore op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).RollbackPublishedStore(op);
        }

        public static Platform.Model.StoreInfo? Execute(
            this GetStore.GetStoreBuilder builder,
            string namespace_,
            string storeId
        )
        {
            GetStore op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).GetStore(op);
        }

        public static Platform.Model.StoreInfo? Execute(
            this UpdateStore.UpdateStoreBuilder builder,
            string namespace_,
            string storeId
        )
        {
            UpdateStore op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).UpdateStore(op);
        }

        public static Platform.Model.StoreInfo? Execute(
            this DeleteStore.DeleteStoreBuilder builder,
            string namespace_,
            string storeId
        )
        {
            DeleteStore op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).DeleteStore(op);
        }

        public static Platform.Model.StoreInfo? Execute(
            this CloneStore.CloneStoreBuilder builder,
            string namespace_,
            string storeId
        )
        {
            CloneStore op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).CloneStore(op);
        }

        public static void Execute(
            this ExportStore.ExportStoreBuilder builder,
            string namespace_,
            string storeId
        )
        {
            ExportStore op = builder.Build(
                namespace_,
                storeId
            );

            ((Platform.Wrapper.Store)builder.WrapperObject!).ExportStore(op);
        }

        public static List<Platform.Model.StoreInfo>? Execute(
            this PublicListStores.PublicListStoresBuilder builder,
            string namespace_
        )
        {
            PublicListStores op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Store)builder.WrapperObject!).PublicListStores(op);
        }

    }
}