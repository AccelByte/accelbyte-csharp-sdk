// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        public static async Task<List<Platform.Model.FullCategoryInfo>?> ExecuteAsync(
            this GetRootCategories.GetRootCategoriesBuilder builder,
            string namespace_
        )
        {
            GetRootCategories op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).GetRootCategoriesAsync(op);
        }
        public static Platform.Model.FullCategoryInfo? Execute(
            this CreateCategory.CreateCategoryBuilder builder,
            CategoryCreate body,
            string namespace_,
            string storeId
        )
        {
            CreateCategory op = builder.Build(
                body,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).CreateCategory(op);
        }
        public static async Task<Platform.Model.FullCategoryInfo?> ExecuteAsync(
            this CreateCategory.CreateCategoryBuilder builder,
            CategoryCreate body,
            string namespace_,
            string storeId
        )
        {
            CreateCategory op = builder.Build(
                body,
                namespace_,
                storeId
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).CreateCategoryAsync(op);
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
        public static async Task<List<Platform.Model.BasicCategoryInfo>?> ExecuteAsync(
            this ListCategoriesBasic.ListCategoriesBasicBuilder builder,
            string namespace_
        )
        {
            ListCategoriesBasic op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).ListCategoriesBasicAsync(op);
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
        public static async Task<Platform.Model.FullCategoryInfo?> ExecuteAsync(
            this GetCategory.GetCategoryBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            GetCategory op = builder.Build(
                categoryPath,
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).GetCategoryAsync(op);
        }
        public static Platform.Model.FullCategoryInfo? Execute(
            this UpdateCategory.UpdateCategoryBuilder builder,
            CategoryUpdate body,
            string categoryPath,
            string namespace_,
            string storeId
        )
        {
            UpdateCategory op = builder.Build(
                body,
                categoryPath,
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Category)builder.WrapperObject!).UpdateCategory(op);
        }
        public static async Task<Platform.Model.FullCategoryInfo?> ExecuteAsync(
            this UpdateCategory.UpdateCategoryBuilder builder,
            CategoryUpdate body,
            string categoryPath,
            string namespace_,
            string storeId
        )
        {
            UpdateCategory op = builder.Build(
                body,
                categoryPath,
                namespace_,
                storeId
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).UpdateCategoryAsync(op);
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
        public static async Task<Platform.Model.FullCategoryInfo?> ExecuteAsync(
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

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).DeleteCategoryAsync(op);
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
        public static async Task<List<Platform.Model.FullCategoryInfo>?> ExecuteAsync(
            this GetChildCategories.GetChildCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            GetChildCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).GetChildCategoriesAsync(op);
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
        public static async Task<List<Platform.Model.FullCategoryInfo>?> ExecuteAsync(
            this GetDescendantCategories.GetDescendantCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            GetDescendantCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).GetDescendantCategoriesAsync(op);
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
        public static async Task<List<Platform.Model.CategoryInfo>?> ExecuteAsync(
            this PublicGetRootCategories.PublicGetRootCategoriesBuilder builder,
            string namespace_
        )
        {
            PublicGetRootCategories op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).PublicGetRootCategoriesAsync(op);
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
        public static async Task<List<Platform.Model.HierarchicalCategoryInfo>?> ExecuteAsync(
            this DownloadCategories.DownloadCategoriesBuilder builder,
            string namespace_
        )
        {
            DownloadCategories op = builder.Build(
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).DownloadCategoriesAsync(op);
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
        public static async Task<Platform.Model.CategoryInfo?> ExecuteAsync(
            this PublicGetCategory.PublicGetCategoryBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PublicGetCategory op = builder.Build(
                categoryPath,
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).PublicGetCategoryAsync(op);
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
        public static async Task<List<Platform.Model.CategoryInfo>?> ExecuteAsync(
            this PublicGetChildCategories.PublicGetChildCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PublicGetChildCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).PublicGetChildCategoriesAsync(op);
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
        public static async Task<List<Platform.Model.CategoryInfo>?> ExecuteAsync(
            this PublicGetDescendantCategories.PublicGetDescendantCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PublicGetDescendantCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return await ((Platform.Wrapper.Category)builder.WrapperObject!).PublicGetDescendantCategoriesAsync(op);
        }
    }
}