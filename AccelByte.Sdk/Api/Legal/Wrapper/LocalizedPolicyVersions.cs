// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class LocalizedPolicyVersions
    {
        private readonly AccelByteSDK _sdk;

        public LocalizedPolicyVersions(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveLocalizedPolicyVersions.RetrieveLocalizedPolicyVersionsBuilder RetrieveLocalizedPolicyVersionsOp
        {
            get { return Operation.RetrieveLocalizedPolicyVersions.Builder.SetWrapperObject(this); }
        }
        public CreateLocalizedPolicyVersion.CreateLocalizedPolicyVersionBuilder CreateLocalizedPolicyVersionOp
        {
            get { return Operation.CreateLocalizedPolicyVersion.Builder.SetWrapperObject(this); }
        }
        public RetrieveSingleLocalizedPolicyVersion.RetrieveSingleLocalizedPolicyVersionBuilder RetrieveSingleLocalizedPolicyVersionOp
        {
            get { return Operation.RetrieveSingleLocalizedPolicyVersion.Builder.SetWrapperObject(this); }
        }
        public UpdateLocalizedPolicyVersion.UpdateLocalizedPolicyVersionBuilder UpdateLocalizedPolicyVersionOp
        {
            get { return Operation.UpdateLocalizedPolicyVersion.Builder.SetWrapperObject(this); }
        }
        public RequestPresignedURL.RequestPresignedURLBuilder RequestPresignedURLOp
        {
            get { return Operation.RequestPresignedURL.Builder.SetWrapperObject(this); }
        }
        public SetDefaultPolicy.SetDefaultPolicyBuilder SetDefaultPolicyOp
        {
            get { return Operation.SetDefaultPolicy.Builder.SetWrapperObject(this); }
        }
        public RetrieveSingleLocalizedPolicyVersion1.RetrieveSingleLocalizedPolicyVersion1Builder RetrieveSingleLocalizedPolicyVersion1Op
        {
            get { return Operation.RetrieveSingleLocalizedPolicyVersion1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.RetrieveLocalizedPolicyVersionResponse>? RetrieveLocalizedPolicyVersions(RetrieveLocalizedPolicyVersions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreateLocalizedPolicyVersionResponse? CreateLocalizedPolicyVersion(CreateLocalizedPolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UpdateLocalizedPolicyVersionResponse? RetrieveSingleLocalizedPolicyVersion(RetrieveSingleLocalizedPolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UpdateLocalizedPolicyVersionResponse? UpdateLocalizedPolicyVersion(UpdateLocalizedPolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UploadLocalizedPolicyVersionAttachmentResponse? RequestPresignedURL(RequestPresignedURL input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SetDefaultPolicy(SetDefaultPolicy input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveLocalizedPolicyVersionPublicResponse? RetrieveSingleLocalizedPolicyVersion1(RetrieveSingleLocalizedPolicyVersion1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class LocalizedPolicyVersions_OperationExtensions
    {
        public static List<Model.RetrieveLocalizedPolicyVersionResponse>? Execute(
            this RetrieveLocalizedPolicyVersions.RetrieveLocalizedPolicyVersionsBuilder builder,
            string policyVersionId
        )
        {
            RetrieveLocalizedPolicyVersions op = builder.Build(
                policyVersionId
            );

            return ((LocalizedPolicyVersions)builder.WrapperObject!).RetrieveLocalizedPolicyVersions(op);
        }

        public static Model.CreateLocalizedPolicyVersionResponse? Execute(
            this CreateLocalizedPolicyVersion.CreateLocalizedPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            CreateLocalizedPolicyVersion op = builder.Build(
                policyVersionId
            );

            return ((LocalizedPolicyVersions)builder.WrapperObject!).CreateLocalizedPolicyVersion(op);
        }

        public static Model.UpdateLocalizedPolicyVersionResponse? Execute(
            this RetrieveSingleLocalizedPolicyVersion.RetrieveSingleLocalizedPolicyVersionBuilder builder,
            string localizedPolicyVersionId
        )
        {
            RetrieveSingleLocalizedPolicyVersion op = builder.Build(
                localizedPolicyVersionId
            );

            return ((LocalizedPolicyVersions)builder.WrapperObject!).RetrieveSingleLocalizedPolicyVersion(op);
        }

        public static Model.UpdateLocalizedPolicyVersionResponse? Execute(
            this UpdateLocalizedPolicyVersion.UpdateLocalizedPolicyVersionBuilder builder,
            string localizedPolicyVersionId
        )
        {
            UpdateLocalizedPolicyVersion op = builder.Build(
                localizedPolicyVersionId
            );

            return ((LocalizedPolicyVersions)builder.WrapperObject!).UpdateLocalizedPolicyVersion(op);
        }

        public static Model.UploadLocalizedPolicyVersionAttachmentResponse? Execute(
            this RequestPresignedURL.RequestPresignedURLBuilder builder,
            string localizedPolicyVersionId
        )
        {
            RequestPresignedURL op = builder.Build(
                localizedPolicyVersionId
            );

            return ((LocalizedPolicyVersions)builder.WrapperObject!).RequestPresignedURL(op);
        }

        public static void Execute(
            this SetDefaultPolicy.SetDefaultPolicyBuilder builder,
            string localizedPolicyVersionId
        )
        {
            SetDefaultPolicy op = builder.Build(
                localizedPolicyVersionId
            );

            ((LocalizedPolicyVersions)builder.WrapperObject!).SetDefaultPolicy(op);
        }

        public static Model.RetrieveLocalizedPolicyVersionPublicResponse? Execute(
            this RetrieveSingleLocalizedPolicyVersion1.RetrieveSingleLocalizedPolicyVersion1Builder builder,
            string localizedPolicyVersionId
        )
        {
            RetrieveSingleLocalizedPolicyVersion1 op = builder.Build(
                localizedPolicyVersionId
            );

            return ((LocalizedPolicyVersions)builder.WrapperObject!).RetrieveSingleLocalizedPolicyVersion1(op);
        }

    }
}