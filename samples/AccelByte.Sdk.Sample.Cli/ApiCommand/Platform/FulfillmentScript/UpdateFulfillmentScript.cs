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
    [SdkConsoleCommand("platform","updatefulfillmentscript")]
    public class UpdateFulfillmentScriptCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateFulfillmentScript"; } }

        [SdkCommandArgument("id")]
        public string Id { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public FulfillmentScriptUpdate Body { get; set; } = new FulfillmentScriptUpdate();
                
        public UpdateFulfillmentScriptCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.FulfillmentScript wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.FulfillmentScript(_SDK);

            UpdateFulfillmentScript operation = new UpdateFulfillmentScript(
                Id,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.FulfillmentScriptInfo? response = wrapper.UpdateFulfillmentScript(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}