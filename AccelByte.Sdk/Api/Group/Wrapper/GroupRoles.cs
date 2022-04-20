// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class GroupRoles
    {
        private readonly AccelByteSDK _sdk;

        public GroupRoles(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetMemberRolesListAdminV1.GetMemberRolesListAdminV1Builder GetMemberRolesListAdminV1Op
        {
            get { return Operation.GetMemberRolesListAdminV1.Builder.SetWrapperObject(this); }
        }
        public CreateMemberRoleAdminV1.CreateMemberRoleAdminV1Builder CreateMemberRoleAdminV1Op
        {
            get { return Operation.CreateMemberRoleAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetSingleMemberRoleAdminV1.GetSingleMemberRoleAdminV1Builder GetSingleMemberRoleAdminV1Op
        {
            get { return Operation.GetSingleMemberRoleAdminV1.Builder.SetWrapperObject(this); }
        }
        public DeleteMemberRoleAdminV1.DeleteMemberRoleAdminV1Builder DeleteMemberRoleAdminV1Op
        {
            get { return Operation.DeleteMemberRoleAdminV1.Builder.SetWrapperObject(this); }
        }
        public UpdateMemberRoleAdminV1.UpdateMemberRoleAdminV1Builder UpdateMemberRoleAdminV1Op
        {
            get { return Operation.UpdateMemberRoleAdminV1.Builder.SetWrapperObject(this); }
        }
        public UpdateMemberRolePermissionAdminV1.UpdateMemberRolePermissionAdminV1Builder UpdateMemberRolePermissionAdminV1Op
        {
            get { return Operation.UpdateMemberRolePermissionAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetMemberRolesListPublicV1.GetMemberRolesListPublicV1Builder GetMemberRolesListPublicV1Op
        {
            get { return Operation.GetMemberRolesListPublicV1.Builder.SetWrapperObject(this); }
        }
        public UpdateMemberRolePublicV1.UpdateMemberRolePublicV1Builder UpdateMemberRolePublicV1Op
        {
            get { return Operation.UpdateMemberRolePublicV1.Builder.SetWrapperObject(this); }
        }
        public DeleteMemberRolePublicV1.DeleteMemberRolePublicV1Builder DeleteMemberRolePublicV1Op
        {
            get { return Operation.DeleteMemberRolePublicV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsGetMemberRolesListResponseV1? GetMemberRolesListAdminV1(GetMemberRolesListAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateMemberRoleResponseV1? CreateMemberRoleAdminV1(CreateMemberRoleAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRoleResponseV1? GetSingleMemberRoleAdminV1(GetSingleMemberRoleAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteMemberRoleAdminV1(DeleteMemberRoleAdminV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateMemberRoleResponseV1? UpdateMemberRoleAdminV1(UpdateMemberRoleAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateMemberRoleResponseV1? UpdateMemberRolePermissionAdminV1(UpdateMemberRolePermissionAdminV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRolesListResponseV1? GetMemberRolesListPublicV1(GetMemberRolesListPublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserGroupInformationResponseV1? UpdateMemberRolePublicV1(UpdateMemberRolePublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUpdateMemberRoleResponseV1? DeleteMemberRolePublicV1(DeleteMemberRolePublicV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}