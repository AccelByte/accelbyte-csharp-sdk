// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;
using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class AchievementTags_OpExts
    {
        public static Achievement.Model.ModelsPaginatedTagResponse? Execute(
            this AdminListTags.AdminListTagsBuilder builder,
            string namespace_
        )
        {
            AdminListTags op = builder.Build(
                namespace_
            );

            return ((Achievement.Wrapper.Tags)builder.WrapperObject!).AdminListTags(op);
        }
        public static async Task<Achievement.Model.ModelsPaginatedTagResponse?> ExecuteAsync(
            this AdminListTags.AdminListTagsBuilder builder,
            string namespace_
        )
        {
            AdminListTags op = builder.Build(
                namespace_
            );

            return await ((Achievement.Wrapper.Tags)builder.WrapperObject!).AdminListTagsAsync(op);
        }
        public static Achievement.Model.ModelsPaginatedTagResponse? Execute(
            this PublicListTags.PublicListTagsBuilder builder,
            string namespace_
        )
        {
            PublicListTags op = builder.Build(
                namespace_
            );

            return ((Achievement.Wrapper.Tags)builder.WrapperObject!).PublicListTags(op);
        }
        public static async Task<Achievement.Model.ModelsPaginatedTagResponse?> ExecuteAsync(
            this PublicListTags.PublicListTagsBuilder builder,
            string namespace_
        )
        {
            PublicListTags op = builder.Build(
                namespace_
            );

            return await ((Achievement.Wrapper.Tags)builder.WrapperObject!).PublicListTagsAsync(op);
        }
    }
}