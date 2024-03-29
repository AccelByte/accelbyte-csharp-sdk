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

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social", "getstatcycle1")]
    public class GetStatCycle1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "GetStatCycle1"; } }

        [SdkCommandArgument("cycleId")]
        public string CycleId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetStatCycle1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.StatCycleConfiguration wrapper = new AccelByte.Sdk.Api.Social.Wrapper.StatCycleConfiguration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.GetStatCycle1.Builder;





            GetStatCycle1 operation = opBuilder.Build(
                CycleId,
                Namespace
            );


            AccelByte.Sdk.Api.Social.Model.StatCycleInfo? response = wrapper.GetStatCycle1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}