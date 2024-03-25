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
    [SdkConsoleCommand("iam", "simultaneousloginv4")]
    public class SimultaneousLoginV4Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "SimultaneousLoginV4"; } }

        [SdkCommandArgument("codeChallenge")]
        public string? CodeChallenge { get; set; }

        [SdkCommandArgument("codeChallengeMethod")]
        public string? CodeChallengeMethod { get; set; }

        [SdkCommandArgument("simultaneousPlatform")]
        public string SimultaneousPlatform { get; set; } = String.Empty;

        [SdkCommandArgument("simultaneousTicket")]
        public string SimultaneousTicket { get; set; } = String.Empty;

        [SdkCommandArgument("nativePlatform")]
        public string NativePlatform { get; set; } = String.Empty;

        [SdkCommandArgument("nativePlatformTicket")]
        public string NativePlatformTicket { get; set; } = String.Empty;

        public SimultaneousLoginV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20V4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20V4(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.SimultaneousLoginV4.Builder;

            if (CodeChallenge != null)
                opBuilder.SetCodeChallenge((string)CodeChallenge);
            if (CodeChallengeMethod != null)
                opBuilder.SetCodeChallengeMethod(SimultaneousLoginV4CodeChallengeMethod.NewValue(CodeChallengeMethod));


            if (SimultaneousPlatform != null)
                opBuilder.SetSimultaneousPlatform((string)SimultaneousPlatform);
            if (SimultaneousTicket != null)
                opBuilder.SetSimultaneousTicket((string)SimultaneousTicket);


            SimultaneousLoginV4 operation = opBuilder.Build(
                NativePlatform,
                NativePlatformTicket
            );


            AccelByte.Sdk.Api.Iam.Model.OauthmodelTokenResponseV3? response = wrapper.SimultaneousLoginV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}