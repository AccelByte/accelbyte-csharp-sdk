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
    [SdkConsoleCommand("legal", "setdefaultpolicy3")]
    public class SetDefaultPolicy3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Legal"; } }

        public string OperationName { get { return "SetDefaultPolicy3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("policyId")]
        public string PolicyId { get; set; } = String.Empty;

        public SetDefaultPolicy3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PoliciesWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PoliciesWithNamespace(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Legal.Operation.SetDefaultPolicy3.Builder;





            SetDefaultPolicy3 operation = opBuilder.Build(
                Namespace,
                PolicyId
            );


            wrapper.SetDefaultPolicy3(operation);
            return String.Empty;
        }
    }
}