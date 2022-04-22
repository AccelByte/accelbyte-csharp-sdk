// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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

        public static Group.Model.ModelsCreateMemberRoleResponseV1? Execute(
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

        public static Group.Model.ModelsGetMemberRoleResponseV1? Execute(
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

        public static Group.Model.ModelsUpdateMemberRoleResponseV1? Execute(
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

        public static Group.Model.ModelsUpdateMemberRoleResponseV1? Execute(
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

        public static Group.Model.ModelsUpdateMemberRoleResponseV1? Execute(
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

            return ((Group.Wrapper.GroupRoles)builder.WrapperObject!).DeleteMemberRolePublicV1(op);
        }

    }
}