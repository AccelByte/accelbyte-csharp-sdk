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

using AccelByte.Sdk.Api.Sessionhistory.Wrapper;
using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionhistory
{
    [SdkConsoleCommand("sessionhistory", "querytotalmatchmakingexpired")]
    public class QueryTotalMatchmakingExpiredCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Sessionhistory"; } }

        public string OperationName { get { return "QueryTotalMatchmakingExpired"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("matchPool")]
        public string? MatchPool { get; set; }

        [SdkCommandArgument("endDate")]
        public string EndDate { get; set; } = String.Empty;

        [SdkCommandArgument("startDate")]
        public string StartDate { get; set; } = String.Empty;

        public QueryTotalMatchmakingExpiredCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionhistory.Wrapper.XRay wrapper = new AccelByte.Sdk.Api.Sessionhistory.Wrapper.XRay(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Sessionhistory.Operation.QueryTotalMatchmakingExpired.Builder;

            if (MatchPool != null)
                opBuilder.SetMatchPool((string)MatchPool);




            QueryTotalMatchmakingExpired operation = opBuilder.Build(
                Namespace,
                EndDate,
                StartDate
            );


            AccelByte.Sdk.Api.Sessionhistory.Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse? response = wrapper.QueryTotalMatchmakingExpired(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}