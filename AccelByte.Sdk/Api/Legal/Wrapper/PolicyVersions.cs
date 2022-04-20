// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class PolicyVersions
    {
        private readonly AccelByteSDK _sdk;

        public PolicyVersions(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UpdatePolicyVersion.UpdatePolicyVersionBuilder UpdatePolicyVersionOp
        {
            get { return Operation.UpdatePolicyVersion.Builder.SetWrapperObject(this); }
        }
        public PublishPolicyVersion.PublishPolicyVersionBuilder PublishPolicyVersionOp
        {
            get { return Operation.PublishPolicyVersion.Builder.SetWrapperObject(this); }
        }
        public RetrieveSinglePolicyVersion.RetrieveSinglePolicyVersionBuilder RetrieveSinglePolicyVersionOp
        {
            get { return Operation.RetrieveSinglePolicyVersion.Builder.SetWrapperObject(this); }
        }
        public CreatePolicyVersion.CreatePolicyVersionBuilder CreatePolicyVersionOp
        {
            get { return Operation.CreatePolicyVersion.Builder.SetWrapperObject(this); }
        }
        public RetrievePolicyVersions.RetrievePolicyVersionsBuilder RetrievePolicyVersionsOp
        {
            get { return Operation.RetrievePolicyVersions.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.UpdatePolicyVersionResponse? UpdatePolicyVersion(UpdatePolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublishPolicyVersion(PublishPolicyVersion input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyVersionResponse>? RetrieveSinglePolicyVersion(RetrieveSinglePolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreatePolicyVersionResponse? CreatePolicyVersion(CreatePolicyVersion input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyVersionResponse>? RetrievePolicyVersions(RetrievePolicyVersions input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PolicyVersions_OperationExtensions
    {
        public static Model.UpdatePolicyVersionResponse? Execute(
            this UpdatePolicyVersion.UpdatePolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            UpdatePolicyVersion op = builder.Build(
                policyVersionId
            );

            return ((PolicyVersions)builder.WrapperObject!).UpdatePolicyVersion(op);
        }

        public static void Execute(
            this PublishPolicyVersion.PublishPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            PublishPolicyVersion op = builder.Build(
                policyVersionId
            );

            ((PolicyVersions)builder.WrapperObject!).PublishPolicyVersion(op);
        }

        public static List<Model.RetrievePolicyVersionResponse>? Execute(
            this RetrieveSinglePolicyVersion.RetrieveSinglePolicyVersionBuilder builder,
            string policyId
        )
        {
            RetrieveSinglePolicyVersion op = builder.Build(
                policyId
            );

            return ((PolicyVersions)builder.WrapperObject!).RetrieveSinglePolicyVersion(op);
        }

        public static Model.CreatePolicyVersionResponse? Execute(
            this CreatePolicyVersion.CreatePolicyVersionBuilder builder,
            string policyId
        )
        {
            CreatePolicyVersion op = builder.Build(
                policyId
            );

            return ((PolicyVersions)builder.WrapperObject!).CreatePolicyVersion(op);
        }

        public static List<Model.RetrievePolicyVersionResponse>? Execute(
            this RetrievePolicyVersions.RetrievePolicyVersionsBuilder builder
        )
        {
            RetrievePolicyVersions op = builder.Build(
            );

            return ((PolicyVersions)builder.WrapperObject!).RetrievePolicyVersions(op);
        }

    }
}