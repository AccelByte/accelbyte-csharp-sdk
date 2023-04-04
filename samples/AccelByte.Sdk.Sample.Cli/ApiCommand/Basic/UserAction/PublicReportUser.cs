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

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic", "publicreportuser")]
    public class PublicReportUserCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Basic"; } }

        public string OperationName { get { return "PublicReportUser"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UserReportRequest Body { get; set; } = new UserReportRequest();

        public PublicReportUserCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.UserAction wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.UserAction(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Basic.Operation.PublicReportUser.Builder;


            if (Body != null)
                opBuilder.SetBody((UserReportRequest)Body);



            PublicReportUser operation = opBuilder.Build(
                Namespace,
                UserId
            );


            wrapper.PublicReportUser(operation);
            return String.Empty;
        }
    }
}