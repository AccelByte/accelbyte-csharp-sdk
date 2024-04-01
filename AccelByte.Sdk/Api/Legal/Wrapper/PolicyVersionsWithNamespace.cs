// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class PolicyVersionsWithNamespace
    {
        private readonly AccelByteSDK _sdk;

        public PolicyVersionsWithNamespace(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UpdatePolicyVersion1.UpdatePolicyVersion1Builder UpdatePolicyVersion1Op
        {
            get { return Operation.UpdatePolicyVersion1.Builder.SetWrapperObject(this); }
        }
        public PublishPolicyVersion1.PublishPolicyVersion1Builder PublishPolicyVersion1Op
        {
            get { return Operation.PublishPolicyVersion1.Builder.SetWrapperObject(this); }
        }
        public RetrieveSinglePolicyVersion1.RetrieveSinglePolicyVersion1Builder RetrieveSinglePolicyVersion1Op
        {
            get { return Operation.RetrieveSinglePolicyVersion1.Builder.SetWrapperObject(this); }
        }
        public CreatePolicyVersion1.CreatePolicyVersion1Builder CreatePolicyVersion1Op
        {
            get { return Operation.CreatePolicyVersion1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.UpdatePolicyVersionResponse? UpdatePolicyVersion1(UpdatePolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.UpdatePolicyVersionResponse?> UpdatePolicyVersion1Async(UpdatePolicyVersion1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublishPolicyVersion1(PublishPolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task PublishPolicyVersion1Async(PublishPolicyVersion1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyVersionResponse>? RetrieveSinglePolicyVersion1(RetrieveSinglePolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrievePolicyVersionResponse>?> RetrieveSinglePolicyVersion1Async(RetrieveSinglePolicyVersion1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreatePolicyVersionResponse? CreatePolicyVersion1(CreatePolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CreatePolicyVersionResponse?> CreatePolicyVersion1Async(CreatePolicyVersion1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}