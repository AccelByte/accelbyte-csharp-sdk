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
    public static class PlatformSection_OpExts
    {
        public static Platform.Model.SectionPagingSlicedResult? Execute(
            this QuerySections.QuerySectionsBuilder builder,
            string namespace_
        )
        {
            QuerySections op = builder.Build(
                namespace_
            );

            return ((Platform.Wrapper.Section)builder.WrapperObject!).QuerySections(op);
        }
        public static Platform.Model.FullSectionInfo? Execute(
            this CreateSection.CreateSectionBuilder builder,
            string namespace_,
            string storeId
        )
        {
            CreateSection op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Section)builder.WrapperObject!).CreateSection(op);
        }

        public static Platform.Model.FullSectionInfo<T1>? Execute<T1>(
            this CreateSection.CreateSectionBuilder builder,
            string namespace_,
            string storeId
        )
        {
            CreateSection op = builder.Build(
                namespace_,
                storeId
            );

            return ((Platform.Wrapper.Section)builder.WrapperObject!).CreateSection<T1>(op);
        }
        public static void Execute(
            this PurgeExpiredSection.PurgeExpiredSectionBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PurgeExpiredSection op = builder.Build(
                namespace_,
                storeId
            );

            ((Platform.Wrapper.Section)builder.WrapperObject!).PurgeExpiredSection(op);
        }
        public static Platform.Model.FullSectionInfo? Execute(
            this GetSection.GetSectionBuilder builder,
            string namespace_,
            string sectionId
        )
        {
            GetSection op = builder.Build(
                namespace_,
                sectionId
            );

            return ((Platform.Wrapper.Section)builder.WrapperObject!).GetSection(op);
        }

        public static Platform.Model.FullSectionInfo<T1>? Execute<T1>(
            this GetSection.GetSectionBuilder builder,
            string namespace_,
            string sectionId
        )
        {
            GetSection op = builder.Build(
                namespace_,
                sectionId
            );

            return ((Platform.Wrapper.Section)builder.WrapperObject!).GetSection<T1>(op);
        }
        public static Platform.Model.FullSectionInfo? Execute(
            this UpdateSection.UpdateSectionBuilder builder,
            string namespace_,
            string sectionId,
            string storeId
        )
        {
            UpdateSection op = builder.Build(
                namespace_,
                sectionId,
                storeId
            );

            return ((Platform.Wrapper.Section)builder.WrapperObject!).UpdateSection(op);
        }

        public static Platform.Model.FullSectionInfo<T1>? Execute<T1>(
            this UpdateSection.UpdateSectionBuilder builder,
            string namespace_,
            string sectionId,
            string storeId
        )
        {
            UpdateSection op = builder.Build(
                namespace_,
                sectionId,
                storeId
            );

            return ((Platform.Wrapper.Section)builder.WrapperObject!).UpdateSection<T1>(op);
        }
        public static void Execute(
            this DeleteSection.DeleteSectionBuilder builder,
            string namespace_,
            string sectionId,
            string storeId
        )
        {
            DeleteSection op = builder.Build(
                namespace_,
                sectionId,
                storeId
            );

            ((Platform.Wrapper.Section)builder.WrapperObject!).DeleteSection(op);
        }
        public static List<Platform.Model.SectionInfo>? Execute(
            this PublicListActiveSections.PublicListActiveSectionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicListActiveSections op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Section)builder.WrapperObject!).PublicListActiveSections(op);
        }

        public static List<Platform.Model.SectionInfo<T1, T2>>? Execute<T1, T2>(
            this PublicListActiveSections.PublicListActiveSectionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicListActiveSections op = builder.Build(
                namespace_,
                userId
            );

            return ((Platform.Wrapper.Section)builder.WrapperObject!).PublicListActiveSections<T1, T2>(op);
        }
    }
}