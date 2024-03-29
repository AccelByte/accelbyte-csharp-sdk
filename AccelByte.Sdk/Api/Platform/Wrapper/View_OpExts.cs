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
    public static class PlatformView_OpExts
    {
        public static List<Platform.Model.ListViewInfo>? Execute(
            this ListViews.ListViewsBuilder builder,
            string namespace_
        )
        {
            ListViews op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.View)builder.WrapperObject!).ListViews(op);
        }
        public static Platform.Model.FullViewInfo? Execute(
            this CreateView.CreateViewBuilder builder,
            string namespace_,
            string storeId
        )
        {
            CreateView op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.View)builder.WrapperObject!).CreateView(op);
        }
        public static Platform.Model.FullViewInfo? Execute(
            this GetView.GetViewBuilder builder,
            string namespace_,
            string viewId
        )
        {
            GetView op = builder.Build(
                namespace_,
                viewId
            );

            return ((Platform.Wrapper.View)builder.WrapperObject!).GetView(op);
        }
        public static Platform.Model.FullViewInfo? Execute(
            this UpdateView.UpdateViewBuilder builder,
            string namespace_,
            string viewId,
            string storeId
        )
        {
            UpdateView op = builder.Build(
                namespace_,
                viewId,
                storeId
            );

            return ((Platform.Wrapper.View)builder.WrapperObject!).UpdateView(op);
        }
        public static void Execute(
            this DeleteView.DeleteViewBuilder builder,
            string namespace_,
            string viewId,
            string storeId
        )
        {
            DeleteView op = builder.Build(
                namespace_,
                viewId,
                storeId
            );

            ((Platform.Wrapper.View)builder.WrapperObject!).DeleteView(op);
        }
        public static List<Platform.Model.ViewInfo>? Execute(
            this PublicListViews.PublicListViewsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicListViews op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.View)builder.WrapperObject!).PublicListViews(op);
        }

        public static List<Platform.Model.ViewInfo<T1>>? Execute<T1>(
            this PublicListViews.PublicListViewsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicListViews op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.View)builder.WrapperObject!).PublicListViews<T1>(op);
        }
    }
}