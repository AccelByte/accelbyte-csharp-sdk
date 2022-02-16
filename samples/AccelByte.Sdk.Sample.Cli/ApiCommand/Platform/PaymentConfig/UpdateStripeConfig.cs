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
    [SdkConsoleCommand("platform","updatestripeconfig")]
    public class UpdateStripeConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateStripeConfig"; } }

        [SdkCommandArgument("id")]
        public string Id { get; set; } = String.Empty;

        [SdkCommandArgument("sandbox")]
        public bool? Sandbox { get; set; }

        [SdkCommandArgument("validate")]
        public bool? Validate { get; set; }

        [SdkCommandData("body")]
        public StripeConfig Body { get; set; } = new StripeConfig();
                
        public UpdateStripeConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            UpdateStripeConfig operation = new UpdateStripeConfig(
                Id,                
                Sandbox,                
                Validate,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.PaymentMerchantConfigInfo? response = wrapper.UpdateStripeConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}