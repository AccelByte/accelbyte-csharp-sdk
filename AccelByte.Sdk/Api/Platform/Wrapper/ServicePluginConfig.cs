// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class ServicePluginConfig
    {
        private readonly AccelByteSDK _sdk;

        public ServicePluginConfig(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetLootBoxPluginConfig.GetLootBoxPluginConfigBuilder GetLootBoxPluginConfigOp
        {
            get { return Operation.GetLootBoxPluginConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateLootBoxPluginConfig.UpdateLootBoxPluginConfigBuilder UpdateLootBoxPluginConfigOp
        {
            get { return Operation.UpdateLootBoxPluginConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteLootBoxPluginConfig.DeleteLootBoxPluginConfigBuilder DeleteLootBoxPluginConfigOp
        {
            get { return Operation.DeleteLootBoxPluginConfig.Builder.SetWrapperObject(this); }
        }
        public UplodLootBoxPluginConfigCert.UplodLootBoxPluginConfigCertBuilder UplodLootBoxPluginConfigCertOp
        {
            get { return Operation.UplodLootBoxPluginConfigCert.Builder.SetWrapperObject(this); }
        }
        public GetLootBoxGrpcInfo.GetLootBoxGrpcInfoBuilder GetLootBoxGrpcInfoOp
        {
            get { return Operation.GetLootBoxGrpcInfo.Builder.SetWrapperObject(this); }
        }
        public GetSectionPluginConfig.GetSectionPluginConfigBuilder GetSectionPluginConfigOp
        {
            get { return Operation.GetSectionPluginConfig.Builder.SetWrapperObject(this); }
        }
        public UpdateSectionPluginConfig.UpdateSectionPluginConfigBuilder UpdateSectionPluginConfigOp
        {
            get { return Operation.UpdateSectionPluginConfig.Builder.SetWrapperObject(this); }
        }
        public DeleteSectionPluginConfig.DeleteSectionPluginConfigBuilder DeleteSectionPluginConfigOp
        {
            get { return Operation.DeleteSectionPluginConfig.Builder.SetWrapperObject(this); }
        }
        public UploadSectionPluginConfigCert.UploadSectionPluginConfigCertBuilder UploadSectionPluginConfigCertOp
        {
            get { return Operation.UploadSectionPluginConfigCert.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetServicePluginConfig.GetServicePluginConfigBuilder GetServicePluginConfigOp
        {
            get { return Operation.GetServicePluginConfig.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public UpdateServicePluginConfig.UpdateServicePluginConfigBuilder UpdateServicePluginConfigOp
        {
            get { return Operation.UpdateServicePluginConfig.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DeleteServicePluginConfig.DeleteServicePluginConfigBuilder DeleteServicePluginConfigOp
        {
            get { return Operation.DeleteServicePluginConfig.Builder.SetWrapperObject(this); }
        }
        public GetLootBoxPluginConfig1.GetLootBoxPluginConfig1Builder GetLootBoxPluginConfig1Op
        {
            get { return Operation.GetLootBoxPluginConfig1.Builder.SetWrapperObject(this); }
        }
        public UpdateLootBoxPluginConfig1.UpdateLootBoxPluginConfig1Builder UpdateLootBoxPluginConfig1Op
        {
            get { return Operation.UpdateLootBoxPluginConfig1.Builder.SetWrapperObject(this); }
        }
        public DeleteLootBoxPluginConfig1.DeleteLootBoxPluginConfig1Builder DeleteLootBoxPluginConfig1Op
        {
            get { return Operation.DeleteLootBoxPluginConfig1.Builder.SetWrapperObject(this); }
        }
        public UploadRevocationPluginConfigCert.UploadRevocationPluginConfigCertBuilder UploadRevocationPluginConfigCertOp
        {
            get { return Operation.UploadRevocationPluginConfigCert.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.LootBoxPluginConfigInfo? GetLootBoxPluginConfig(GetLootBoxPluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.LootBoxPluginConfigInfo? UpdateLootBoxPluginConfig(UpdateLootBoxPluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteLootBoxPluginConfig(DeleteLootBoxPluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.LootBoxPluginConfigInfo? UplodLootBoxPluginConfigCert(UplodLootBoxPluginConfigCert input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GrpcServerInfo? GetLootBoxGrpcInfo(GetLootBoxGrpcInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SectionPluginConfigInfo? GetSectionPluginConfig(GetSectionPluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SectionPluginConfigInfo? UpdateSectionPluginConfig(UpdateSectionPluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSectionPluginConfig(DeleteSectionPluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.SectionPluginConfigInfo? UploadSectionPluginConfigCert(UploadSectionPluginConfigCert input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ServicePluginConfigInfo? GetServicePluginConfig(GetServicePluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ServicePluginConfigInfo? UpdateServicePluginConfig(UpdateServicePluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void DeleteServicePluginConfig(DeleteServicePluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public Model.RevocationPluginConfigInfo? GetLootBoxPluginConfig1(GetLootBoxPluginConfig1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RevocationPluginConfigInfo? UpdateLootBoxPluginConfig1(UpdateLootBoxPluginConfig1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteLootBoxPluginConfig1(DeleteLootBoxPluginConfig1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RevocationPluginConfigInfo? UploadRevocationPluginConfigCert(UploadRevocationPluginConfigCert input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}