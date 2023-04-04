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
    [SdkConsoleCommand("platform", "publicexistsanyuseractiveentitlement")]
    public class PublicExistsAnyUserActiveEntitlementCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "PublicExistsAnyUserActiveEntitlement"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("appIds")]
        public List<string>? AppIds { get; set; }

        [SdkCommandArgument("itemIds")]
        public List<string>? ItemIds { get; set; }

        [SdkCommandArgument("skus")]
        public List<string>? Skus { get; set; }

        public PublicExistsAnyUserActiveEntitlementCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicExistsAnyUserActiveEntitlement.Builder;

            if (AppIds != null)
                opBuilder.SetAppIds((List<string>)AppIds);
            if (ItemIds != null)
                opBuilder.SetItemIds((List<string>)ItemIds);
            if (Skus != null)
                opBuilder.SetSkus((List<string>)Skus);




            PublicExistsAnyUserActiveEntitlement operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Platform.Model.Ownership? response = wrapper.PublicExistsAnyUserActiveEntitlement(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}