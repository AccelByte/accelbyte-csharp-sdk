// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class Roles
    {
        private readonly AccelByteSDK _sdk;

        public Roles(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetRoles.GetRolesBuilder GetRolesOp
        {
            get { return Operation.GetRoles.Builder.SetWrapperObject(this); }
        }
        public CreateRole.CreateRoleBuilder CreateRoleOp
        {
            get { return Operation.CreateRole.Builder.SetWrapperObject(this); }
        }
        public GetRole.GetRoleBuilder GetRoleOp
        {
            get { return Operation.GetRole.Builder.SetWrapperObject(this); }
        }
        public UpdateRole.UpdateRoleBuilder UpdateRoleOp
        {
            get { return Operation.UpdateRole.Builder.SetWrapperObject(this); }
        }
        public DeleteRole.DeleteRoleBuilder DeleteRoleOp
        {
            get { return Operation.DeleteRole.Builder.SetWrapperObject(this); }
        }
        public GetRoleAdminStatus.GetRoleAdminStatusBuilder GetRoleAdminStatusOp
        {
            get { return Operation.GetRoleAdminStatus.Builder.SetWrapperObject(this); }
        }
        public SetRoleAsAdmin.SetRoleAsAdminBuilder SetRoleAsAdminOp
        {
            get { return Operation.SetRoleAsAdmin.Builder.SetWrapperObject(this); }
        }
        public RemoveRoleAdmin.RemoveRoleAdminBuilder RemoveRoleAdminOp
        {
            get { return Operation.RemoveRoleAdmin.Builder.SetWrapperObject(this); }
        }
        public GetRoleManagers.GetRoleManagersBuilder GetRoleManagersOp
        {
            get { return Operation.GetRoleManagers.Builder.SetWrapperObject(this); }
        }
        public AddRoleManagers.AddRoleManagersBuilder AddRoleManagersOp
        {
            get { return Operation.AddRoleManagers.Builder.SetWrapperObject(this); }
        }
        public RemoveRoleManagers.RemoveRoleManagersBuilder RemoveRoleManagersOp
        {
            get { return Operation.RemoveRoleManagers.Builder.SetWrapperObject(this); }
        }
        public GetRoleMembers.GetRoleMembersBuilder GetRoleMembersOp
        {
            get { return Operation.GetRoleMembers.Builder.SetWrapperObject(this); }
        }
        public AddRoleMembers.AddRoleMembersBuilder AddRoleMembersOp
        {
            get { return Operation.AddRoleMembers.Builder.SetWrapperObject(this); }
        }
        public RemoveRoleMembers.RemoveRoleMembersBuilder RemoveRoleMembersOp
        {
            get { return Operation.RemoveRoleMembers.Builder.SetWrapperObject(this); }
        }
        public UpdateRolePermissions.UpdateRolePermissionsBuilder UpdateRolePermissionsOp
        {
            get { return Operation.UpdateRolePermissions.Builder.SetWrapperObject(this); }
        }
        public AddRolePermission.AddRolePermissionBuilder AddRolePermissionOp
        {
            get { return Operation.AddRolePermission.Builder.SetWrapperObject(this); }
        }
        public DeleteRolePermission.DeleteRolePermissionBuilder DeleteRolePermissionOp
        {
            get { return Operation.DeleteRolePermission.Builder.SetWrapperObject(this); }
        }
        public AdminGetRolesV3.AdminGetRolesV3Builder AdminGetRolesV3Op
        {
            get { return Operation.AdminGetRolesV3.Builder.SetWrapperObject(this); }
        }
        public AdminCreateRoleV3.AdminCreateRoleV3Builder AdminCreateRoleV3Op
        {
            get { return Operation.AdminCreateRoleV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetRoleV3.AdminGetRoleV3Builder AdminGetRoleV3Op
        {
            get { return Operation.AdminGetRoleV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteRoleV3.AdminDeleteRoleV3Builder AdminDeleteRoleV3Op
        {
            get { return Operation.AdminDeleteRoleV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateRoleV3.AdminUpdateRoleV3Builder AdminUpdateRoleV3Op
        {
            get { return Operation.AdminUpdateRoleV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetRoleAdminStatusV3.AdminGetRoleAdminStatusV3Builder AdminGetRoleAdminStatusV3Op
        {
            get { return Operation.AdminGetRoleAdminStatusV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateAdminRoleStatusV3.AdminUpdateAdminRoleStatusV3Builder AdminUpdateAdminRoleStatusV3Op
        {
            get { return Operation.AdminUpdateAdminRoleStatusV3.Builder.SetWrapperObject(this); }
        }
        public AdminRemoveRoleAdminV3.AdminRemoveRoleAdminV3Builder AdminRemoveRoleAdminV3Op
        {
            get { return Operation.AdminRemoveRoleAdminV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetRoleManagersV3.AdminGetRoleManagersV3Builder AdminGetRoleManagersV3Op
        {
            get { return Operation.AdminGetRoleManagersV3.Builder.SetWrapperObject(this); }
        }
        public AdminAddRoleManagersV3.AdminAddRoleManagersV3Builder AdminAddRoleManagersV3Op
        {
            get { return Operation.AdminAddRoleManagersV3.Builder.SetWrapperObject(this); }
        }
        public AdminRemoveRoleManagersV3.AdminRemoveRoleManagersV3Builder AdminRemoveRoleManagersV3Op
        {
            get { return Operation.AdminRemoveRoleManagersV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetRoleMembersV3.AdminGetRoleMembersV3Builder AdminGetRoleMembersV3Op
        {
            get { return Operation.AdminGetRoleMembersV3.Builder.SetWrapperObject(this); }
        }
        public AdminAddRoleMembersV3.AdminAddRoleMembersV3Builder AdminAddRoleMembersV3Op
        {
            get { return Operation.AdminAddRoleMembersV3.Builder.SetWrapperObject(this); }
        }
        public AdminRemoveRoleMembersV3.AdminRemoveRoleMembersV3Builder AdminRemoveRoleMembersV3Op
        {
            get { return Operation.AdminRemoveRoleMembersV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateRolePermissionsV3.AdminUpdateRolePermissionsV3Builder AdminUpdateRolePermissionsV3Op
        {
            get { return Operation.AdminUpdateRolePermissionsV3.Builder.SetWrapperObject(this); }
        }
        public AdminAddRolePermissionsV3.AdminAddRolePermissionsV3Builder AdminAddRolePermissionsV3Op
        {
            get { return Operation.AdminAddRolePermissionsV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteRolePermissionsV3.AdminDeleteRolePermissionsV3Builder AdminDeleteRolePermissionsV3Op
        {
            get { return Operation.AdminDeleteRolePermissionsV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteRolePermissionV3.AdminDeleteRolePermissionV3Builder AdminDeleteRolePermissionV3Op
        {
            get { return Operation.AdminDeleteRolePermissionV3.Builder.SetWrapperObject(this); }
        }
        public PublicGetRolesV3.PublicGetRolesV3Builder PublicGetRolesV3Op
        {
            get { return Operation.PublicGetRolesV3.Builder.SetWrapperObject(this); }
        }
        public PublicGetRoleV3.PublicGetRoleV3Builder PublicGetRoleV3Op
        {
            get { return Operation.PublicGetRoleV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetRolesV4.AdminGetRolesV4Builder AdminGetRolesV4Op
        {
            get { return Operation.AdminGetRolesV4.Builder.SetWrapperObject(this); }
        }
        public AdminCreateRoleV4.AdminCreateRoleV4Builder AdminCreateRoleV4Op
        {
            get { return Operation.AdminCreateRoleV4.Builder.SetWrapperObject(this); }
        }
        public AdminGetRoleV4.AdminGetRoleV4Builder AdminGetRoleV4Op
        {
            get { return Operation.AdminGetRoleV4.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteRoleV4.AdminDeleteRoleV4Builder AdminDeleteRoleV4Op
        {
            get { return Operation.AdminDeleteRoleV4.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateRoleV4.AdminUpdateRoleV4Builder AdminUpdateRoleV4Op
        {
            get { return Operation.AdminUpdateRoleV4.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateRolePermissionsV4.AdminUpdateRolePermissionsV4Builder AdminUpdateRolePermissionsV4Op
        {
            get { return Operation.AdminUpdateRolePermissionsV4.Builder.SetWrapperObject(this); }
        }
        public AdminAddRolePermissionsV4.AdminAddRolePermissionsV4Builder AdminAddRolePermissionsV4Op
        {
            get { return Operation.AdminAddRolePermissionsV4.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteRolePermissionsV4.AdminDeleteRolePermissionsV4Builder AdminDeleteRolePermissionsV4Op
        {
            get { return Operation.AdminDeleteRolePermissionsV4.Builder.SetWrapperObject(this); }
        }
        public AdminListAssignedUsersV4.AdminListAssignedUsersV4Builder AdminListAssignedUsersV4Op
        {
            get { return Operation.AdminListAssignedUsersV4.Builder.SetWrapperObject(this); }
        }
        public AdminAssignUserToRoleV4.AdminAssignUserToRoleV4Builder AdminAssignUserToRoleV4Op
        {
            get { return Operation.AdminAssignUserToRoleV4.Builder.SetWrapperObject(this); }
        }
        public AdminRevokeUserFromRoleV4.AdminRevokeUserFromRoleV4Builder AdminRevokeUserFromRoleV4Op
        {
            get { return Operation.AdminRevokeUserFromRoleV4.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.ModelRoleResponseWithManagers>? GetRoles(GetRoles input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonRole? CreateRole(CreateRole input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleResponse? GetRole(GetRole input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleResponse? UpdateRole(UpdateRole input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteRole(DeleteRole input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleAdminStatusResponse? GetRoleAdminStatus(GetRoleAdminStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SetRoleAsAdmin(SetRoleAsAdmin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void RemoveRoleAdmin(RemoveRoleAdmin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleManagersResponse? GetRoleManagers(GetRoleManagers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AddRoleManagers(AddRoleManagers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void RemoveRoleManagers(RemoveRoleManagers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleMembersResponse? GetRoleMembers(GetRoleMembers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AddRoleMembers(AddRoleMembers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void RemoveRoleMembers(RemoveRoleMembers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateRolePermissions(UpdateRolePermissions input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AddRolePermission(AddRolePermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteRolePermission(DeleteRolePermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleResponseWithManagersAndPaginationV3? AdminGetRolesV3(AdminGetRolesV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonRoleV3? AdminCreateRoleV3(AdminCreateRoleV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleResponseV3? AdminGetRoleV3(AdminGetRoleV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteRoleV3(AdminDeleteRoleV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleResponseV3? AdminUpdateRoleV3(AdminUpdateRoleV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleAdminStatusResponseV3? AdminGetRoleAdminStatusV3(AdminGetRoleAdminStatusV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateAdminRoleStatusV3(AdminUpdateAdminRoleStatusV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminRemoveRoleAdminV3(AdminRemoveRoleAdminV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleManagersResponsesV3? AdminGetRoleManagersV3(AdminGetRoleManagersV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminAddRoleManagersV3(AdminAddRoleManagersV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminRemoveRoleManagersV3(AdminRemoveRoleManagersV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleMembersResponseV3? AdminGetRoleMembersV3(AdminGetRoleMembersV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminAddRoleMembersV3(AdminAddRoleMembersV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminRemoveRoleMembersV3(AdminRemoveRoleMembersV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateRolePermissionsV3(AdminUpdateRolePermissionsV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminAddRolePermissionsV3(AdminAddRolePermissionsV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteRolePermissionsV3(AdminDeleteRolePermissionsV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteRolePermissionV3(AdminDeleteRolePermissionV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleNamesResponseV3? PublicGetRolesV3(PublicGetRolesV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleResponse? PublicGetRoleV3(PublicGetRoleV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListRoleV4Response? AdminGetRolesV4(AdminGetRolesV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleV4Response? AdminCreateRoleV4(AdminCreateRoleV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleV4Response? AdminGetRoleV4(AdminGetRoleV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteRoleV4(AdminDeleteRoleV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleV4Response? AdminUpdateRoleV4(AdminUpdateRoleV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleV4Response? AdminUpdateRolePermissionsV4(AdminUpdateRolePermissionsV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleV4Response? AdminAddRolePermissionsV4(AdminAddRolePermissionsV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteRolePermissionsV4(AdminDeleteRolePermissionsV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListAssignedUsersV4Response? AdminListAssignedUsersV4(AdminListAssignedUsersV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelAssignedUserV4Response? AdminAssignUserToRoleV4(AdminAssignUserToRoleV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminRevokeUserFromRoleV4(AdminRevokeUserFromRoleV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Roles_OperationExtensions
    {
        public static List<Model.ModelRoleResponseWithManagers>? Execute(
            this GetRoles.GetRolesBuilder builder
        )
        {
            GetRoles op = builder.Build(
            );

            return ((Roles)builder.WrapperObject!).GetRoles(op);
        }

        public static Model.AccountcommonRole? Execute(
            this CreateRole.CreateRoleBuilder builder,
            ModelRoleCreateRequest body
        )
        {
            CreateRole op = builder.Build(
                body
            );

            return ((Roles)builder.WrapperObject!).CreateRole(op);
        }

        public static Model.ModelRoleResponse? Execute(
            this GetRole.GetRoleBuilder builder,
            string roleId
        )
        {
            GetRole op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).GetRole(op);
        }

        public static Model.ModelRoleResponse? Execute(
            this UpdateRole.UpdateRoleBuilder builder,
            ModelRoleUpdateRequest body,
            string roleId
        )
        {
            UpdateRole op = builder.Build(
                body,
                roleId
            );

            return ((Roles)builder.WrapperObject!).UpdateRole(op);
        }

        public static void Execute(
            this DeleteRole.DeleteRoleBuilder builder,
            string roleId
        )
        {
            DeleteRole op = builder.Build(
                roleId
            );

            ((Roles)builder.WrapperObject!).DeleteRole(op);
        }

        public static Model.ModelRoleAdminStatusResponse? Execute(
            this GetRoleAdminStatus.GetRoleAdminStatusBuilder builder,
            string roleId
        )
        {
            GetRoleAdminStatus op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).GetRoleAdminStatus(op);
        }

        public static void Execute(
            this SetRoleAsAdmin.SetRoleAsAdminBuilder builder,
            string roleId
        )
        {
            SetRoleAsAdmin op = builder.Build(
                roleId
            );

            ((Roles)builder.WrapperObject!).SetRoleAsAdmin(op);
        }

        public static void Execute(
            this RemoveRoleAdmin.RemoveRoleAdminBuilder builder,
            string roleId
        )
        {
            RemoveRoleAdmin op = builder.Build(
                roleId
            );

            ((Roles)builder.WrapperObject!).RemoveRoleAdmin(op);
        }

        public static Model.ModelRoleManagersResponse? Execute(
            this GetRoleManagers.GetRoleManagersBuilder builder,
            string roleId
        )
        {
            GetRoleManagers op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).GetRoleManagers(op);
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

            ((Roles)builder.WrapperObject!).AddRoleManagers(op);
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

            ((Roles)builder.WrapperObject!).RemoveRoleManagers(op);
        }

        public static Model.ModelRoleMembersResponse? Execute(
            this GetRoleMembers.GetRoleMembersBuilder builder,
            string roleId
        )
        {
            GetRoleMembers op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).GetRoleMembers(op);
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

            ((Roles)builder.WrapperObject!).AddRoleMembers(op);
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

            ((Roles)builder.WrapperObject!).RemoveRoleMembers(op);
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

            ((Roles)builder.WrapperObject!).UpdateRolePermissions(op);
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

            ((Roles)builder.WrapperObject!).AddRolePermission(op);
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

            ((Roles)builder.WrapperObject!).DeleteRolePermission(op);
        }

        public static Model.ModelRoleResponseWithManagersAndPaginationV3? Execute(
            this AdminGetRolesV3.AdminGetRolesV3Builder builder
        )
        {
            AdminGetRolesV3 op = builder.Build(
            );

            return ((Roles)builder.WrapperObject!).AdminGetRolesV3(op);
        }

        public static Model.AccountcommonRoleV3? Execute(
            this AdminCreateRoleV3.AdminCreateRoleV3Builder builder,
            ModelRoleCreateV3Request body
        )
        {
            AdminCreateRoleV3 op = builder.Build(
                body
            );

            return ((Roles)builder.WrapperObject!).AdminCreateRoleV3(op);
        }

        public static Model.ModelRoleResponseV3? Execute(
            this AdminGetRoleV3.AdminGetRoleV3Builder builder,
            string roleId
        )
        {
            AdminGetRoleV3 op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminGetRoleV3(op);
        }

        public static void Execute(
            this AdminDeleteRoleV3.AdminDeleteRoleV3Builder builder,
            string roleId
        )
        {
            AdminDeleteRoleV3 op = builder.Build(
                roleId
            );

            ((Roles)builder.WrapperObject!).AdminDeleteRoleV3(op);
        }

        public static Model.ModelRoleResponseV3? Execute(
            this AdminUpdateRoleV3.AdminUpdateRoleV3Builder builder,
            ModelRoleUpdateRequestV3 body,
            string roleId
        )
        {
            AdminUpdateRoleV3 op = builder.Build(
                body,
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminUpdateRoleV3(op);
        }

        public static Model.ModelRoleAdminStatusResponseV3? Execute(
            this AdminGetRoleAdminStatusV3.AdminGetRoleAdminStatusV3Builder builder,
            string roleId
        )
        {
            AdminGetRoleAdminStatusV3 op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminGetRoleAdminStatusV3(op);
        }

        public static void Execute(
            this AdminUpdateAdminRoleStatusV3.AdminUpdateAdminRoleStatusV3Builder builder,
            string roleId
        )
        {
            AdminUpdateAdminRoleStatusV3 op = builder.Build(
                roleId
            );

            ((Roles)builder.WrapperObject!).AdminUpdateAdminRoleStatusV3(op);
        }

        public static void Execute(
            this AdminRemoveRoleAdminV3.AdminRemoveRoleAdminV3Builder builder,
            string roleId
        )
        {
            AdminRemoveRoleAdminV3 op = builder.Build(
                roleId
            );

            ((Roles)builder.WrapperObject!).AdminRemoveRoleAdminV3(op);
        }

        public static Model.ModelRoleManagersResponsesV3? Execute(
            this AdminGetRoleManagersV3.AdminGetRoleManagersV3Builder builder,
            string roleId
        )
        {
            AdminGetRoleManagersV3 op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminGetRoleManagersV3(op);
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

            ((Roles)builder.WrapperObject!).AdminAddRoleManagersV3(op);
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

            ((Roles)builder.WrapperObject!).AdminRemoveRoleManagersV3(op);
        }

        public static Model.ModelRoleMembersResponseV3? Execute(
            this AdminGetRoleMembersV3.AdminGetRoleMembersV3Builder builder,
            string roleId
        )
        {
            AdminGetRoleMembersV3 op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminGetRoleMembersV3(op);
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

            ((Roles)builder.WrapperObject!).AdminAddRoleMembersV3(op);
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

            ((Roles)builder.WrapperObject!).AdminRemoveRoleMembersV3(op);
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

            ((Roles)builder.WrapperObject!).AdminUpdateRolePermissionsV3(op);
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

            ((Roles)builder.WrapperObject!).AdminAddRolePermissionsV3(op);
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

            ((Roles)builder.WrapperObject!).AdminDeleteRolePermissionsV3(op);
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

            ((Roles)builder.WrapperObject!).AdminDeleteRolePermissionV3(op);
        }

        public static Model.ModelRoleNamesResponseV3? Execute(
            this PublicGetRolesV3.PublicGetRolesV3Builder builder
        )
        {
            PublicGetRolesV3 op = builder.Build(
            );

            return ((Roles)builder.WrapperObject!).PublicGetRolesV3(op);
        }

        public static Model.ModelRoleResponse? Execute(
            this PublicGetRoleV3.PublicGetRoleV3Builder builder,
            string roleId
        )
        {
            PublicGetRoleV3 op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).PublicGetRoleV3(op);
        }

        public static Model.ModelListRoleV4Response? Execute(
            this AdminGetRolesV4.AdminGetRolesV4Builder builder
        )
        {
            AdminGetRolesV4 op = builder.Build(
            );

            return ((Roles)builder.WrapperObject!).AdminGetRolesV4(op);
        }

        public static Model.ModelRoleV4Response? Execute(
            this AdminCreateRoleV4.AdminCreateRoleV4Builder builder,
            ModelRoleV4Request body
        )
        {
            AdminCreateRoleV4 op = builder.Build(
                body
            );

            return ((Roles)builder.WrapperObject!).AdminCreateRoleV4(op);
        }

        public static Model.ModelRoleV4Response? Execute(
            this AdminGetRoleV4.AdminGetRoleV4Builder builder,
            string roleId
        )
        {
            AdminGetRoleV4 op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminGetRoleV4(op);
        }

        public static void Execute(
            this AdminDeleteRoleV4.AdminDeleteRoleV4Builder builder,
            string roleId
        )
        {
            AdminDeleteRoleV4 op = builder.Build(
                roleId
            );

            ((Roles)builder.WrapperObject!).AdminDeleteRoleV4(op);
        }

        public static Model.ModelRoleV4Response? Execute(
            this AdminUpdateRoleV4.AdminUpdateRoleV4Builder builder,
            ModelRoleV4Request body,
            string roleId
        )
        {
            AdminUpdateRoleV4 op = builder.Build(
                body,
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminUpdateRoleV4(op);
        }

        public static Model.ModelRoleV4Response? Execute(
            this AdminUpdateRolePermissionsV4.AdminUpdateRolePermissionsV4Builder builder,
            AccountcommonPermissionsV3 body,
            string roleId
        )
        {
            AdminUpdateRolePermissionsV4 op = builder.Build(
                body,
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminUpdateRolePermissionsV4(op);
        }

        public static Model.ModelRoleV4Response? Execute(
            this AdminAddRolePermissionsV4.AdminAddRolePermissionsV4Builder builder,
            AccountcommonPermissionsV3 body,
            string roleId
        )
        {
            AdminAddRolePermissionsV4 op = builder.Build(
                body,
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminAddRolePermissionsV4(op);
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

            ((Roles)builder.WrapperObject!).AdminDeleteRolePermissionsV4(op);
        }

        public static Model.ModelListAssignedUsersV4Response? Execute(
            this AdminListAssignedUsersV4.AdminListAssignedUsersV4Builder builder,
            string roleId
        )
        {
            AdminListAssignedUsersV4 op = builder.Build(
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminListAssignedUsersV4(op);
        }

        public static Model.ModelAssignedUserV4Response? Execute(
            this AdminAssignUserToRoleV4.AdminAssignUserToRoleV4Builder builder,
            ModelAssignUserV4Request body,
            string roleId
        )
        {
            AdminAssignUserToRoleV4 op = builder.Build(
                body,
                roleId
            );

            return ((Roles)builder.WrapperObject!).AdminAssignUserToRoleV4(op);
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

            ((Roles)builder.WrapperObject!).AdminRevokeUserFromRoleV4(op);
        }

    }
}