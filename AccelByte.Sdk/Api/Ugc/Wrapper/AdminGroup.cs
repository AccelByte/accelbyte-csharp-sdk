// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminGroup
    {
        private readonly AccelByteSDK _sdk;

        public AdminGroup(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public SingleAdminGetAllGroups.SingleAdminGetAllGroupsBuilder SingleAdminGetAllGroupsOp
        {
            get { return Operation.SingleAdminGetAllGroups.Builder.SetWrapperObject(this); }
        }
        public AdminCreateGroup.AdminCreateGroupBuilder AdminCreateGroupOp
        {
            get { return Operation.AdminCreateGroup.Builder.SetWrapperObject(this); }
        }
        public SingleAdminGetGroup.SingleAdminGetGroupBuilder SingleAdminGetGroupOp
        {
            get { return Operation.SingleAdminGetGroup.Builder.SetWrapperObject(this); }
        }
        public SingleAdminUpdateGroup.SingleAdminUpdateGroupBuilder SingleAdminUpdateGroupOp
        {
            get { return Operation.SingleAdminUpdateGroup.Builder.SetWrapperObject(this); }
        }
        public SingleAdminDeleteGroup.SingleAdminDeleteGroupBuilder SingleAdminDeleteGroupOp
        {
            get { return Operation.SingleAdminDeleteGroup.Builder.SetWrapperObject(this); }
        }
        public SingleAdminGetGroupContents.SingleAdminGetGroupContentsBuilder SingleAdminGetGroupContentsOp
        {
            get { return Operation.SingleAdminGetGroupContents.Builder.SetWrapperObject(this); }
        }
        public AdminGetAllGroups.AdminGetAllGroupsBuilder AdminGetAllGroupsOp
        {
            get { return Operation.AdminGetAllGroups.Builder.SetWrapperObject(this); }
        }
        public AdminGetGroup.AdminGetGroupBuilder AdminGetGroupOp
        {
            get { return Operation.AdminGetGroup.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateGroup.AdminUpdateGroupBuilder AdminUpdateGroupOp
        {
            get { return Operation.AdminUpdateGroup.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteGroup.AdminDeleteGroupBuilder AdminDeleteGroupOp
        {
            get { return Operation.AdminDeleteGroup.Builder.SetWrapperObject(this); }
        }
        public AdminGetGroupContents.AdminGetGroupContentsBuilder AdminGetGroupContentsOp
        {
            get { return Operation.AdminGetGroupContents.Builder.SetWrapperObject(this); }
        }
        public AdminGetOfficialGroupContentsV2.AdminGetOfficialGroupContentsV2Builder AdminGetOfficialGroupContentsV2Op
        {
            get { return Operation.AdminGetOfficialGroupContentsV2.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserGroupContentsV2.AdminGetUserGroupContentsV2Builder AdminGetUserGroupContentsV2Op
        {
            get { return Operation.AdminGetUserGroupContentsV2.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsPaginatedGroupResponse? SingleAdminGetAllGroups(SingleAdminGetAllGroups input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedGroupResponse?> SingleAdminGetAllGroupsAsync(SingleAdminGetAllGroups input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? AdminCreateGroup(AdminCreateGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsCreateGroupResponse?> AdminCreateGroupAsync(AdminCreateGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? SingleAdminGetGroup(SingleAdminGetGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsCreateGroupResponse?> SingleAdminGetGroupAsync(SingleAdminGetGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? SingleAdminUpdateGroup(SingleAdminUpdateGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsCreateGroupResponse?> SingleAdminUpdateGroupAsync(SingleAdminUpdateGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SingleAdminDeleteGroup(SingleAdminDeleteGroup input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SingleAdminDeleteGroupAsync(SingleAdminDeleteGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? SingleAdminGetGroupContents(SingleAdminGetGroupContents input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedContentDownloadResponse?> SingleAdminGetGroupContentsAsync(SingleAdminGetGroupContents input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedGroupResponse? AdminGetAllGroups(AdminGetAllGroups input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedGroupResponse?> AdminGetAllGroupsAsync(AdminGetAllGroups input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? AdminGetGroup(AdminGetGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsCreateGroupResponse?> AdminGetGroupAsync(AdminGetGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateGroupResponse? AdminUpdateGroup(AdminUpdateGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsCreateGroupResponse?> AdminUpdateGroupAsync(AdminUpdateGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteGroup(AdminDeleteGroup input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteGroupAsync(AdminDeleteGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponse? AdminGetGroupContents(AdminGetGroupContents input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedContentDownloadResponse?> AdminGetGroupContentsAsync(AdminGetGroupContents input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponseV2? AdminGetOfficialGroupContentsV2(AdminGetOfficialGroupContentsV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedContentDownloadResponseV2?> AdminGetOfficialGroupContentsV2Async(AdminGetOfficialGroupContentsV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedContentDownloadResponseV2? AdminGetUserGroupContentsV2(AdminGetUserGroupContentsV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPaginatedContentDownloadResponseV2?> AdminGetUserGroupContentsV2Async(AdminGetUserGroupContentsV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}