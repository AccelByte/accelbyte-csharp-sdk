// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class ThirdPartyCredential
    {
        private readonly AccelByteSDK _sdk;

        public ThirdPartyCredential(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveAllThirdPartyLoginPlatformCredentialV3.RetrieveAllThirdPartyLoginPlatformCredentialV3Builder RetrieveAllThirdPartyLoginPlatformCredentialV3Op
        {
            get { return Operation.RetrieveAllThirdPartyLoginPlatformCredentialV3.Builder.SetWrapperObject(this); }
        }
        public RetrieveAllActiveThirdPartyLoginPlatformCredentialV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Op
        {
            get { return Operation.RetrieveAllActiveThirdPartyLoginPlatformCredentialV3.Builder.SetWrapperObject(this); }
        }
        public RetrieveThirdPartyLoginPlatformCredentialV3.RetrieveThirdPartyLoginPlatformCredentialV3Builder RetrieveThirdPartyLoginPlatformCredentialV3Op
        {
            get { return Operation.RetrieveThirdPartyLoginPlatformCredentialV3.Builder.SetWrapperObject(this); }
        }
        public AddThirdPartyLoginPlatformCredentialV3.AddThirdPartyLoginPlatformCredentialV3Builder AddThirdPartyLoginPlatformCredentialV3Op
        {
            get { return Operation.AddThirdPartyLoginPlatformCredentialV3.Builder.SetWrapperObject(this); }
        }
        public DeleteThirdPartyLoginPlatformCredentialV3.DeleteThirdPartyLoginPlatformCredentialV3Builder DeleteThirdPartyLoginPlatformCredentialV3Op
        {
            get { return Operation.DeleteThirdPartyLoginPlatformCredentialV3.Builder.SetWrapperObject(this); }
        }
        public UpdateThirdPartyLoginPlatformCredentialV3.UpdateThirdPartyLoginPlatformCredentialV3Builder UpdateThirdPartyLoginPlatformCredentialV3Op
        {
            get { return Operation.UpdateThirdPartyLoginPlatformCredentialV3.Builder.SetWrapperObject(this); }
        }
        public UpdateThirdPartyLoginPlatformDomainV3.UpdateThirdPartyLoginPlatformDomainV3Builder UpdateThirdPartyLoginPlatformDomainV3Op
        {
            get { return Operation.UpdateThirdPartyLoginPlatformDomainV3.Builder.SetWrapperObject(this); }
        }
        public DeleteThirdPartyLoginPlatformDomainV3.DeleteThirdPartyLoginPlatformDomainV3Builder DeleteThirdPartyLoginPlatformDomainV3Op
        {
            get { return Operation.DeleteThirdPartyLoginPlatformDomainV3.Builder.SetWrapperObject(this); }
        }
        public RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Op
        {
            get { return Operation.RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? RetrieveAllThirdPartyLoginPlatformCredentialV3(RetrieveAllThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? RetrieveAllActiveThirdPartyLoginPlatformCredentialV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? RetrieveThirdPartyLoginPlatformCredentialV3(RetrieveThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? AddThirdPartyLoginPlatformCredentialV3(AddThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteThirdPartyLoginPlatformCredentialV3(DeleteThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? UpdateThirdPartyLoginPlatformCredentialV3(UpdateThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelPlatformDomainResponse? UpdateThirdPartyLoginPlatformDomainV3(UpdateThirdPartyLoginPlatformDomainV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteThirdPartyLoginPlatformDomainV3(DeleteThirdPartyLoginPlatformDomainV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelPublicThirdPartyPlatformInfo>? RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}