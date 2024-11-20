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
    [SdkConsoleCommand("platform", "queryuserentitlements")]
    public class QueryUserEntitlementsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "QueryUserEntitlements"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("appType")]
        public string? AppType { get; set; }

        [SdkCommandArgument("collectionId")]
        public string? CollectionId { get; set; }

        [SdkCommandArgument("entitlementClazz")]
        public string? EntitlementClazz { get; set; }

        [SdkCommandArgument("entitlementName")]
        public string? EntitlementName { get; set; }

        [SdkCommandArgument("features")]
        public List<string>? Features { get; set; }

        [SdkCommandArgument("fuzzyMatchName")]
        public bool? FuzzyMatchName { get; set; }

        [SdkCommandArgument("ignoreActiveDate")]
        public bool? IgnoreActiveDate { get; set; }

        [SdkCommandArgument("itemId")]
        public List<string>? ItemId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("origin")]
        public string? Origin { get; set; }

        public QueryUserEntitlementsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryUserEntitlements.Builder;

            if (ActiveOnly != null)
                opBuilder.SetActiveOnly((bool)ActiveOnly);
            if (AppType != null)
                opBuilder.SetAppType(QueryUserEntitlementsAppType.NewValue(AppType));
            if (CollectionId != null)
                opBuilder.SetCollectionId((string)CollectionId);
            if (EntitlementClazz != null)
                opBuilder.SetEntitlementClazz(QueryUserEntitlementsEntitlementClazz.NewValue(EntitlementClazz));
            if (EntitlementName != null)
                opBuilder.SetEntitlementName((string)EntitlementName);
            if (Features != null)
                opBuilder.SetFeatures((List<string>)Features);
            if (FuzzyMatchName != null)
                opBuilder.SetFuzzyMatchName((bool)FuzzyMatchName);
            if (IgnoreActiveDate != null)
                opBuilder.SetIgnoreActiveDate((bool)IgnoreActiveDate);
            if (ItemId != null)
                opBuilder.SetItemId((List<string>)ItemId);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Origin != null)
                opBuilder.SetOrigin(QueryUserEntitlementsOrigin.NewValue(Origin));




            QueryUserEntitlements operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Platform.Model.EntitlementPagingSlicedResult? response = wrapper.QueryUserEntitlements(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}