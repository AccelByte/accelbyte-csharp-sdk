// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class GroupGroupRoles_OpExts
    {
        public static Group.Model.ModelsGetMemberRolesListResponseV1? Execute(
            this GetMemberRolesListAdminV1.GetMemberRolesListAdminV1Builder builder,
            string namespace_
        )
        {
            GetMemberRolesListAdminV1 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).GetMemberRolesListAdminV1(op);
        }
        public static async Task<Group.Model.ModelsGetMemberRolesListResponseV1?> ExecuteAsync(
            this GetMemberRolesListAdminV1.GetMemberRolesListAdminV1Builder builder,
            string namespace_
        )
        {
            GetMemberRolesListAdminV1 op = builder.Build(
                namespace_
            );

            return await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).GetMemberRolesListAdminV1Async(op);
        }
        public static Group.Model.ModelsMemberRoleResponseV1? Execute(
            this CreateMemberRoleAdminV1.CreateMemberRoleAdminV1Builder builder,
            ModelsCreateMemberRoleRequestV1 body,
            string namespace_
        )
        {
            CreateMemberRoleAdminV1 op = builder.Build(
                body,
                namespace_
            );

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).CreateMemberRoleAdminV1(op);
        }
        public static async Task<Group.Model.ModelsMemberRoleResponseV1?> ExecuteAsync(
            this CreateMemberRoleAdminV1.CreateMemberRoleAdminV1Builder builder,
            ModelsCreateMemberRoleRequestV1 body,
            string namespace_
        )
        {
            CreateMemberRoleAdminV1 op = builder.Build(
                body,
                namespace_
            );

            return await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).CreateMemberRoleAdminV1Async(op);
        }
        public static Group.Model.ModelsMemberRoleResponseV1? Execute(
            this GetSingleMemberRoleAdminV1.GetSingleMemberRoleAdminV1Builder builder,
            string memberRoleId,
            string namespace_
        )
        {
            GetSingleMemberRoleAdminV1 op = builder.Build(
                memberRoleId,
                namespace_
            );

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).GetSingleMemberRoleAdminV1(op);
        }
        public static async Task<Group.Model.ModelsMemberRoleResponseV1?> ExecuteAsync(
            this GetSingleMemberRoleAdminV1.GetSingleMemberRoleAdminV1Builder builder,
            string memberRoleId,
            string namespace_
        )
        {
            GetSingleMemberRoleAdminV1 op = builder.Build(
                memberRoleId,
                namespace_
            );

            return await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).GetSingleMemberRoleAdminV1Async(op);
        }
        public static void Execute(
            this DeleteMemberRoleAdminV1.DeleteMemberRoleAdminV1Builder builder,
            string memberRoleId,
            string namespace_
        )
        {
            DeleteMemberRoleAdminV1 op = builder.Build(
                memberRoleId,
                namespace_
            );

            ((Group.Wrapper.GroupRoles)builder.WrapperObject!).DeleteMemberRoleAdminV1(op);
        }
        public static async Task ExecuteAsync(
            this DeleteMemberRoleAdminV1.DeleteMemberRoleAdminV1Builder builder,
            string memberRoleId,
            string namespace_
        )
        {
            DeleteMemberRoleAdminV1 op = builder.Build(
                memberRoleId,
                namespace_
            );

            await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).DeleteMemberRoleAdminV1Async(op);
        }
        public static Group.Model.ModelsMemberRoleResponseV1? Execute(
            this UpdateMemberRoleAdminV1.UpdateMemberRoleAdminV1Builder builder,
            ModelsUpdateMemberRoleRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            UpdateMemberRoleAdminV1 op = builder.Build(
                body,
                memberRoleId,
                namespace_
            );

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).UpdateMemberRoleAdminV1(op);
        }
        public static async Task<Group.Model.ModelsMemberRoleResponseV1?> ExecuteAsync(
            this UpdateMemberRoleAdminV1.UpdateMemberRoleAdminV1Builder builder,
            ModelsUpdateMemberRoleRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            UpdateMemberRoleAdminV1 op = builder.Build(
                body,
                memberRoleId,
                namespace_
            );

            return await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).UpdateMemberRoleAdminV1Async(op);
        }
        public static Group.Model.ModelsMemberRoleResponseV1? Execute(
            this UpdateMemberRolePermissionAdminV1.UpdateMemberRolePermissionAdminV1Builder builder,
            ModelsUpdateMemberRolePermissionsRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            UpdateMemberRolePermissionAdminV1 op = builder.Build(
                body,
                memberRoleId,
                namespace_
            );

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).UpdateMemberRolePermissionAdminV1(op);
        }
        public static async Task<Group.Model.ModelsMemberRoleResponseV1?> ExecuteAsync(
            this UpdateMemberRolePermissionAdminV1.UpdateMemberRolePermissionAdminV1Builder builder,
            ModelsUpdateMemberRolePermissionsRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            UpdateMemberRolePermissionAdminV1 op = builder.Build(
                body,
                memberRoleId,
                namespace_
            );

            return await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).UpdateMemberRolePermissionAdminV1Async(op);
        }
        public static Group.Model.ModelsGetMemberRolesListResponseV1? Execute(
            this GetMemberRolesListPublicV1.GetMemberRolesListPublicV1Builder builder,
            string namespace_
        )
        {
            GetMemberRolesListPublicV1 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).GetMemberRolesListPublicV1(op);
        }
        public static async Task<Group.Model.ModelsGetMemberRolesListResponseV1?> ExecuteAsync(
            this GetMemberRolesListPublicV1.GetMemberRolesListPublicV1Builder builder,
            string namespace_
        )
        {
            GetMemberRolesListPublicV1 op = builder.Build(
                namespace_
            );

            return await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).GetMemberRolesListPublicV1Async(op);
        }
        public static Group.Model.ModelsGetUserGroupInformationResponseV1? Execute(
            this UpdateMemberRolePublicV1.UpdateMemberRolePublicV1Builder builder,
            ModelsAssignRoleToMemberRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            UpdateMemberRolePublicV1 op = builder.Build(
                body,
                memberRoleId,
                namespace_
            );

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).UpdateMemberRolePublicV1(op);
        }
        public static async Task<Group.Model.ModelsGetUserGroupInformationResponseV1?> ExecuteAsync(
            this UpdateMemberRolePublicV1.UpdateMemberRolePublicV1Builder builder,
            ModelsAssignRoleToMemberRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            UpdateMemberRolePublicV1 op = builder.Build(
                body,
                memberRoleId,
                namespace_
            );

            return await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).UpdateMemberRolePublicV1Async(op);
        }
        public static void Execute(
            this DeleteMemberRolePublicV1.DeleteMemberRolePublicV1Builder builder,
            ModelsRemoveRoleFromMemberRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            DeleteMemberRolePublicV1 op = builder.Build(
                body,
                memberRoleId,
                namespace_
            );

            ((Group.Wrapper.GroupRoles)builder.WrapperObject!).DeleteMemberRolePublicV1(op);
        }
        public static async Task ExecuteAsync(
            this DeleteMemberRolePublicV1.DeleteMemberRolePublicV1Builder builder,
            ModelsRemoveRoleFromMemberRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            DeleteMemberRolePublicV1 op = builder.Build(
                body,
                memberRoleId,
                namespace_
            );

            await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).DeleteMemberRolePublicV1Async(op);
        }
        public static Group.Model.ModelsGetMemberRolesListResponseV1? Execute(
            this GetMemberRolesListPublicV2.GetMemberRolesListPublicV2Builder builder,
            string namespace_
        )
        {
            GetMemberRolesListPublicV2 op = builder.Build(
                namespace_
            );

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).GetMemberRolesListPublicV2(op);
        }
        public static async Task<Group.Model.ModelsGetMemberRolesListResponseV1?> ExecuteAsync(
            this GetMemberRolesListPublicV2.GetMemberRolesListPublicV2Builder builder,
            string namespace_
        )
        {
            GetMemberRolesListPublicV2 op = builder.Build(
                namespace_
            );

            return await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).GetMemberRolesListPublicV2Async(op);
        }
        public static Group.Model.ModelsGetUserGroupInformationResponseV1? Execute(
            this UpdateMemberRolePublicV2.UpdateMemberRolePublicV2Builder builder,
            ModelsAssignRoleToMemberRequestV1 body,
            string groupId,
            string memberRoleId,
            string namespace_
        )
        {
            UpdateMemberRolePublicV2 op = builder.Build(
                body,
                groupId,
                memberRoleId,
                namespace_
            );

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).UpdateMemberRolePublicV2(op);
        }
        public static async Task<Group.Model.ModelsGetUserGroupInformationResponseV1?> ExecuteAsync(
            this UpdateMemberRolePublicV2.UpdateMemberRolePublicV2Builder builder,
            ModelsAssignRoleToMemberRequestV1 body,
            string groupId,
            string memberRoleId,
            string namespace_
        )
        {
            UpdateMemberRolePublicV2 op = builder.Build(
                body,
                groupId,
                memberRoleId,
                namespace_
            );

            return await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).UpdateMemberRolePublicV2Async(op);
        }
        public static void Execute(
            this DeleteMemberRolePublicV2.DeleteMemberRolePublicV2Builder builder,
            ModelsRemoveRoleFromMemberRequestV1 body,
            string groupId,
            string memberRoleId,
            string namespace_
        )
        {
            DeleteMemberRolePublicV2 op = builder.Build(
                body,
                groupId,
                memberRoleId,
                namespace_
            );

            ((Group.Wrapper.GroupRoles)builder.WrapperObject!).DeleteMemberRolePublicV2(op);
        }
        public static async Task ExecuteAsync(
            this DeleteMemberRolePublicV2.DeleteMemberRolePublicV2Builder builder,
            ModelsRemoveRoleFromMemberRequestV1 body,
            string groupId,
            string memberRoleId,
            string namespace_
        )
        {
            DeleteMemberRolePublicV2 op = builder.Build(
                body,
                groupId,
                memberRoleId,
                namespace_
            );

            await ((Group.Wrapper.GroupRoles)builder.WrapperObject!).DeleteMemberRolePublicV2Async(op);
        }
    }
}