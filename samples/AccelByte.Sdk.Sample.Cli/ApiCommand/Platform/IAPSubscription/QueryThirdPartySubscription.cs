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

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform", "querythirdpartysubscription")]
    public class QueryThirdPartySubscriptionCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "QueryThirdPartySubscription"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("groupId")]
        public string? GroupId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("platform")]
        public string? Platform { get; set; }

        [SdkCommandArgument("productId")]
        public string? ProductId { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public QueryThirdPartySubscriptionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAPSubscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAPSubscription(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryThirdPartySubscription.Builder;

            if (ActiveOnly != null)
                opBuilder.SetActiveOnly((bool)ActiveOnly);
            if (GroupId != null)
                opBuilder.SetGroupId((string)GroupId);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Platform != null)
                opBuilder.SetPlatform(QueryThirdPartySubscriptionPlatform.NewValue(Platform));
            if (ProductId != null)
                opBuilder.SetProductId((string)ProductId);
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            QueryThirdPartySubscription operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.ThirdPartyUserSubscriptionPagingSlicedResult? response = wrapper.QueryThirdPartySubscription(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}