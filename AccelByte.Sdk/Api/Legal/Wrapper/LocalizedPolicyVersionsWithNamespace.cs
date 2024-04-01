// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class LocalizedPolicyVersionsWithNamespace
    {
        private readonly AccelByteSDK _sdk;

        public LocalizedPolicyVersionsWithNamespace(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveLocalizedPolicyVersions1.RetrieveLocalizedPolicyVersions1Builder RetrieveLocalizedPolicyVersions1Op
        {
            get { return Operation.RetrieveLocalizedPolicyVersions1.Builder.SetWrapperObject(this); }
        }
        public CreateLocalizedPolicyVersion1.CreateLocalizedPolicyVersion1Builder CreateLocalizedPolicyVersion1Op
        {
            get { return Operation.CreateLocalizedPolicyVersion1.Builder.SetWrapperObject(this); }
        }
        public RetrieveSingleLocalizedPolicyVersion1.RetrieveSingleLocalizedPolicyVersion1Builder RetrieveSingleLocalizedPolicyVersion1Op
        {
            get { return Operation.RetrieveSingleLocalizedPolicyVersion1.Builder.SetWrapperObject(this); }
        }
        public UpdateLocalizedPolicyVersion1.UpdateLocalizedPolicyVersion1Builder UpdateLocalizedPolicyVersion1Op
        {
            get { return Operation.UpdateLocalizedPolicyVersion1.Builder.SetWrapperObject(this); }
        }
        public RequestPresignedURL1.RequestPresignedURL1Builder RequestPresignedURL1Op
        {
            get { return Operation.RequestPresignedURL1.Builder.SetWrapperObject(this); }
        }
        public SetDefaultPolicy1.SetDefaultPolicy1Builder SetDefaultPolicy1Op
        {
            get { return Operation.SetDefaultPolicy1.Builder.SetWrapperObject(this); }
        }
        public RetrieveSingleLocalizedPolicyVersion3.RetrieveSingleLocalizedPolicyVersion3Builder RetrieveSingleLocalizedPolicyVersion3Op
        {
            get { return Operation.RetrieveSingleLocalizedPolicyVersion3.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<Model.RetrieveLocalizedPolicyVersionResponse>? RetrieveLocalizedPolicyVersions1(RetrieveLocalizedPolicyVersions1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrieveLocalizedPolicyVersionResponse>?> RetrieveLocalizedPolicyVersions1Async(RetrieveLocalizedPolicyVersions1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreateLocalizedPolicyVersionResponse? CreateLocalizedPolicyVersion1(CreateLocalizedPolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CreateLocalizedPolicyVersionResponse?> CreateLocalizedPolicyVersion1Async(CreateLocalizedPolicyVersion1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveLocalizedPolicyVersionResponse? RetrieveSingleLocalizedPolicyVersion1(RetrieveSingleLocalizedPolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RetrieveLocalizedPolicyVersionResponse?> RetrieveSingleLocalizedPolicyVersion1Async(RetrieveSingleLocalizedPolicyVersion1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UpdateLocalizedPolicyVersionResponse? UpdateLocalizedPolicyVersion1(UpdateLocalizedPolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.UpdateLocalizedPolicyVersionResponse?> UpdateLocalizedPolicyVersion1Async(UpdateLocalizedPolicyVersion1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UploadLocalizedPolicyVersionAttachmentResponse? RequestPresignedURL1(RequestPresignedURL1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.UploadLocalizedPolicyVersionAttachmentResponse?> RequestPresignedURL1Async(RequestPresignedURL1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SetDefaultPolicy1(SetDefaultPolicy1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SetDefaultPolicy1Async(SetDefaultPolicy1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveLocalizedPolicyVersionPublicResponse? RetrieveSingleLocalizedPolicyVersion3(RetrieveSingleLocalizedPolicyVersion3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RetrieveLocalizedPolicyVersionPublicResponse?> RetrieveSingleLocalizedPolicyVersion3Async(RetrieveSingleLocalizedPolicyVersion3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}