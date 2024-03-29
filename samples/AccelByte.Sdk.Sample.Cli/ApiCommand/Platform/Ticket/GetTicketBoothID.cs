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

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform", "getticketboothid")]
    public class GetTicketBoothIDCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "GetTicketBoothID"; } }

        [SdkCommandArgument("boothName")]
        public string BoothName { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetTicketBoothIDCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Ticket wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Ticket(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetTicketBoothID.Builder;





            GetTicketBoothID operation = opBuilder.Build(
                BoothName,
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.TicketBoothID? response = wrapper.GetTicketBoothID(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}