// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcAdminGroup_OpExts
    {
        public static Ugc.Model.ModelsPaginatedGroupResponse? Execute(
            this SingleAdminGetAllGroups.SingleAdminGetAllGroupsBuilder builder,
            string namespace_
        )
        {
            SingleAdminGetAllGroups op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).SingleAdminGetAllGroups(op);
        }

        public static Ugc.Model.ModelsCreateGroupResponse? Execute(
            this AdminCreateGroup.AdminCreateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string namespace_
        )
        {
            AdminCreateGroup op = builder.Build(
                body,
                namespace_
            );

            return ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).AdminCreateGroup(op);
        }

        public static Ugc.Model.ModelsCreateGroupResponse? Execute(
            this SingleAdminGetGroup.SingleAdminGetGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            SingleAdminGetGroup op = builder.Build(
                groupId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).SingleAdminGetGroup(op);
        }

        public static Ugc.Model.ModelsCreateGroupResponse? Execute(
            this SingleAdminUpdateGroup.SingleAdminUpdateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string groupId,
            string namespace_
        )
        {
            SingleAdminUpdateGroup op = builder.Build(
                body,
                groupId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).SingleAdminUpdateGroup(op);
        }

        public static void Execute(
            this SingleAdminDeleteGroup.SingleAdminDeleteGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            SingleAdminDeleteGroup op = builder.Build(
                groupId,
                namespace_
            );

            ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).SingleAdminDeleteGroup(op);
        }

        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this SingleAdminGetGroupContents.SingleAdminGetGroupContentsBuilder builder,
            string groupId,
            string namespace_
        )
        {
            SingleAdminGetGroupContents op = builder.Build(
                groupId,
                namespace_
            );

            return ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).SingleAdminGetGroupContents(op);
        }

        public static Ugc.Model.ModelsPaginatedGroupResponse? Execute(
            this AdminGetAllGroups.AdminGetAllGroupsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetAllGroups op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).AdminGetAllGroups(op);
        }

        public static Ugc.Model.ModelsCreateGroupResponse? Execute(
            this AdminGetGroup.AdminGetGroupBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            AdminGetGroup op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).AdminGetGroup(op);
        }

        public static Ugc.Model.ModelsCreateGroupResponse? Execute(
            this AdminUpdateGroup.AdminUpdateGroupBuilder builder,
            ModelsCreateGroupRequest body,
            string groupId,
            string namespace_,
            string userId
        )
        {
            AdminUpdateGroup op = builder.Build(
                body,
                groupId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).AdminUpdateGroup(op);
        }

        public static void Execute(
            this AdminDeleteGroup.AdminDeleteGroupBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            AdminDeleteGroup op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).AdminDeleteGroup(op);
        }

        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this AdminGetGroupContents.AdminGetGroupContentsBuilder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            AdminGetGroupContents op = builder.Build(
                groupId,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.AdminGroup)builder.WrapperObject!).AdminGetGroupContents(op);
        }

    }
}