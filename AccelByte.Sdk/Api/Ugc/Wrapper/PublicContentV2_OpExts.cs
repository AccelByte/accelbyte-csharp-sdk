// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicContentV2_OpExts
    {
        public static Ugc.Model.ModelsPaginatedContentDownloadResponseV2? Execute(
            this PublicGetContentByChannelIDV2.PublicGetContentByChannelIDV2Builder builder,
            string channelId,
            string namespace_
        )
        {
            PublicGetContentByChannelIDV2 op = builder.Build(
                channelId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByChannelIDV2(op);
        }
        public static async Task<Ugc.Model.ModelsPaginatedContentDownloadResponseV2?> ExecuteAsync(
            this PublicGetContentByChannelIDV2.PublicGetContentByChannelIDV2Builder builder,
            string channelId,
            string namespace_
        )
        {
            PublicGetContentByChannelIDV2 op = builder.Build(
                channelId,
                namespace_
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByChannelIDV2Async(op);
        }
        public static Ugc.Model.ModelsPaginatedContentDownloadResponseV2? Execute(
            this PublicListContentV2.PublicListContentV2Builder builder,
            string namespace_
        )
        {
            PublicListContentV2 op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicListContentV2(op);
        }
        public static async Task<Ugc.Model.ModelsPaginatedContentDownloadResponseV2?> ExecuteAsync(
            this PublicListContentV2.PublicListContentV2Builder builder,
            string namespace_
        )
        {
            PublicListContentV2 op = builder.Build(
                namespace_
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicListContentV2Async(op);
        }
        public static List<Ugc.Model.ModelsContentDownloadResponseV2>? Execute(
            this PublicBulkGetContentByIDV2.PublicBulkGetContentByIDV2Builder builder,
            ModelsPublicGetContentBulkRequest body,
            string namespace_
        )
        {
            PublicBulkGetContentByIDV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicBulkGetContentByIDV2(op);
        }
        public static async Task<List<Ugc.Model.ModelsContentDownloadResponseV2>?> ExecuteAsync(
            this PublicBulkGetContentByIDV2.PublicBulkGetContentByIDV2Builder builder,
            ModelsPublicGetContentBulkRequest body,
            string namespace_
        )
        {
            PublicBulkGetContentByIDV2 op = builder.Build(
                body,
                namespace_
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicBulkGetContentByIDV2Async(op);
        }

        public static List<Ugc.Model.ModelsContentDownloadResponseV2<T1>>? Execute<T1>(
            this PublicBulkGetContentByIDV2.PublicBulkGetContentByIDV2Builder builder,
            ModelsPublicGetContentBulkRequest body,
            string namespace_
        )
        {
            PublicBulkGetContentByIDV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicBulkGetContentByIDV2<T1>(op);
        }
        public static async Task<List<Ugc.Model.ModelsContentDownloadResponseV2<T1>>?> ExecuteAsync<T1>(
            this PublicBulkGetContentByIDV2.PublicBulkGetContentByIDV2Builder builder,
            ModelsPublicGetContentBulkRequest body,
            string namespace_
        )
        {
            PublicBulkGetContentByIDV2 op = builder.Build(
                body,
                namespace_
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicBulkGetContentByIDV2Async<T1>(op);
        }
        public static List<Ugc.Model.ModelsContentDownloadResponseV2>? Execute(
            this PublicGetContentBulkByShareCodesV2.PublicGetContentBulkByShareCodesV2Builder builder,
            ModelsGetContentBulkByShareCodesRequest body,
            string namespace_
        )
        {
            PublicGetContentBulkByShareCodesV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentBulkByShareCodesV2(op);
        }
        public static async Task<List<Ugc.Model.ModelsContentDownloadResponseV2>?> ExecuteAsync(
            this PublicGetContentBulkByShareCodesV2.PublicGetContentBulkByShareCodesV2Builder builder,
            ModelsGetContentBulkByShareCodesRequest body,
            string namespace_
        )
        {
            PublicGetContentBulkByShareCodesV2 op = builder.Build(
                body,
                namespace_
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentBulkByShareCodesV2Async(op);
        }

        public static List<Ugc.Model.ModelsContentDownloadResponseV2<T1>>? Execute<T1>(
            this PublicGetContentBulkByShareCodesV2.PublicGetContentBulkByShareCodesV2Builder builder,
            ModelsGetContentBulkByShareCodesRequest body,
            string namespace_
        )
        {
            PublicGetContentBulkByShareCodesV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentBulkByShareCodesV2<T1>(op);
        }
        public static async Task<List<Ugc.Model.ModelsContentDownloadResponseV2<T1>>?> ExecuteAsync<T1>(
            this PublicGetContentBulkByShareCodesV2.PublicGetContentBulkByShareCodesV2Builder builder,
            ModelsGetContentBulkByShareCodesRequest body,
            string namespace_
        )
        {
            PublicGetContentBulkByShareCodesV2 op = builder.Build(
                body,
                namespace_
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentBulkByShareCodesV2Async<T1>(op);
        }
        public static Ugc.Model.ModelsContentDownloadResponseV2? Execute(
            this PublicGetContentByShareCodeV2.PublicGetContentByShareCodeV2Builder builder,
            string namespace_,
            string shareCode
        )
        {
            PublicGetContentByShareCodeV2 op = builder.Build(
                namespace_,
                shareCode
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByShareCodeV2(op);
        }
        public static async Task<Ugc.Model.ModelsContentDownloadResponseV2?> ExecuteAsync(
            this PublicGetContentByShareCodeV2.PublicGetContentByShareCodeV2Builder builder,
            string namespace_,
            string shareCode
        )
        {
            PublicGetContentByShareCodeV2 op = builder.Build(
                namespace_,
                shareCode
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByShareCodeV2Async(op);
        }

        public static Ugc.Model.ModelsContentDownloadResponseV2<T1>? Execute<T1>(
            this PublicGetContentByShareCodeV2.PublicGetContentByShareCodeV2Builder builder,
            string namespace_,
            string shareCode
        )
        {
            PublicGetContentByShareCodeV2 op = builder.Build(
                namespace_,
                shareCode
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByShareCodeV2<T1>(op);
        }
        public static async Task<Ugc.Model.ModelsContentDownloadResponseV2<T1>?> ExecuteAsync<T1>(
            this PublicGetContentByShareCodeV2.PublicGetContentByShareCodeV2Builder builder,
            string namespace_,
            string shareCode
        )
        {
            PublicGetContentByShareCodeV2 op = builder.Build(
                namespace_,
                shareCode
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByShareCodeV2Async<T1>(op);
        }
        public static Ugc.Model.ModelsContentDownloadResponseV2? Execute(
            this PublicGetContentByIDV2.PublicGetContentByIDV2Builder builder,
            string contentId,
            string namespace_
        )
        {
            PublicGetContentByIDV2 op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByIDV2(op);
        }
        public static async Task<Ugc.Model.ModelsContentDownloadResponseV2?> ExecuteAsync(
            this PublicGetContentByIDV2.PublicGetContentByIDV2Builder builder,
            string contentId,
            string namespace_
        )
        {
            PublicGetContentByIDV2 op = builder.Build(
                contentId,
                namespace_
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByIDV2Async(op);
        }

        public static Ugc.Model.ModelsContentDownloadResponseV2<T1>? Execute<T1>(
            this PublicGetContentByIDV2.PublicGetContentByIDV2Builder builder,
            string contentId,
            string namespace_
        )
        {
            PublicGetContentByIDV2 op = builder.Build(
                contentId,
                namespace_
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByIDV2<T1>(op);
        }
        public static async Task<Ugc.Model.ModelsContentDownloadResponseV2<T1>?> ExecuteAsync<T1>(
            this PublicGetContentByIDV2.PublicGetContentByIDV2Builder builder,
            string contentId,
            string namespace_
        )
        {
            PublicGetContentByIDV2 op = builder.Build(
                contentId,
                namespace_
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByIDV2Async<T1>(op);
        }
        public static Ugc.Model.ModelsCreateContentResponseV2? Execute(
            this PublicCreateContentV2.PublicCreateContentV2Builder builder,
            ModelsContentRequestV2 body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PublicCreateContentV2 op = builder.Build(
                body,
                channelId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicCreateContentV2(op);
        }
        public static async Task<Ugc.Model.ModelsCreateContentResponseV2?> ExecuteAsync(
            this PublicCreateContentV2.PublicCreateContentV2Builder builder,
            ModelsContentRequestV2 body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PublicCreateContentV2 op = builder.Build(
                body,
                channelId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicCreateContentV2Async(op);
        }

        public static Ugc.Model.ModelsCreateContentResponseV2<T1>? Execute<T1>(
            this PublicCreateContentV2.PublicCreateContentV2Builder builder,
            ModelsContentRequestV2 body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PublicCreateContentV2 op = builder.Build(
                body,
                channelId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicCreateContentV2<T1>(op);
        }
        public static async Task<Ugc.Model.ModelsCreateContentResponseV2<T1>?> ExecuteAsync<T1>(
            this PublicCreateContentV2.PublicCreateContentV2Builder builder,
            ModelsContentRequestV2 body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PublicCreateContentV2 op = builder.Build(
                body,
                channelId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicCreateContentV2Async<T1>(op);
        }
        public static Ugc.Model.ModelsCreateContentResponseV2? Execute(
            this PublicUpdateContentByShareCodeV2.PublicUpdateContentByShareCodeV2Builder builder,
            ModelsUpdateContentRequestV2 body,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PublicUpdateContentByShareCodeV2 op = builder.Build(
                body,
                channelId,
                namespace_,
                shareCode,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentByShareCodeV2(op);
        }
        public static async Task<Ugc.Model.ModelsCreateContentResponseV2?> ExecuteAsync(
            this PublicUpdateContentByShareCodeV2.PublicUpdateContentByShareCodeV2Builder builder,
            ModelsUpdateContentRequestV2 body,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PublicUpdateContentByShareCodeV2 op = builder.Build(
                body,
                channelId,
                namespace_,
                shareCode,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentByShareCodeV2Async(op);
        }

        public static Ugc.Model.ModelsCreateContentResponseV2<T1>? Execute<T1>(
            this PublicUpdateContentByShareCodeV2.PublicUpdateContentByShareCodeV2Builder builder,
            ModelsUpdateContentRequestV2 body,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PublicUpdateContentByShareCodeV2 op = builder.Build(
                body,
                channelId,
                namespace_,
                shareCode,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentByShareCodeV2<T1>(op);
        }
        public static async Task<Ugc.Model.ModelsCreateContentResponseV2<T1>?> ExecuteAsync<T1>(
            this PublicUpdateContentByShareCodeV2.PublicUpdateContentByShareCodeV2Builder builder,
            ModelsUpdateContentRequestV2 body,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PublicUpdateContentByShareCodeV2 op = builder.Build(
                body,
                channelId,
                namespace_,
                shareCode,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentByShareCodeV2Async<T1>(op);
        }
        public static void Execute(
            this PublicDeleteContentByShareCodeV2.PublicDeleteContentByShareCodeV2Builder builder,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PublicDeleteContentByShareCodeV2 op = builder.Build(
                channelId,
                namespace_,
                shareCode,
                userId
            );

            ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicDeleteContentByShareCodeV2(op);
        }
        public static async Task ExecuteAsync(
            this PublicDeleteContentByShareCodeV2.PublicDeleteContentByShareCodeV2Builder builder,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PublicDeleteContentByShareCodeV2 op = builder.Build(
                channelId,
                namespace_,
                shareCode,
                userId
            );

            await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicDeleteContentByShareCodeV2Async(op);
        }
        public static void Execute(
            this PublicDeleteContentV2.PublicDeleteContentV2Builder builder,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicDeleteContentV2 op = builder.Build(
                channelId,
                contentId,
                namespace_,
                userId
            );

            ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicDeleteContentV2(op);
        }
        public static async Task ExecuteAsync(
            this PublicDeleteContentV2.PublicDeleteContentV2Builder builder,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicDeleteContentV2 op = builder.Build(
                channelId,
                contentId,
                namespace_,
                userId
            );

            await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicDeleteContentV2Async(op);
        }
        public static Ugc.Model.ModelsUpdateContentResponseV2? Execute(
            this PublicUpdateContentV2.PublicUpdateContentV2Builder builder,
            ModelsUpdateContentRequestV2 body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicUpdateContentV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentV2(op);
        }
        public static async Task<Ugc.Model.ModelsUpdateContentResponseV2?> ExecuteAsync(
            this PublicUpdateContentV2.PublicUpdateContentV2Builder builder,
            ModelsUpdateContentRequestV2 body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicUpdateContentV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentV2Async(op);
        }

        public static Ugc.Model.ModelsUpdateContentResponseV2<T1>? Execute<T1>(
            this PublicUpdateContentV2.PublicUpdateContentV2Builder builder,
            ModelsUpdateContentRequestV2 body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicUpdateContentV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentV2<T1>(op);
        }
        public static async Task<Ugc.Model.ModelsUpdateContentResponseV2<T1>?> ExecuteAsync<T1>(
            this PublicUpdateContentV2.PublicUpdateContentV2Builder builder,
            ModelsUpdateContentRequestV2 body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicUpdateContentV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentV2Async<T1>(op);
        }
        public static Ugc.Model.ModelsUpdateContentResponseV2? Execute(
            this PublicUpdateContentFileLocation.PublicUpdateContentFileLocationBuilder builder,
            ModelsUpdateFileLocationRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicUpdateContentFileLocation op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentFileLocation(op);
        }
        public static async Task<Ugc.Model.ModelsUpdateContentResponseV2?> ExecuteAsync(
            this PublicUpdateContentFileLocation.PublicUpdateContentFileLocationBuilder builder,
            ModelsUpdateFileLocationRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicUpdateContentFileLocation op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentFileLocationAsync(op);
        }

        public static Ugc.Model.ModelsUpdateContentResponseV2<T1>? Execute<T1>(
            this PublicUpdateContentFileLocation.PublicUpdateContentFileLocationBuilder builder,
            ModelsUpdateFileLocationRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicUpdateContentFileLocation op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentFileLocation<T1>(op);
        }
        public static async Task<Ugc.Model.ModelsUpdateContentResponseV2<T1>?> ExecuteAsync<T1>(
            this PublicUpdateContentFileLocation.PublicUpdateContentFileLocationBuilder builder,
            ModelsUpdateFileLocationRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicUpdateContentFileLocation op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicUpdateContentFileLocationAsync<T1>(op);
        }
        public static Ugc.Model.ModelsCreateContentResponseV2? Execute(
            this UpdateContentShareCodeV2.UpdateContentShareCodeV2Builder builder,
            ModelsUpdateContentShareCodeRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateContentShareCodeV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).UpdateContentShareCodeV2(op);
        }
        public static async Task<Ugc.Model.ModelsCreateContentResponseV2?> ExecuteAsync(
            this UpdateContentShareCodeV2.UpdateContentShareCodeV2Builder builder,
            ModelsUpdateContentShareCodeRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateContentShareCodeV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).UpdateContentShareCodeV2Async(op);
        }

        public static Ugc.Model.ModelsCreateContentResponseV2<T1>? Execute<T1>(
            this UpdateContentShareCodeV2.UpdateContentShareCodeV2Builder builder,
            ModelsUpdateContentShareCodeRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateContentShareCodeV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).UpdateContentShareCodeV2<T1>(op);
        }
        public static async Task<Ugc.Model.ModelsCreateContentResponseV2<T1>?> ExecuteAsync<T1>(
            this UpdateContentShareCodeV2.UpdateContentShareCodeV2Builder builder,
            ModelsUpdateContentShareCodeRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateContentShareCodeV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).UpdateContentShareCodeV2Async<T1>(op);
        }
        public static Ugc.Model.ModelsGenerateContentUploadURLResponse? Execute(
            this PublicGenerateContentUploadURLV2.PublicGenerateContentUploadURLV2Builder builder,
            ModelsGenerateContentUploadURLRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicGenerateContentUploadURLV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGenerateContentUploadURLV2(op);
        }
        public static async Task<Ugc.Model.ModelsGenerateContentUploadURLResponse?> ExecuteAsync(
            this PublicGenerateContentUploadURLV2.PublicGenerateContentUploadURLV2Builder builder,
            ModelsGenerateContentUploadURLRequest body,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PublicGenerateContentUploadURLV2 op = builder.Build(
                body,
                channelId,
                contentId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGenerateContentUploadURLV2Async(op);
        }
        public static Ugc.Model.ModelsPaginatedContentDownloadResponseV2? Execute(
            this PublicGetContentByUserIDV2.PublicGetContentByUserIDV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetContentByUserIDV2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByUserIDV2(op);
        }
        public static async Task<Ugc.Model.ModelsPaginatedContentDownloadResponseV2?> ExecuteAsync(
            this PublicGetContentByUserIDV2.PublicGetContentByUserIDV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetContentByUserIDV2 op = builder.Build(
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).PublicGetContentByUserIDV2Async(op);
        }
        public static Ugc.Model.ModelsUpdateScreenshotResponse? Execute(
            this UpdateScreenshotsV2.UpdateScreenshotsV2Builder builder,
            ModelsUpdateScreenshotRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateScreenshotsV2 op = builder.Build(
                body,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).UpdateScreenshotsV2(op);
        }
        public static async Task<Ugc.Model.ModelsUpdateScreenshotResponse?> ExecuteAsync(
            this UpdateScreenshotsV2.UpdateScreenshotsV2Builder builder,
            ModelsUpdateScreenshotRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UpdateScreenshotsV2 op = builder.Build(
                body,
                contentId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).UpdateScreenshotsV2Async(op);
        }
        public static Ugc.Model.ModelsCreateScreenshotResponse? Execute(
            this UploadContentScreenshotV2.UploadContentScreenshotV2Builder builder,
            ModelsCreateScreenshotRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UploadContentScreenshotV2 op = builder.Build(
                body,
                contentId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).UploadContentScreenshotV2(op);
        }
        public static async Task<Ugc.Model.ModelsCreateScreenshotResponse?> ExecuteAsync(
            this UploadContentScreenshotV2.UploadContentScreenshotV2Builder builder,
            ModelsCreateScreenshotRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            UploadContentScreenshotV2 op = builder.Build(
                body,
                contentId,
                namespace_,
                userId
            );

            return await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).UploadContentScreenshotV2Async(op);
        }
        public static void Execute(
            this DeleteContentScreenshotV2.DeleteContentScreenshotV2Builder builder,
            string contentId,
            string namespace_,
            string screenshotId,
            string userId
        )
        {
            DeleteContentScreenshotV2 op = builder.Build(
                contentId,
                namespace_,
                screenshotId,
                userId
            );

            ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).DeleteContentScreenshotV2(op);
        }
        public static async Task ExecuteAsync(
            this DeleteContentScreenshotV2.DeleteContentScreenshotV2Builder builder,
            string contentId,
            string namespace_,
            string screenshotId,
            string userId
        )
        {
            DeleteContentScreenshotV2 op = builder.Build(
                contentId,
                namespace_,
                screenshotId,
                userId
            );

            await ((Ugc.Wrapper.PublicContentV2)builder.WrapperObject!).DeleteContentScreenshotV2Async(op);
        }
    }
}