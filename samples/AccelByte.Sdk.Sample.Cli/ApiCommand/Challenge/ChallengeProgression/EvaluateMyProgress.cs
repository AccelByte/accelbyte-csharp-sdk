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

using AccelByte.Sdk.Api.Challenge.Wrapper;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Challenge
{
    [SdkConsoleCommand("challenge", "evaluatemyprogress")]
    public class EvaluateMyProgressCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Challenge"; } }

        public string OperationName { get { return "EvaluateMyProgress"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public EvaluateMyProgressCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeProgression wrapper = new AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeProgression(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Challenge.Operation.EvaluateMyProgress.Builder;





            EvaluateMyProgress operation = opBuilder.Build(
                Namespace
            );


            wrapper.EvaluateMyProgress(operation);
            return String.Empty;
        }
    }
}