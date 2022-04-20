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

    public static class ThirdPartyCredential_OperationExtensions
    {
        public static List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? Execute(
            this RetrieveAllThirdPartyLoginPlatformCredentialV3.RetrieveAllThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_
        )
        {
            RetrieveAllThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                namespace_
            );

            return ((ThirdPartyCredential)builder.WrapperObject!).RetrieveAllThirdPartyLoginPlatformCredentialV3(op);
        }

        public static List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? Execute(
            this RetrieveAllActiveThirdPartyLoginPlatformCredentialV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_
        )
        {
            RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                namespace_
            );

            return ((ThirdPartyCredential)builder.WrapperObject!).RetrieveAllActiveThirdPartyLoginPlatformCredentialV3(op);
        }

        public static Model.ModelThirdPartyLoginPlatformCredentialResponse? Execute(
            this RetrieveThirdPartyLoginPlatformCredentialV3.RetrieveThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            RetrieveThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                namespace_,
                platformId
            );

            return ((ThirdPartyCredential)builder.WrapperObject!).RetrieveThirdPartyLoginPlatformCredentialV3(op);
        }

        public static Model.ModelThirdPartyLoginPlatformCredentialResponse? Execute(
            this AddThirdPartyLoginPlatformCredentialV3.AddThirdPartyLoginPlatformCredentialV3Builder builder,
            ModelThirdPartyLoginPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            AddThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            return ((ThirdPartyCredential)builder.WrapperObject!).AddThirdPartyLoginPlatformCredentialV3(op);
        }

        public static void Execute(
            this DeleteThirdPartyLoginPlatformCredentialV3.DeleteThirdPartyLoginPlatformCredentialV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            DeleteThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                namespace_,
                platformId
            );

            ((ThirdPartyCredential)builder.WrapperObject!).DeleteThirdPartyLoginPlatformCredentialV3(op);
        }

        public static Model.ModelThirdPartyLoginPlatformCredentialResponse? Execute(
            this UpdateThirdPartyLoginPlatformCredentialV3.UpdateThirdPartyLoginPlatformCredentialV3Builder builder,
            ModelThirdPartyLoginPlatformCredentialRequest body,
            string namespace_,
            string platformId
        )
        {
            UpdateThirdPartyLoginPlatformCredentialV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            return ((ThirdPartyCredential)builder.WrapperObject!).UpdateThirdPartyLoginPlatformCredentialV3(op);
        }

        public static Model.ModelPlatformDomainResponse? Execute(
            this UpdateThirdPartyLoginPlatformDomainV3.UpdateThirdPartyLoginPlatformDomainV3Builder builder,
            ModelPlatformDomainUpdateRequest body,
            string namespace_,
            string platformId
        )
        {
            UpdateThirdPartyLoginPlatformDomainV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            return ((ThirdPartyCredential)builder.WrapperObject!).UpdateThirdPartyLoginPlatformDomainV3(op);
        }

        public static void Execute(
            this DeleteThirdPartyLoginPlatformDomainV3.DeleteThirdPartyLoginPlatformDomainV3Builder builder,
            ModelPlatformDomainDeleteRequest body,
            string namespace_,
            string platformId
        )
        {
            DeleteThirdPartyLoginPlatformDomainV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            ((ThirdPartyCredential)builder.WrapperObject!).DeleteThirdPartyLoginPlatformDomainV3(op);
        }

        public static List<Model.ModelPublicThirdPartyPlatformInfo>? Execute(
            this RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder builder,
            string namespace_
        )
        {
            RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 op = builder.Build(
                namespace_
            );

            return ((ThirdPartyCredential)builder.WrapperObject!).RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(op);
        }

    }
}