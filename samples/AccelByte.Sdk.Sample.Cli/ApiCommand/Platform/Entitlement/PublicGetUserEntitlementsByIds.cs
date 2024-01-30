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
    [SdkConsoleCommand("platform", "publicgetuserentitlementsbyids")]
    public class PublicGetUserEntitlementsByIdsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "PublicGetUserEntitlementsByIds"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("availablePlatformOnly")]
        public bool? AvailablePlatformOnly { get; set; }

        [SdkCommandArgument("ids")]
        public List<string>? Ids { get; set; }

        public PublicGetUserEntitlementsByIdsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicGetUserEntitlementsByIds.Builder;

            if (AvailablePlatformOnly != null)
                opBuilder.SetAvailablePlatformOnly((bool)AvailablePlatformOnly);
            if (Ids != null)
                opBuilder.SetIds((List<string>)Ids);




            PublicGetUserEntitlementsByIds operation = opBuilder.Build(
                Namespace,
                UserId
            );


            List<AccelByte.Sdk.Api.Platform.Model.EntitlementInfo>? response = wrapper.PublicGetUserEntitlementsByIds(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}