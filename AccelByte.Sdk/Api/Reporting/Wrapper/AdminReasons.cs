// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Reporting.Wrapper
{
    public class AdminReasons
    {
        private readonly AccelByteSDK _sdk;

        public AdminReasons(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListReasonGroups.AdminListReasonGroupsBuilder AdminListReasonGroupsOp
        {
            get { return Operation.AdminListReasonGroups.Builder.SetWrapperObject(this); }
        }
        public CreateReasonGroup.CreateReasonGroupBuilder CreateReasonGroupOp
        {
            get { return Operation.CreateReasonGroup.Builder.SetWrapperObject(this); }
        }
        public GetReasonGroup.GetReasonGroupBuilder GetReasonGroupOp
        {
            get { return Operation.GetReasonGroup.Builder.SetWrapperObject(this); }
        }
        public DeleteReasonGroup.DeleteReasonGroupBuilder DeleteReasonGroupOp
        {
            get { return Operation.DeleteReasonGroup.Builder.SetWrapperObject(this); }
        }
        public UpdateReasonGroup.UpdateReasonGroupBuilder UpdateReasonGroupOp
        {
            get { return Operation.UpdateReasonGroup.Builder.SetWrapperObject(this); }
        }
        public AdminGetReasons.AdminGetReasonsBuilder AdminGetReasonsOp
        {
            get { return Operation.AdminGetReasons.Builder.SetWrapperObject(this); }
        }
        public CreateReason.CreateReasonBuilder CreateReasonOp
        {
            get { return Operation.CreateReason.Builder.SetWrapperObject(this); }
        }
        public AdminGetAllReasons.AdminGetAllReasonsBuilder AdminGetAllReasonsOp
        {
            get { return Operation.AdminGetAllReasons.Builder.SetWrapperObject(this); }
        }
        public AdminGetUnusedReasons.AdminGetUnusedReasonsBuilder AdminGetUnusedReasonsOp
        {
            get { return Operation.AdminGetUnusedReasons.Builder.SetWrapperObject(this); }
        }
        public AdminGetReason.AdminGetReasonBuilder AdminGetReasonOp
        {
            get { return Operation.AdminGetReason.Builder.SetWrapperObject(this); }
        }
        public DeleteReason.DeleteReasonBuilder DeleteReasonOp
        {
            get { return Operation.DeleteReason.Builder.SetWrapperObject(this); }
        }
        public UpdateReason.UpdateReasonBuilder UpdateReasonOp
        {
            get { return Operation.UpdateReason.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.RestapiReasonGroupListResponse? AdminListReasonGroups(AdminListReasonGroups input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiReasonGroupListResponse?> AdminListReasonGroupsAsync(AdminListReasonGroups input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiReasonGroupResponse? CreateReasonGroup(CreateReasonGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiReasonGroupResponse?> CreateReasonGroupAsync(CreateReasonGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiReasonGroupResponse? GetReasonGroup(GetReasonGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiReasonGroupResponse?> GetReasonGroupAsync(GetReasonGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteReasonGroup(DeleteReasonGroup input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteReasonGroupAsync(DeleteReasonGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiReasonGroupResponse? UpdateReasonGroup(UpdateReasonGroup input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiReasonGroupResponse?> UpdateReasonGroupAsync(UpdateReasonGroup input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminReasonListResponse? AdminGetReasons(AdminGetReasons input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminReasonListResponse?> AdminGetReasonsAsync(AdminGetReasons input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminReasonResponse? CreateReason(CreateReason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminReasonResponse?> CreateReasonAsync(CreateReason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminAllReasonsResponse? AdminGetAllReasons(AdminGetAllReasons input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminAllReasonsResponse?> AdminGetAllReasonsAsync(AdminGetAllReasons input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiUnusedReasonListResponse? AdminGetUnusedReasons(AdminGetUnusedReasons input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiUnusedReasonListResponse?> AdminGetUnusedReasonsAsync(AdminGetUnusedReasons input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminReasonResponse? AdminGetReason(AdminGetReason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminReasonResponse?> AdminGetReasonAsync(AdminGetReason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteReason(DeleteReason input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteReasonAsync(DeleteReason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RestapiAdminReasonResponse? UpdateReason(UpdateReason input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RestapiAdminReasonResponse?> UpdateReasonAsync(UpdateReason input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}