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

using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Reporting
{
    [SdkConsoleCommand("reporting", "publicgetreasons")]
    public class PublicGetReasonsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Reporting"; } }

        public string OperationName { get { return "PublicGetReasons"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("group")]
        public string? Group { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("title")]
        public string? Title { get; set; }

        public PublicGetReasonsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.PublicReasons wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.PublicReasons(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.PublicGetReasons.Builder;

            if (Group != null)
                opBuilder.SetGroup((string)Group);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Title != null)
                opBuilder.SetTitle((string)Title);




            PublicGetReasons operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Reporting.Model.RestapiPublicReasonListResponse? response = wrapper.PublicGetReasons(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}