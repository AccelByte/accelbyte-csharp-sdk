// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
        public AdminGetPlatformAccountClosureServicesConfiguration.AdminGetPlatformAccountClosureServicesConfigurationBuilder AdminGetPlatformAccountClosureServicesConfigurationOp
        {
            get { return Operation.AdminGetPlatformAccountClosureServicesConfiguration.Builder.SetWrapperObject(this); }
        }
        public AdminUpdatePlatformAccountClosureServicesConfiguration.AdminUpdatePlatformAccountClosureServicesConfigurationBuilder AdminUpdatePlatformAccountClosureServicesConfigurationOp
        {
            get { return Operation.AdminUpdatePlatformAccountClosureServicesConfiguration.Builder.SetWrapperObject(this); }
        }
        public AdminResetPlatformAccountClosureServicesConfiguration.AdminResetPlatformAccountClosureServicesConfigurationBuilder AdminResetPlatformAccountClosureServicesConfigurationOp
        {
            get { return Operation.AdminResetPlatformAccountClosureServicesConfiguration.Builder.SetWrapperObject(this); }
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
        public async Task<List<string>?> GetAdminEmailConfigurationAsync(GetAdminEmailConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task UpdateAdminEmailConfigurationAsync(UpdateAdminEmailConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task SaveAdminEmailConfigurationAsync(SaveAdminEmailConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task DeleteAdminEmailConfigurationAsync(DeleteAdminEmailConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.DtoServicesConfigurationResponse?> AdminGetServicesConfigurationAsync(AdminGetServicesConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.DtoServiceConfigurationUpdateRequest?> AdminUpdateServicesConfigurationAsync(AdminUpdateServicesConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task AdminResetServicesConfigurationAsync(AdminResetServicesConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.DtoServicesConfigurationResponse? AdminGetPlatformAccountClosureServicesConfiguration(AdminGetPlatformAccountClosureServicesConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DtoServicesConfigurationResponse?> AdminGetPlatformAccountClosureServicesConfigurationAsync(AdminGetPlatformAccountClosureServicesConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.DtoServiceConfigurationUpdateRequest? AdminUpdatePlatformAccountClosureServicesConfiguration(AdminUpdatePlatformAccountClosureServicesConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.DtoServiceConfigurationUpdateRequest?> AdminUpdatePlatformAccountClosureServicesConfigurationAsync(AdminUpdatePlatformAccountClosureServicesConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminResetPlatformAccountClosureServicesConfiguration(AdminResetPlatformAccountClosureServicesConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminResetPlatformAccountClosureServicesConfigurationAsync(AdminResetPlatformAccountClosureServicesConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}