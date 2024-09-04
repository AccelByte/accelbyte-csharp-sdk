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

using AccelByte.Sdk.Api.Challenge.Wrapper;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Challenge
{
    [SdkConsoleCommand("challenge", "adminupdateassignmentplugin")]
    public class AdminUpdateAssignmentPluginCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Challenge"; } }

        public string OperationName { get { return "AdminUpdateAssignmentPlugin"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelPluginAssignmentRequest Body { get; set; } = new ModelPluginAssignmentRequest();

        public AdminUpdateAssignmentPluginCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Challenge.Wrapper.Plugins wrapper = new AccelByte.Sdk.Api.Challenge.Wrapper.Plugins(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Challenge.Operation.AdminUpdateAssignmentPlugin.Builder;





            AdminUpdateAssignmentPlugin operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Challenge.Model.ModelPluginAssignmentResponse? response = wrapper.AdminUpdateAssignmentPlugin(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}