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

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass", "createpass")]
    public class CreatePassCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Seasonpass"; } }

        public string OperationName { get { return "CreatePass"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("seasonId")]
        public string SeasonId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public PassCreate Body { get; set; } = new PassCreate();

        public CreatePassCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Pass wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Pass(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Seasonpass.Operation.CreatePass.Builder;


            if (Body != null)
                opBuilder.SetBody((PassCreate)Body);



            CreatePass operation = opBuilder.Build(
                Namespace,
                SeasonId
            );


            AccelByte.Sdk.Api.Seasonpass.Model.PassInfo? response = wrapper.CreatePass(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}