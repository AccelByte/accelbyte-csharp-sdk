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

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social", "getuserstatcycleitems")]
    public class GetUserStatCycleItemsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "GetUserStatCycleItems"; } }

        [SdkCommandArgument("cycleId")]
        public string CycleId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("isPublic")]
        public bool? IsPublic { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("statCodes")]
        public string? StatCodes { get; set; }

        public GetUserStatCycleItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatisticCycle wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatisticCycle(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.GetUserStatCycleItems.Builder;

            if (IsPublic != null)
                opBuilder.SetIsPublic((bool)IsPublic);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy((string)SortBy);
            if (StatCodes != null)
                opBuilder.SetStatCodes((string)StatCodes);




            GetUserStatCycleItems operation = opBuilder.Build(
                CycleId,
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Social.Model.UserStatCycleItemPagingSlicedResult? response = wrapper.GetUserStatCycleItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}