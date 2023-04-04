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

using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Match2
{
    [SdkConsoleCommand("match2", "gethealthcheckinfo")]
    public class GetHealthcheckInfoCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Match2"; } }

        public string OperationName { get { return "GetHealthcheckInfo"; } }

        public GetHealthcheckInfoCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.Operations wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.Operations(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Match2.Operation.GetHealthcheckInfo.Builder;





            GetHealthcheckInfo operation = opBuilder.Build(
            );


            wrapper.GetHealthcheckInfo(operation);
            return String.Empty;
        }
    }
}