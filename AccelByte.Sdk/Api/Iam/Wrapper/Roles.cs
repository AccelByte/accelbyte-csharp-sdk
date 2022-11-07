// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetRoles.GetRolesBuilder GetRolesOp
        {
            get { return Operation.GetRoles.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public CreateRole.CreateRoleBuilder CreateRoleOp
        {
            get { return Operation.CreateRole.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetRole.GetRoleBuilder GetRoleOp
        {
            get { return Operation.GetRole.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public UpdateRole.UpdateRoleBuilder UpdateRoleOp
        {
            get { return Operation.UpdateRole.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DeleteRole.DeleteRoleBuilder DeleteRoleOp
        {
            get { return Operation.DeleteRole.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetRoleAdminStatus.GetRoleAdminStatusBuilder GetRoleAdminStatusOp
        {
            get { return Operation.GetRoleAdminStatus.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SetRoleAsAdmin.SetRoleAsAdminBuilder SetRoleAsAdminOp
        {
            get { return Operation.SetRoleAsAdmin.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public RemoveRoleAdmin.RemoveRoleAdminBuilder RemoveRoleAdminOp
        {
            get { return Operation.RemoveRoleAdmin.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetRoleManagers.GetRoleManagersBuilder GetRoleManagersOp
        {
            get { return Operation.GetRoleManagers.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public AddRoleManagers.AddRoleManagersBuilder AddRoleManagersOp
        {
            get { return Operation.AddRoleManagers.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public RemoveRoleManagers.RemoveRoleManagersBuilder RemoveRoleManagersOp
        {
            get { return Operation.RemoveRoleManagers.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetRoleMembers.GetRoleMembersBuilder GetRoleMembersOp
        {
            get { return Operation.GetRoleMembers.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public AddRoleMembers.AddRoleMembersBuilder AddRoleMembersOp
        {
            get { return Operation.AddRoleMembers.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public RemoveRoleMembers.RemoveRoleMembersBuilder RemoveRoleMembersOp
        {
            get { return Operation.RemoveRoleMembers.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public UpdateRolePermissions.UpdateRolePermissionsBuilder UpdateRolePermissionsOp
        {
            get { return Operation.UpdateRolePermissions.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public AddRolePermission.AddRolePermissionBuilder AddRolePermissionOp
        {
            get { return Operation.AddRolePermission.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public List<Model.ModelRoleResponseWithManagers>? GetRoles(GetRoles input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.AccountcommonRole? CreateRole(CreateRole input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelRoleResponse? GetRole(GetRole input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelRoleResponse? UpdateRole(UpdateRole input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void DeleteRole(DeleteRole input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelRoleAdminStatusResponse? GetRoleAdminStatus(GetRoleAdminStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void SetRoleAsAdmin(SetRoleAsAdmin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void RemoveRoleAdmin(RemoveRoleAdmin input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelRoleManagersResponse? GetRoleManagers(GetRoleManagers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void AddRoleManagers(AddRoleManagers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void RemoveRoleManagers(RemoveRoleManagers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelRoleMembersResponse? GetRoleMembers(GetRoleMembers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void AddRoleMembers(AddRoleMembers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void RemoveRoleMembers(RemoveRoleMembers input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void UpdateRolePermissions(UpdateRolePermissions input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void AddRolePermission(AddRolePermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void DeleteRolePermission(DeleteRolePermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
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
}