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
    [SdkConsoleCommand("challenge", "getchallenges")]
    public class GetChallengesCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Challenge"; } }

        public string OperationName { get { return "GetChallenges"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public GetChallengesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeList wrapper = new AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeList(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Challenge.Operation.GetChallenges.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy((string)SortBy);
            if (Status != null)
                opBuilder.SetStatus(GetChallengesStatus.NewValue(Status));




            GetChallenges operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Challenge.Model.ModelListChallengeResponse? response = wrapper.GetChallenges(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}