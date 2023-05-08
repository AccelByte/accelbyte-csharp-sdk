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

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal", "createpolicy")]
    public class CreatePolicyCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "CreatePolicy"; } }

        [SdkCommandData("body")]
        public CreateBasePolicyRequest Body { get; set; } = new CreateBasePolicyRequest();

        public CreatePolicyCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPolicies wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPolicies(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.CreatePolicy.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Legal.Model.CreateBasePolicyRequest)Body);



            CreatePolicy operation = opBuilder.Build(
            );


            AccelByte.Sdk.Api.Legal.Model.CreateBasePolicyResponse? response = wrapper.CreatePolicy(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}