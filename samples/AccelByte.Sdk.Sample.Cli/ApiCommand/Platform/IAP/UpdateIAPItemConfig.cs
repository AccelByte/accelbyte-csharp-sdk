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
    [SdkConsoleCommand("platform","updateiapitemconfig")]
    public class UpdateIAPItemConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateIAPItemConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public IAPItemConfigUpdate Body { get; set; } = new IAPItemConfigUpdate();
                
        public UpdateIAPItemConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAP wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAP(_SDK);

            UpdateIAPItemConfig operation = new UpdateIAPItemConfig(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.IAPItemConfigInfo? response = wrapper.UpdateIAPItemConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}