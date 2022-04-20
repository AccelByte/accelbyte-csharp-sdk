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

    public static class GroupRoles_OperationExtensions
    {
        public static Model.ModelsGetMemberRolesListResponseV1? Execute(
            this GetMemberRolesListAdminV1.GetMemberRolesListAdminV1Builder builder,
            string namespace_
        )
        {
            GetMemberRolesListAdminV1 op = builder.Build(
                namespace_
            );

            return ((GroupRoles)builder.WrapperObject!).GetMemberRolesListAdminV1(op);
        }

        public static Model.ModelsCreateMemberRoleResponseV1? Execute(
            this CreateMemberRoleAdminV1.CreateMemberRoleAdminV1Builder builder,
            ModelsCreateMemberRoleRequestV1 body,
            string namespace_
        )
        {
            CreateMemberRoleAdminV1 op = builder.Build(
                body,
                namespace_
            );

            return ((GroupRoles)builder.WrapperObject!).CreateMemberRoleAdminV1(op);
        }

        public static Model.ModelsGetMemberRoleResponseV1? Execute(
            this GetSingleMemberRoleAdminV1.GetSingleMemberRoleAdminV1Builder builder,
            string memberRoleId,
            string namespace_
        )
        {
            GetSingleMemberRoleAdminV1 op = builder.Build(
                memberRoleId,
                namespace_
            );

            return ((GroupRoles)builder.WrapperObject!).GetSingleMemberRoleAdminV1(op);
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

            ((GroupRoles)builder.WrapperObject!).DeleteMemberRoleAdminV1(op);
        }

        public static Model.ModelsUpdateMemberRoleResponseV1? Execute(
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

            return ((GroupRoles)builder.WrapperObject!).UpdateMemberRoleAdminV1(op);
        }

        public static Model.ModelsUpdateMemberRoleResponseV1? Execute(
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

            return ((GroupRoles)builder.WrapperObject!).UpdateMemberRolePermissionAdminV1(op);
        }

        public static Model.ModelsGetMemberRolesListResponseV1? Execute(
            this GetMemberRolesListPublicV1.GetMemberRolesListPublicV1Builder builder,
            string namespace_
        )
        {
            GetMemberRolesListPublicV1 op = builder.Build(
                namespace_
            );

            return ((GroupRoles)builder.WrapperObject!).GetMemberRolesListPublicV1(op);
        }

        public static Model.ModelsGetUserGroupInformationResponseV1? Execute(
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

            return ((GroupRoles)builder.WrapperObject!).UpdateMemberRolePublicV1(op);
        }

        public static Model.ModelsUpdateMemberRoleResponseV1? Execute(
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

            return ((GroupRoles)builder.WrapperObject!).DeleteMemberRolePublicV1(op);
        }

    }
}