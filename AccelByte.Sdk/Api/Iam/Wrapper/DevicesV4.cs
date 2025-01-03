// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class DevicesV4
    {
        private readonly AccelByteSDK _sdk;

        public DevicesV4(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetDevicesByUserV4.AdminGetDevicesByUserV4Builder AdminGetDevicesByUserV4Op
        {
            get { return Operation.AdminGetDevicesByUserV4.Builder.SetWrapperObject(this); }
        }
        public AdminGetBannedDevicesV4.AdminGetBannedDevicesV4Builder AdminGetBannedDevicesV4Op
        {
            get { return Operation.AdminGetBannedDevicesV4.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserDeviceBansV4.AdminGetUserDeviceBansV4Builder AdminGetUserDeviceBansV4Op
        {
            get { return Operation.AdminGetUserDeviceBansV4.Builder.SetWrapperObject(this); }
        }
        public AdminBanDeviceV4.AdminBanDeviceV4Builder AdminBanDeviceV4Op
        {
            get { return Operation.AdminBanDeviceV4.Builder.SetWrapperObject(this); }
        }
        public AdminGetDeviceBanV4.AdminGetDeviceBanV4Builder AdminGetDeviceBanV4Op
        {
            get { return Operation.AdminGetDeviceBanV4.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateDeviceBanV4.AdminUpdateDeviceBanV4Builder AdminUpdateDeviceBanV4Op
        {
            get { return Operation.AdminUpdateDeviceBanV4.Builder.SetWrapperObject(this); }
        }
        public AdminGenerateReportV4.AdminGenerateReportV4Builder AdminGenerateReportV4Op
        {
            get { return Operation.AdminGenerateReportV4.Builder.SetWrapperObject(this); }
        }
        public AdminGetDeviceTypesV4.AdminGetDeviceTypesV4Builder AdminGetDeviceTypesV4Op
        {
            get { return Operation.AdminGetDeviceTypesV4.Builder.SetWrapperObject(this); }
        }
        public AdminGetDeviceBansV4.AdminGetDeviceBansV4Builder AdminGetDeviceBansV4Op
        {
            get { return Operation.AdminGetDeviceBansV4.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminDecryptDeviceV4.AdminDecryptDeviceV4Builder AdminDecryptDeviceV4Op
        {
            get { return Operation.AdminDecryptDeviceV4.Builder.SetWrapperObject(this); }
        }
        public AdminUnbanDeviceV4.AdminUnbanDeviceV4Builder AdminUnbanDeviceV4Op
        {
            get { return Operation.AdminUnbanDeviceV4.Builder.SetWrapperObject(this); }
        }
        public AdminGetUsersByDeviceV4.AdminGetUsersByDeviceV4Builder AdminGetUsersByDeviceV4Op
        {
            get { return Operation.AdminGetUsersByDeviceV4.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelDevicesResponseV4? AdminGetDevicesByUserV4(AdminGetDevicesByUserV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelDevicesResponseV4?> AdminGetDevicesByUserV4Async(AdminGetDevicesByUserV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelDeviceBannedResponseV4? AdminGetBannedDevicesV4(AdminGetBannedDevicesV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelDeviceBannedResponseV4?> AdminGetBannedDevicesV4Async(AdminGetBannedDevicesV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelDeviceBansResponseV4? AdminGetUserDeviceBansV4(AdminGetUserDeviceBansV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelDeviceBansResponseV4?> AdminGetUserDeviceBansV4Async(AdminGetUserDeviceBansV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminBanDeviceV4(AdminBanDeviceV4 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminBanDeviceV4Async(AdminBanDeviceV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelDeviceBanResponseV4? AdminGetDeviceBanV4(AdminGetDeviceBanV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelDeviceBanResponseV4?> AdminGetDeviceBanV4Async(AdminGetDeviceBanV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateDeviceBanV4(AdminUpdateDeviceBanV4 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminUpdateDeviceBanV4Async(AdminUpdateDeviceBanV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminGenerateReportV4(AdminGenerateReportV4 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminGenerateReportV4Async(AdminGenerateReportV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelDeviceTypesResponseV4? AdminGetDeviceTypesV4(AdminGetDeviceTypesV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelDeviceTypesResponseV4?> AdminGetDeviceTypesV4Async(AdminGetDeviceTypesV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelDeviceBansResponseV4? AdminGetDeviceBansV4(AdminGetDeviceBansV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelDeviceBansResponseV4?> AdminGetDeviceBansV4Async(AdminGetDeviceBansV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelDeviceIDDecryptResponseV4? AdminDecryptDeviceV4(AdminDecryptDeviceV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelDeviceIDDecryptResponseV4?> AdminDecryptDeviceV4Async(AdminDecryptDeviceV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public void AdminUnbanDeviceV4(AdminUnbanDeviceV4 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminUnbanDeviceV4Async(AdminUnbanDeviceV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelDeviceUsersResponseV4? AdminGetUsersByDeviceV4(AdminGetUsersByDeviceV4 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelDeviceUsersResponseV4?> AdminGetUsersByDeviceV4Async(AdminGetUsersByDeviceV4 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}