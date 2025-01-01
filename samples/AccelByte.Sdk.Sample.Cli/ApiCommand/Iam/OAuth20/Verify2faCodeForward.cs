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

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam", "verify2facodeforward")]
    public class Verify2faCodeForwardCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "Verify2faCodeForward"; } }

        [SdkCommandArgument("defaultFactor")]
        public string DefaultFactor { get; set; } = String.Empty;

        [SdkCommandArgument("factors")]
        public string Factors { get; set; } = String.Empty;

        [SdkCommandArgument("rememberDevice")]
        public bool RememberDevice { get; set; } = false;

        [SdkCommandArgument("clientId")]
        public string ClientId { get; set; } = String.Empty;

        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;

        [SdkCommandArgument("factor")]
        public string Factor { get; set; } = String.Empty;

        [SdkCommandArgument("mfaToken")]
        public string MfaToken { get; set; } = String.Empty;

        public Verify2faCodeForwardCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.Verify2faCodeForward.Builder;



            if (DefaultFactor != null)
                opBuilder.SetDefaultFactor((string)DefaultFactor);
            if (Factors != null)
                opBuilder.SetFactors((string)Factors);
            if (RememberDevice != null)
                opBuilder.SetRememberDevice((bool)RememberDevice);


            Verify2faCodeForward operation = opBuilder.Build(
                ClientId,
                Code,
                Factor,
                MfaToken
            );


            string? response = wrapper.Verify2faCodeForward(operation);
            if (response == null)
                return "No response from server.";
            return response!;
        }
    }
}