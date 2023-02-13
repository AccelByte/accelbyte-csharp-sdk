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
    [SdkConsoleCommand("reporting", "submitreport")]
    public class SubmitReportCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Reporting"; } }

        public string OperationName { get { return "SubmitReport"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public RestapiSubmitReportRequest Body { get; set; } = new RestapiSubmitReportRequest();

        public SubmitReportCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.PublicReports wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.PublicReports(_SDK);

            SubmitReport operation = new SubmitReport(
                Namespace,
                Body
            );

            AccelByte.Sdk.Api.Reporting.Model.RestapiSubmitReportResponse? response = wrapper.SubmitReport(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}