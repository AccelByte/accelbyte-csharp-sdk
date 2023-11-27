// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Gdpr.Wrapper
{
    public class Configuration
    {
        private readonly AccelByteSDK _sdk;

        public Configuration(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetAdminEmailConfiguration.GetAdminEmailConfigurationBuilder GetAdminEmailConfigurationOp
        {
            get { return Operation.GetAdminEmailConfiguration.Builder.SetWrapperObject(this); }
        }
        public UpdateAdminEmailConfiguration.UpdateAdminEmailConfigurationBuilder UpdateAdminEmailConfigurationOp
        {
            get { return Operation.UpdateAdminEmailConfiguration.Builder.SetWrapperObject(this); }
        }
        public SaveAdminEmailConfiguration.SaveAdminEmailConfigurationBuilder SaveAdminEmailConfigurationOp
        {
            get { return Operation.SaveAdminEmailConfiguration.Builder.SetWrapperObject(this); }
        }
        public DeleteAdminEmailConfiguration.DeleteAdminEmailConfigurationBuilder DeleteAdminEmailConfigurationOp
        {
            get { return Operation.DeleteAdminEmailConfiguration.Builder.SetWrapperObject(this); }
        }
        public AdminGetServicesConfiguration.AdminGetServicesConfigurationBuilder AdminGetServicesConfigurationOp
        {
            get { return Operation.AdminGetServicesConfiguration.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateServicesConfiguration.AdminUpdateServicesConfigurationBuilder AdminUpdateServicesConfigurationOp
        {
            get { return Operation.AdminUpdateServicesConfiguration.Builder.SetWrapperObject(this); }
        }
        public AdminResetServicesConfiguration.AdminResetServicesConfigurationBuilder AdminResetServicesConfigurationOp
        {
            get { return Operation.AdminResetServicesConfiguration.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<string>? GetAdminEmailConfiguration(GetAdminEmailConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateAdminEmailConfiguration(UpdateAdminEmailConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SaveAdminEmailConfiguration(SaveAdminEmailConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAdminEmailConfiguration(DeleteAdminEmailConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.DtoServicesConfigurationResponse? AdminGetServicesConfiguration(AdminGetServicesConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.DtoServiceConfigurationUpdateRequest? AdminUpdateServicesConfiguration(AdminUpdateServicesConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminResetServicesConfiguration(AdminResetServicesConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}