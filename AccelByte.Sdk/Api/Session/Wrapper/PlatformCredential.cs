// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class PlatformCredential
    {
        private readonly AccelByteSDK _sdk;

        public PlatformCredential(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetPlatformCredentials.AdminGetPlatformCredentialsBuilder AdminGetPlatformCredentialsOp
        {
            get { return Operation.AdminGetPlatformCredentials.Builder.SetWrapperObject(this); }
        }
        public AdminUpdatePlatformCredentials.AdminUpdatePlatformCredentialsBuilder AdminUpdatePlatformCredentialsOp
        {
            get { return Operation.AdminUpdatePlatformCredentials.Builder.SetWrapperObject(this); }
        }
        public AdminDeletePlatformCredentials.AdminDeletePlatformCredentialsBuilder AdminDeletePlatformCredentialsOp
        {
            get { return Operation.AdminDeletePlatformCredentials.Builder.SetWrapperObject(this); }
        }
        public AdminDeletePlatformCredentialsByPlatformId.AdminDeletePlatformCredentialsByPlatformIdBuilder AdminDeletePlatformCredentialsByPlatformIdOp
        {
            get { return Operation.AdminDeletePlatformCredentialsByPlatformId.Builder.SetWrapperObject(this); }
        }
        public AdminSyncPlatformCredentials.AdminSyncPlatformCredentialsBuilder AdminSyncPlatformCredentialsOp
        {
            get { return Operation.AdminSyncPlatformCredentials.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsPlatformCredentials? AdminGetPlatformCredentials(AdminGetPlatformCredentials input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPlatformCredentials?> AdminGetPlatformCredentialsAsync(AdminGetPlatformCredentials input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlatformCredentials? AdminUpdatePlatformCredentials(AdminUpdatePlatformCredentials input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsPlatformCredentials?> AdminUpdatePlatformCredentialsAsync(AdminUpdatePlatformCredentials input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlatformCredentials(AdminDeletePlatformCredentials input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeletePlatformCredentialsAsync(AdminDeletePlatformCredentials input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlatformCredentialsByPlatformId(AdminDeletePlatformCredentialsByPlatformId input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeletePlatformCredentialsByPlatformIdAsync(AdminDeletePlatformCredentialsByPlatformId input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsXblCertificateResponseBody? AdminSyncPlatformCredentials(AdminSyncPlatformCredentials input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsXblCertificateResponseBody?> AdminSyncPlatformCredentialsAsync(AdminSyncPlatformCredentials input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}