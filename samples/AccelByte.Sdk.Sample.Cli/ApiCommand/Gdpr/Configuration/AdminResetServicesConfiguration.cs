// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr", "adminresetservicesconfiguration")]
    public class AdminResetServicesConfigurationCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Gdpr"; } }

        public string OperationName { get { return "AdminResetServicesConfiguration"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminResetServicesConfigurationCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.Configuration wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.Configuration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.AdminResetServicesConfiguration.Builder;





            AdminResetServicesConfiguration operation = opBuilder.Build(
                Namespace
            );


            wrapper.AdminResetServicesConfiguration(operation);
            return String.Empty;
        }
    }
}