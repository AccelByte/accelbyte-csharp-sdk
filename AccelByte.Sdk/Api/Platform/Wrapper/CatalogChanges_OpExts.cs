// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformCatalogChanges_OpExts
    {
        public static List<Platform.Model.CatalogChangePagingSlicedResult>? Execute(
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

    }
}