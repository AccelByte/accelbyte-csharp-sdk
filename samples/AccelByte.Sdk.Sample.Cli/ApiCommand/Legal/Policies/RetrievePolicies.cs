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
    [SdkConsoleCommand("legal", "retrievepolicies")]
    public class RetrievePoliciesCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "RetrievePolicies"; } }

        [SdkCommandArgument("countryCode")]
        public string CountryCode { get; set; } = String.Empty;

        public RetrievePoliciesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Policies wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Policies(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.RetrievePolicies.Builder;





            RetrievePolicies operation = opBuilder.Build(
                CountryCode
            );


            List<AccelByte.Sdk.Api.Legal.Model.RetrievePolicyResponse>? response = wrapper.RetrievePolicies(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}