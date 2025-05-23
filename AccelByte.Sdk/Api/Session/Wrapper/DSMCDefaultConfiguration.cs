// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class DSMCDefaultConfiguration
    {
        private readonly AccelByteSDK _sdk;

        public DSMCDefaultConfiguration(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminGetDSMCConfigurationDefault.AdminGetDSMCConfigurationDefaultBuilder AdminGetDSMCConfigurationDefaultOp
        {
            get { return Operation.AdminGetDSMCConfigurationDefault.Builder.SetWrapperObject(this); }
        }
        #endregion

#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelsDefaultDSMCConfig? AdminGetDSMCConfigurationDefault(AdminGetDSMCConfigurationDefault input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDefaultDSMCConfig?> AdminGetDSMCConfigurationDefaultAsync(AdminGetDSMCConfigurationDefault input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
    }
}