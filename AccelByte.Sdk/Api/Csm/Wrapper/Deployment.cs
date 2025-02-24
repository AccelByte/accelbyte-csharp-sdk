// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Csm.Wrapper
{
    public class Deployment
    {
        private readonly AccelByteSDK _sdk;

        public Deployment(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public CreateDeploymentV1.CreateDeploymentV1Builder CreateDeploymentV1Op
        {
            get { return Operation.CreateDeploymentV1.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetListOfDeploymentV1.GetListOfDeploymentV1Builder GetListOfDeploymentV1Op
        {
            get { return Operation.GetListOfDeploymentV1.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetDeploymentV1.GetDeploymentV1Builder GetDeploymentV1Op
        {
            get { return Operation.GetDeploymentV1.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DeleteDeploymentV1.DeleteDeploymentV1Builder DeleteDeploymentV1Op
        {
            get { return Operation.DeleteDeploymentV1.Builder.SetWrapperObject(this); }
        }
        #endregion

#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.GeneratedCreateDeploymentV1Response? CreateDeploymentV1(CreateDeploymentV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.GeneratedCreateDeploymentV1Response?> CreateDeploymentV1Async(CreateDeploymentV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.GeneratedGetDeploymentListV1Response? GetListOfDeploymentV1(GetListOfDeploymentV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.GeneratedGetDeploymentListV1Response?> GetListOfDeploymentV1Async(GetListOfDeploymentV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.GeneratedGetDeploymentV1Response? GetDeploymentV1(GetDeploymentV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.GeneratedGetDeploymentV1Response?> GetDeploymentV1Async(GetDeploymentV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void DeleteDeploymentV1(DeleteDeploymentV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteDeploymentV1Async(DeleteDeploymentV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
    }
}