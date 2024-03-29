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

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass", "queryseasons")]
    public class QuerySeasonsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Seasonpass"; } }

        public string OperationName { get { return "QuerySeasons"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("status")]
        public List<string>? Status { get; set; }

        public QuerySeasonsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Season wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Season(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Seasonpass.Operation.QuerySeasons.Builder;

            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Status != null)
                opBuilder.SetStatus(QuerySeasonsStatus.NewValue(Status));




            QuerySeasons operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Seasonpass.Model.ListSeasonInfoPagingSlicedResult? response = wrapper.QuerySeasons(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}