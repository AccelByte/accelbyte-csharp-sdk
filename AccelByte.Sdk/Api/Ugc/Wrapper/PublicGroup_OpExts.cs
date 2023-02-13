// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicGroup_OpExts
    {
        public static Ugc.Model.ModelsPaginatedGroupResponse? Execute(
            this GetGroups.GetGroupsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetGroups op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicGroup)builder.WrapperObject!).GetGroups(op);
        }
        public static Ugc.Model.ModelsCreateGroupResponse? Execute(
            this CreateGroup.CreateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string namespace_,
            string userId
        )
        {
            CreateGroup op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicGroup)builder.WrapperObject!).CreateGroup(op);
        }
        public static Ugc.Model.ModelsCreateGroupResponse? Execute(
            this GetGroup.GetGroupBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            GetGroup op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicGroup)builder.WrapperObject!).GetGroup(op);
        }
        public static Ugc.Model.ModelsCreateGroupResponse? Execute(
            this UpdateGroup.UpdateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string groupId,
            string namespace_,
            string userId
        )
        {
            UpdateGroup op = builder.Build(
                body,
                groupId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicGroup)builder.WrapperObject!).UpdateGroup(op);
        }
        public static void Execute(
            this DeleteGroup.DeleteGroupBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            DeleteGroup op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            ((Ugc.Wrapper.PublicGroup)builder.WrapperObject!).DeleteGroup(op);
        }
        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this GetGroupContent.GetGroupContentBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            GetGroupContent op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicGroup)builder.WrapperObject!).GetGroupContent(op);
        }
    }
}