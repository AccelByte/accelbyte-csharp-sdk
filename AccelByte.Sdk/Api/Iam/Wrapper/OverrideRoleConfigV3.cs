// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class OverrideRoleConfigV3
    {
        private readonly AccelByteSDK _sdk;

        public OverrideRoleConfigV3(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetRoleOverrideConfigV3.AdminGetRoleOverrideConfigV3Builder AdminGetRoleOverrideConfigV3Op
        {
            get { return Operation.AdminGetRoleOverrideConfigV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateRoleOverrideConfigV3.AdminUpdateRoleOverrideConfigV3Builder AdminUpdateRoleOverrideConfigV3Op
        {
            get { return Operation.AdminUpdateRoleOverrideConfigV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetRoleSourceV3.AdminGetRoleSourceV3Builder AdminGetRoleSourceV3Op
        {
            get { return Operation.AdminGetRoleSourceV3.Builder.SetWrapperObject(this); }
        }
        public AdminChangeRoleOverrideConfigStatusV3.AdminChangeRoleOverrideConfigStatusV3Builder AdminChangeRoleOverrideConfigStatusV3Op
        {
            get { return Operation.AdminChangeRoleOverrideConfigStatusV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetRoleNamespacePermissionV3.AdminGetRoleNamespacePermissionV3Builder AdminGetRoleNamespacePermissionV3Op
        {
            get { return Operation.AdminGetRoleNamespacePermissionV3.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelRoleOverrideResponse? AdminGetRoleOverrideConfigV3(AdminGetRoleOverrideConfigV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelRoleOverrideResponse?> AdminGetRoleOverrideConfigV3Async(AdminGetRoleOverrideConfigV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleOverrideResponse? AdminUpdateRoleOverrideConfigV3(AdminUpdateRoleOverrideConfigV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelRoleOverrideResponse?> AdminUpdateRoleOverrideConfigV3Async(AdminUpdateRoleOverrideConfigV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleOverrideSourceResponse? AdminGetRoleSourceV3(AdminGetRoleSourceV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelRoleOverrideSourceResponse?> AdminGetRoleSourceV3Async(AdminGetRoleSourceV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRoleOverrideResponse? AdminChangeRoleOverrideConfigStatusV3(AdminChangeRoleOverrideConfigStatusV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelRoleOverrideResponse?> AdminChangeRoleOverrideConfigStatusV3Async(AdminChangeRoleOverrideConfigStatusV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelRolePermissionResponseV3? AdminGetRoleNamespacePermissionV3(AdminGetRoleNamespacePermissionV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelRolePermissionResponseV3?> AdminGetRoleNamespacePermissionV3Async(AdminGetRoleNamespacePermissionV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}