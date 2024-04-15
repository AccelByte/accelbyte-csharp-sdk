// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Inventory.Wrapper
{
    public class AdminIntegrationConfigurations
    {
        private readonly AccelByteSDK _sdk;

        public AdminIntegrationConfigurations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListIntegrationConfigurations.AdminListIntegrationConfigurationsBuilder AdminListIntegrationConfigurationsOp
        {
            get { return Operation.AdminListIntegrationConfigurations.Builder.SetWrapperObject(this); }
        }
        public AdminCreateIntegrationConfiguration.AdminCreateIntegrationConfigurationBuilder AdminCreateIntegrationConfigurationOp
        {
            get { return Operation.AdminCreateIntegrationConfiguration.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateIntegrationConfiguration.AdminUpdateIntegrationConfigurationBuilder AdminUpdateIntegrationConfigurationOp
        {
            get { return Operation.AdminUpdateIntegrationConfiguration.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateStatusIntegrationConfiguration.AdminUpdateStatusIntegrationConfigurationBuilder AdminUpdateStatusIntegrationConfigurationOp
        {
            get { return Operation.AdminUpdateStatusIntegrationConfiguration.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApimodelsListIntegrationConfigurationsResp? AdminListIntegrationConfigurations(AdminListIntegrationConfigurations input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsListIntegrationConfigurationsResp?> AdminListIntegrationConfigurationsAsync(AdminListIntegrationConfigurations input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsIntegrationConfigurationResp? AdminCreateIntegrationConfiguration(AdminCreateIntegrationConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsIntegrationConfigurationResp?> AdminCreateIntegrationConfigurationAsync(AdminCreateIntegrationConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsIntegrationConfigurationResp? AdminUpdateIntegrationConfiguration(AdminUpdateIntegrationConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsIntegrationConfigurationResp?> AdminUpdateIntegrationConfigurationAsync(AdminUpdateIntegrationConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsIntegrationConfigurationResp? AdminUpdateStatusIntegrationConfiguration(AdminUpdateStatusIntegrationConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsIntegrationConfigurationResp?> AdminUpdateStatusIntegrationConfigurationAsync(AdminUpdateStatusIntegrationConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}