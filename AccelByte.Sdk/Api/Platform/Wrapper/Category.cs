// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Category
    {
        private readonly AccelByteSDK _sdk;

        public Category(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetRootCategories.GetRootCategoriesBuilder GetRootCategoriesOp
        {
            get { return Operation.GetRootCategories.Builder.SetWrapperObject(this); }
        }
        public CreateCategory.CreateCategoryBuilder CreateCategoryOp
        {
            get { return Operation.CreateCategory.Builder.SetWrapperObject(this); }
        }
        public ListCategoriesBasic.ListCategoriesBasicBuilder ListCategoriesBasicOp
        {
            get { return Operation.ListCategoriesBasic.Builder.SetWrapperObject(this); }
        }
        public GetCategory.GetCategoryBuilder GetCategoryOp
        {
            get { return Operation.GetCategory.Builder.SetWrapperObject(this); }
        }
        public UpdateCategory.UpdateCategoryBuilder UpdateCategoryOp
        {
            get { return Operation.UpdateCategory.Builder.SetWrapperObject(this); }
        }
        public DeleteCategory.DeleteCategoryBuilder DeleteCategoryOp
        {
            get { return Operation.DeleteCategory.Builder.SetWrapperObject(this); }
        }
        public GetChildCategories.GetChildCategoriesBuilder GetChildCategoriesOp
        {
            get { return Operation.GetChildCategories.Builder.SetWrapperObject(this); }
        }
        public GetDescendantCategories.GetDescendantCategoriesBuilder GetDescendantCategoriesOp
        {
            get { return Operation.GetDescendantCategories.Builder.SetWrapperObject(this); }
        }
        public PublicGetRootCategories.PublicGetRootCategoriesBuilder PublicGetRootCategoriesOp
        {
            get { return Operation.PublicGetRootCategories.Builder.SetWrapperObject(this); }
        }
        public DownloadCategories.DownloadCategoriesBuilder DownloadCategoriesOp
        {
            get { return Operation.DownloadCategories.Builder.SetWrapperObject(this); }
        }
        public PublicGetCategory.PublicGetCategoryBuilder PublicGetCategoryOp
        {
            get { return Operation.PublicGetCategory.Builder.SetWrapperObject(this); }
        }
        public PublicGetChildCategories.PublicGetChildCategoriesBuilder PublicGetChildCategoriesOp
        {
            get { return Operation.PublicGetChildCategories.Builder.SetWrapperObject(this); }
        }
        public PublicGetDescendantCategories.PublicGetDescendantCategoriesBuilder PublicGetDescendantCategoriesOp
        {
            get { return Operation.PublicGetDescendantCategories.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.FullCategoryInfo>? GetRootCategories(GetRootCategories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullCategoryInfo? CreateCategory(CreateCategory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.BasicCategoryInfo>? ListCategoriesBasic(ListCategoriesBasic input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullCategoryInfo? GetCategory(GetCategory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullCategoryInfo? UpdateCategory(UpdateCategory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.FullCategoryInfo? DeleteCategory(DeleteCategory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.FullCategoryInfo>? GetChildCategories(GetChildCategories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.FullCategoryInfo>? GetDescendantCategories(GetDescendantCategories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CategoryInfo>? PublicGetRootCategories(PublicGetRootCategories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.HierarchicalCategoryInfo>? DownloadCategories(DownloadCategories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CategoryInfo? PublicGetCategory(PublicGetCategory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CategoryInfo>? PublicGetChildCategories(PublicGetChildCategories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CategoryInfo>? PublicGetDescendantCategories(PublicGetDescendantCategories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Category_OperationExtensions
    {
        public static List<Model.FullCategoryInfo>? Execute(
            this GetRootCategories.GetRootCategoriesBuilder builder,
            string namespace_
        )
        {
            GetRootCategories op = builder.Build(
                namespace_
            );

            return ((Category)builder.WrapperObject!).GetRootCategories(op);
        }

        public static Model.FullCategoryInfo? Execute(
            this CreateCategory.CreateCategoryBuilder builder,
            string namespace_,
            string storeId
        )
        {
            CreateCategory op = builder.Build(
                namespace_,
                storeId
            );

            return ((Category)builder.WrapperObject!).CreateCategory(op);
        }

        public static List<Model.BasicCategoryInfo>? Execute(
            this ListCategoriesBasic.ListCategoriesBasicBuilder builder,
            string namespace_
        )
        {
            ListCategoriesBasic op = builder.Build(
                namespace_
            );

            return ((Category)builder.WrapperObject!).ListCategoriesBasic(op);
        }

        public static Model.FullCategoryInfo? Execute(
            this GetCategory.GetCategoryBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            GetCategory op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Category)builder.WrapperObject!).GetCategory(op);
        }

        public static Model.FullCategoryInfo? Execute(
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

            return ((Category)builder.WrapperObject!).UpdateCategory(op);
        }

        public static Model.FullCategoryInfo? Execute(
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

            return ((Category)builder.WrapperObject!).DeleteCategory(op);
        }

        public static List<Model.FullCategoryInfo>? Execute(
            this GetChildCategories.GetChildCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            GetChildCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Category)builder.WrapperObject!).GetChildCategories(op);
        }

        public static List<Model.FullCategoryInfo>? Execute(
            this GetDescendantCategories.GetDescendantCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            GetDescendantCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Category)builder.WrapperObject!).GetDescendantCategories(op);
        }

        public static List<Model.CategoryInfo>? Execute(
            this PublicGetRootCategories.PublicGetRootCategoriesBuilder builder,
            string namespace_
        )
        {
            PublicGetRootCategories op = builder.Build(
                namespace_
            );

            return ((Category)builder.WrapperObject!).PublicGetRootCategories(op);
        }

        public static List<Model.HierarchicalCategoryInfo>? Execute(
            this DownloadCategories.DownloadCategoriesBuilder builder,
            string namespace_
        )
        {
            DownloadCategories op = builder.Build(
                namespace_
            );

            return ((Category)builder.WrapperObject!).DownloadCategories(op);
        }

        public static Model.CategoryInfo? Execute(
            this PublicGetCategory.PublicGetCategoryBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PublicGetCategory op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Category)builder.WrapperObject!).PublicGetCategory(op);
        }

        public static List<Model.CategoryInfo>? Execute(
            this PublicGetChildCategories.PublicGetChildCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PublicGetChildCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Category)builder.WrapperObject!).PublicGetChildCategories(op);
        }

        public static List<Model.CategoryInfo>? Execute(
            this PublicGetDescendantCategories.PublicGetDescendantCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PublicGetDescendantCategories op = builder.Build(
                categoryPath,
                namespace_
            );

            return ((Category)builder.WrapperObject!).PublicGetDescendantCategories(op);
        }

    }
}