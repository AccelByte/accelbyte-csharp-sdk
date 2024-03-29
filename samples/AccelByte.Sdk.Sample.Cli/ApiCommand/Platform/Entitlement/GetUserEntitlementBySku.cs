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
    [SdkConsoleCommand("platform", "getuserentitlementbysku")]
    public class GetUserEntitlementBySkuCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "GetUserEntitlementBySku"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("entitlementClazz")]
        public string? EntitlementClazz { get; set; }

        [SdkCommandArgument("platform")]
        public string? Platform { get; set; }

        [SdkCommandArgument("sku")]
        public string Sku { get; set; } = String.Empty;

        public GetUserEntitlementBySkuCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetUserEntitlementBySku.Builder;

            if (ActiveOnly != null)
                opBuilder.SetActiveOnly((bool)ActiveOnly);
            if (EntitlementClazz != null)
                opBuilder.SetEntitlementClazz(GetUserEntitlementBySkuEntitlementClazz.NewValue(EntitlementClazz));
            if (Platform != null)
                opBuilder.SetPlatform((string)Platform);




            GetUserEntitlementBySku operation = opBuilder.Build(
                Namespace,
                UserId,
                Sku
            );


            AccelByte.Sdk.Api.Platform.Model.EntitlementInfo? response = wrapper.GetUserEntitlementBySku(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}