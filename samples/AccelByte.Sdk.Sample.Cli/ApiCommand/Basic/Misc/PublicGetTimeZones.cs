// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","publicgettimezones")]
    public class PublicGetTimeZonesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "PublicGetTimeZones"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public PublicGetTimeZonesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Misc wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Misc(_SDK);

            PublicGetTimeZones operation = new PublicGetTimeZones(
                Namespace                
            );            
            
            List<string>? response = wrapper.PublicGetTimeZones(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}