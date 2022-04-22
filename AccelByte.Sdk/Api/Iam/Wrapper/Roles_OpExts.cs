// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamRoles_OpExts
    {
        public static List<Iam.Model.ModelRoleResponseWithManagers>? Execute(
            this GetRoles.GetRolesBuilder builder
        )
        {
            GetRoles op = builder.Build(
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).GetRoles(op);
        }

        public static Iam.Model.AccountcommonRole? Execute(
            this CreateRole.CreateRoleBuilder builder,
            ModelRoleCreateRequest body
        )
        {
            CreateRole op = builder.Build(
                body
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).CreateRole(op);
        }

        public static Iam.Model.ModelRoleResponse? Execute(
            this GetRole.GetRoleBuilder builder,
            string roleId
        )
        {
            GetRole op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).GetRole(op);
        }

        public static Iam.Model.ModelRoleResponse? Execute(
            this UpdateRole.UpdateRoleBuilder builder,
            ModelRoleUpdateRequest body,
            string roleId
        )
        {
            UpdateRole op = builder.Build(
                body,
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).UpdateRole(op);
        }

        public static void Execute(
            this DeleteRole.DeleteRoleBuilder builder,
            string roleId
        )
        {
            DeleteRole op = builder.Build(
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).DeleteRole(op);
        }

        public static Iam.Model.ModelRoleAdminStatusResponse? Execute(
            this GetRoleAdminStatus.GetRoleAdminStatusBuilder builder,
            string roleId
        )
        {
            GetRoleAdminStatus op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).GetRoleAdminStatus(op);
        }

        public static void Execute(
            this SetRoleAsAdmin.SetRoleAsAdminBuilder builder,
            string roleId
        )
        {
            SetRoleAsAdmin op = builder.Build(
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).SetRoleAsAdmin(op);
        }

        public static void Execute(
            this RemoveRoleAdmin.RemoveRoleAdminBuilder builder,
            string roleId
        )
        {
            RemoveRoleAdmin op = builder.Build(
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).RemoveRoleAdmin(op);
        }

        public static Iam.Model.ModelRoleManagersResponse? Execute(
            this GetRoleManagers.GetRoleManagersBuilder builder,
            string roleId
        )
        {
            GetRoleManagers op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).GetRoleManagers(op);
        }

        public static void Execute(
            this AddRoleManagers.AddRoleManagersBuilder builder,
            ModelRoleManagersRequest body,
            string roleId
        )
        {
            AddRoleManagers op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AddRoleManagers(op);
        }

        public static void Execute(
            this RemoveRoleManagers.RemoveRoleManagersBuilder builder,
            ModelRoleManagersRequest body,
            string roleId
        )
        {
            RemoveRoleManagers op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).RemoveRoleManagers(op);
        }

        public static Iam.Model.ModelRoleMembersResponse? Execute(
            this GetRoleMembers.GetRoleMembersBuilder builder,
            string roleId
        )
        {
            GetRoleMembers op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).GetRoleMembers(op);
        }

        public static void Execute(
            this AddRoleMembers.AddRoleMembersBuilder builder,
            ModelRoleMembersRequest body,
            string roleId
        )
        {
            AddRoleMembers op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AddRoleMembers(op);
        }

        public static void Execute(
            this RemoveRoleMembers.RemoveRoleMembersBuilder builder,
            ModelRoleMembersRequest body,
            string roleId
        )
        {
            RemoveRoleMembers op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).RemoveRoleMembers(op);
        }

        public static void Execute(
            this UpdateRolePermissions.UpdateRolePermissionsBuilder builder,
            AccountcommonPermissions body,
            string roleId
        )
        {
            UpdateRolePermissions op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).UpdateRolePermissions(op);
        }

        public static void Execute(
            this AddRolePermission.AddRolePermissionBuilder builder,
            ModelUpdatePermissionScheduleRequest body,
            long action,
            string resource,
            string roleId
        )
        {
            AddRolePermission op = builder.Build(
                body,
                action,
                resource,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AddRolePermission(op);
        }

        public static void Execute(
            this DeleteRolePermission.DeleteRolePermissionBuilder builder,
            long action,
            string resource,
            string roleId
        )
        {
            DeleteRolePermission op = builder.Build(
                action,
                resource,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).DeleteRolePermission(op);
        }

        public static Iam.Model.ModelRoleResponseWithManagersAndPaginationV3? Execute(
            this AdminGetRolesV3.AdminGetRolesV3Builder builder
        )
        {
            AdminGetRolesV3 op = builder.Build(
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminGetRolesV3(op);
        }

        public static Iam.Model.AccountcommonRoleV3? Execute(
            this AdminCreateRoleV3.AdminCreateRoleV3Builder builder,
            ModelRoleCreateV3Request body
        )
        {
            AdminCreateRoleV3 op = builder.Build(
                body
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminCreateRoleV3(op);
        }

        public static Iam.Model.ModelRoleResponseV3? Execute(
            this AdminGetRoleV3.AdminGetRoleV3Builder builder,
            string roleId
        )
        {
            AdminGetRoleV3 op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminGetRoleV3(op);
        }

        public static void Execute(
            this AdminDeleteRoleV3.AdminDeleteRoleV3Builder builder,
            string roleId
        )
        {
            AdminDeleteRoleV3 op = builder.Build(
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminDeleteRoleV3(op);
        }

        public static Iam.Model.ModelRoleResponseV3? Execute(
            this AdminUpdateRoleV3.AdminUpdateRoleV3Builder builder,
            ModelRoleUpdateRequestV3 body,
            string roleId
        )
        {
            AdminUpdateRoleV3 op = builder.Build(
                body,
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminUpdateRoleV3(op);
        }

        public static Iam.Model.ModelRoleAdminStatusResponseV3? Execute(
            this AdminGetRoleAdminStatusV3.AdminGetRoleAdminStatusV3Builder builder,
            string roleId
        )
        {
            AdminGetRoleAdminStatusV3 op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminGetRoleAdminStatusV3(op);
        }

        public static void Execute(
            this AdminUpdateAdminRoleStatusV3.AdminUpdateAdminRoleStatusV3Builder builder,
            string roleId
        )
        {
            AdminUpdateAdminRoleStatusV3 op = builder.Build(
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminUpdateAdminRoleStatusV3(op);
        }

        public static void Execute(
            this AdminRemoveRoleAdminV3.AdminRemoveRoleAdminV3Builder builder,
            string roleId
        )
        {
            AdminRemoveRoleAdminV3 op = builder.Build(
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminRemoveRoleAdminV3(op);
        }

        public static Iam.Model.ModelRoleManagersResponsesV3? Execute(
            this AdminGetRoleManagersV3.AdminGetRoleManagersV3Builder builder,
            string roleId
        )
        {
            AdminGetRoleManagersV3 op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminGetRoleManagersV3(op);
        }

        public static void Execute(
            this AdminAddRoleManagersV3.AdminAddRoleManagersV3Builder builder,
            ModelRoleManagersRequestV3 body,
            string roleId
        )
        {
            AdminAddRoleManagersV3 op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminAddRoleManagersV3(op);
        }

        public static void Execute(
            this AdminRemoveRoleManagersV3.AdminRemoveRoleManagersV3Builder builder,
            ModelRoleManagersRequestV3 body,
            string roleId
        )
        {
            AdminRemoveRoleManagersV3 op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminRemoveRoleManagersV3(op);
        }

        public static Iam.Model.ModelRoleMembersResponseV3? Execute(
            this AdminGetRoleMembersV3.AdminGetRoleMembersV3Builder builder,
            string roleId
        )
        {
            AdminGetRoleMembersV3 op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminGetRoleMembersV3(op);
        }

        public static void Execute(
            this AdminAddRoleMembersV3.AdminAddRoleMembersV3Builder builder,
            ModelRoleMembersRequestV3 body,
            string roleId
        )
        {
            AdminAddRoleMembersV3 op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminAddRoleMembersV3(op);
        }

        public static void Execute(
            this AdminRemoveRoleMembersV3.AdminRemoveRoleMembersV3Builder builder,
            ModelRoleMembersRequestV3 body,
            string roleId
        )
        {
            AdminRemoveRoleMembersV3 op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminRemoveRoleMembersV3(op);
        }

        public static void Execute(
            this AdminUpdateRolePermissionsV3.AdminUpdateRolePermissionsV3Builder builder,
            AccountcommonPermissionsV3 body,
            string roleId
        )
        {
            AdminUpdateRolePermissionsV3 op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminUpdateRolePermissionsV3(op);
        }

        public static void Execute(
            this AdminAddRolePermissionsV3.AdminAddRolePermissionsV3Builder builder,
            AccountcommonPermissionsV3 body,
            string roleId
        )
        {
            AdminAddRolePermissionsV3 op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminAddRolePermissionsV3(op);
        }

        public static void Execute(
            this AdminDeleteRolePermissionsV3.AdminDeleteRolePermissionsV3Builder builder,
            List<string> body,
            string roleId
        )
        {
            AdminDeleteRolePermissionsV3 op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminDeleteRolePermissionsV3(op);
        }

        public static void Execute(
            this AdminDeleteRolePermissionV3.AdminDeleteRolePermissionV3Builder builder,
            long action,
            string resource,
            string roleId
        )
        {
            AdminDeleteRolePermissionV3 op = builder.Build(
                action,
                resource,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminDeleteRolePermissionV3(op);
        }

        public static Iam.Model.ModelRoleNamesResponseV3? Execute(
            this PublicGetRolesV3.PublicGetRolesV3Builder builder
        )
        {
            PublicGetRolesV3 op = builder.Build(
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).PublicGetRolesV3(op);
        }

        public static Iam.Model.ModelRoleResponse? Execute(
            this PublicGetRoleV3.PublicGetRoleV3Builder builder,
            string roleId
        )
        {
            PublicGetRoleV3 op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).PublicGetRoleV3(op);
        }

        public static Iam.Model.ModelListRoleV4Response? Execute(
            this AdminGetRolesV4.AdminGetRolesV4Builder builder
        )
        {
            AdminGetRolesV4 op = builder.Build(
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminGetRolesV4(op);
        }

        public static Iam.Model.ModelRoleV4Response? Execute(
            this AdminCreateRoleV4.AdminCreateRoleV4Builder builder,
            ModelRoleV4Request body
        )
        {
            AdminCreateRoleV4 op = builder.Build(
                body
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminCreateRoleV4(op);
        }

        public static Iam.Model.ModelRoleV4Response? Execute(
            this AdminGetRoleV4.AdminGetRoleV4Builder builder,
            string roleId
        )
        {
            AdminGetRoleV4 op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminGetRoleV4(op);
        }

        public static void Execute(
            this AdminDeleteRoleV4.AdminDeleteRoleV4Builder builder,
            string roleId
        )
        {
            AdminDeleteRoleV4 op = builder.Build(
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminDeleteRoleV4(op);
        }

        public static Iam.Model.ModelRoleV4Response? Execute(
            this AdminUpdateRoleV4.AdminUpdateRoleV4Builder builder,
            ModelRoleV4Request body,
            string roleId
        )
        {
            AdminUpdateRoleV4 op = builder.Build(
                body,
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminUpdateRoleV4(op);
        }

        public static Iam.Model.ModelRoleV4Response? Execute(
            this AdminUpdateRolePermissionsV4.AdminUpdateRolePermissionsV4Builder builder,
            AccountcommonPermissionsV3 body,
            string roleId
        )
        {
            AdminUpdateRolePermissionsV4 op = builder.Build(
                body,
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminUpdateRolePermissionsV4(op);
        }

        public static Iam.Model.ModelRoleV4Response? Execute(
            this AdminAddRolePermissionsV4.AdminAddRolePermissionsV4Builder builder,
            AccountcommonPermissionsV3 body,
            string roleId
        )
        {
            AdminAddRolePermissionsV4 op = builder.Build(
                body,
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminAddRolePermissionsV4(op);
        }

        public static void Execute(
            this AdminDeleteRolePermissionsV4.AdminDeleteRolePermissionsV4Builder builder,
            List<string> body,
            string roleId
        )
        {
            AdminDeleteRolePermissionsV4 op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminDeleteRolePermissionsV4(op);
        }

        public static Iam.Model.ModelListAssignedUsersV4Response? Execute(
            this AdminListAssignedUsersV4.AdminListAssignedUsersV4Builder builder,
            string roleId
        )
        {
            AdminListAssignedUsersV4 op = builder.Build(
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminListAssignedUsersV4(op);
        }

        public static Iam.Model.ModelAssignedUserV4Response? Execute(
            this AdminAssignUserToRoleV4.AdminAssignUserToRoleV4Builder builder,
            ModelAssignUserV4Request body,
            string roleId
        )
        {
            AdminAssignUserToRoleV4 op = builder.Build(
                body,
                roleId
            );

            return ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminAssignUserToRoleV4(op);
        }

        public static void Execute(
            this AdminRevokeUserFromRoleV4.AdminRevokeUserFromRoleV4Builder builder,
            ModelRevokeUserV4Request body,
            string roleId
        )
        {
            AdminRevokeUserFromRoleV4 op = builder.Build(
                body,
                roleId
            );

            ((Iam.Wrapper.Roles)builder.WrapperObject!).AdminRevokeUserFromRoleV4(op);
        }

    }
}