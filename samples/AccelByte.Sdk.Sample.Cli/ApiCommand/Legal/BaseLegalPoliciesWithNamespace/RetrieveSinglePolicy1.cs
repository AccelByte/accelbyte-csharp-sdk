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
    [SdkConsoleCommand("legal", "retrievesinglepolicy1")]
    public class RetrieveSinglePolicy1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "RetrieveSinglePolicy1"; } }

        [SdkCommandArgument("basePolicyId")]
        public string BasePolicyId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public RetrieveSinglePolicy1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPoliciesWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPoliciesWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RetrieveSinglePolicy1.Builder;





            RetrieveSinglePolicy1 operation = opBuilder.Build(
                BasePolicyId,
                Namespace
            );


            AccelByte.Sdk.Api.Legal.Model.RetrieveBasePolicyResponse? response = wrapper.RetrieveSinglePolicy1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}