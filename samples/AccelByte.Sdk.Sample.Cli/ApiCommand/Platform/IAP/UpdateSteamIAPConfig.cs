// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","updatesteamiapconfig")]
    public class UpdateSteamIAPConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateSteamIAPConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SteamIAPConfigRequest Body { get; set; } = new SteamIAPConfigRequest();
                
        public UpdateSteamIAPConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAP wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAP(_SDK);

            UpdateSteamIAPConfig operation = new UpdateSteamIAPConfig(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.SteamIAPConfigInfo? response = wrapper.UpdateSteamIAPConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}