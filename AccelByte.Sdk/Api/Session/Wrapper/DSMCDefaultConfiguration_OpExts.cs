// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SessionDSMCDefaultConfiguration_OpExts
    {
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Session.Model.ModelsDefaultDSMCConfig? Execute(
            this AdminGetDSMCConfigurationDefault.AdminGetDSMCConfigurationDefaultBuilder builder
        )
        {
            AdminGetDSMCConfigurationDefault op = builder.Build(
            );

            return ((Session.Wrapper.DSMCDefaultConfiguration)builder.WrapperObject!).AdminGetDSMCConfigurationDefault(op);
        }
        public static async Task<Session.Model.ModelsDefaultDSMCConfig?> ExecuteAsync(
            this AdminGetDSMCConfigurationDefault.AdminGetDSMCConfigurationDefaultBuilder builder
        )
        {
            AdminGetDSMCConfigurationDefault op = builder.Build(
            );

            return await ((Session.Wrapper.DSMCDefaultConfiguration)builder.WrapperObject!).AdminGetDSMCConfigurationDefaultAsync(op);
        }
    }
}