// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformCategory_OpExts
    {
        public static List<Platform.Model.FullCategoryInfo>? Execute(
            this GetRootCategories.GetRootCategoriesBuilder builder,
            string namespace_
        )
        {
            GetRootCategories op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).GetRootCategories(op);
        }

        public static Platform.Model.FullCategoryInfo? Execute(
            this CreateCategory.CreateCategoryBuilder builder,
            string namespace_,
            string storeId
        )
        {
            CreateCategory op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).CreateCategory(op);
        }

        public static List<Platform.Model.BasicCategoryInfo>? Execute(
            this ListCategoriesBasic.ListCategoriesBasicBuilder builder,
            string namespace_
        )
        {
            ListCategoriesBasic op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).ListCategoriesBasic(op);
        }

        public static Platform.Model.FullCategoryInfo? Execute(
            this GetCategory.GetCategoryBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            GetCategory op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).GetCategory(op);
        }

        public static Platform.Model.FullCategoryInfo? Execute(
            this UpdateCategory.UpdateCategoryBuilder builder,
            string categoryPath,
            string namespace_,
            string storeId
        )
        {
            UpdateCategory op = builder.Build(
                categoryPath,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).UpdateCategory(op);
        }

        public static Platform.Model.FullCategoryInfo? Execute(
            this DeleteCategory.DeleteCategoryBuilder builder,
            string categoryPath,
            string namespace_,
            string storeId
        )
        {
            DeleteCategory op = builder.Build(
                categoryPath,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).DeleteCategory(op);
        }

        public static List<Platform.Model.FullCategoryInfo>? Execute(
            this GetChildCategories.GetChildCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            GetChildCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).GetChildCategories(op);
        }

        public static List<Platform.Model.FullCategoryInfo>? Execute(
            this GetDescendantCategories.GetDescendantCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            GetDescendantCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).GetDescendantCategories(op);
        }

        public static List<Platform.Model.CategoryInfo>? Execute(
            this PublicGetRootCategories.PublicGetRootCategoriesBuilder builder,
            string namespace_
        )
        {
            PublicGetRootCategories op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).PublicGetRootCategories(op);
        }

        public static List<Platform.Model.HierarchicalCategoryInfo>? Execute(
            this DownloadCategories.DownloadCategoriesBuilder builder,
            string namespace_
        )
        {
            DownloadCategories op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).DownloadCategories(op);
        }

        public static Platform.Model.CategoryInfo? Execute(
            this PublicGetCategory.PublicGetCategoryBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PublicGetCategory op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).PublicGetCategory(op);
        }

        public static List<Platform.Model.CategoryInfo>? Execute(
            this PublicGetChildCategories.PublicGetChildCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PublicGetChildCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).PublicGetChildCategories(op);
        }

        public static List<Platform.Model.CategoryInfo>? Execute(
            this PublicGetDescendantCategories.PublicGetDescendantCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PublicGetDescendantCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).PublicGetDescendantCategories(op);
        }

    }
}