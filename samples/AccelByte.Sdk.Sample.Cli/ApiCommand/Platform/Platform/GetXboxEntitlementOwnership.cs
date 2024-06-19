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
    [SdkConsoleCommand("platform", "getxboxentitlementownership")]
    public class GetXboxEntitlementOwnershipCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "GetXboxEntitlementOwnership"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("productSku")]
        public string ProductSku { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public XblEntitlementOwnershipRequest Body { get; set; } = new XblEntitlementOwnershipRequest();

        public GetXboxEntitlementOwnershipCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Platform wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Platform(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetXboxEntitlementOwnership.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.XblEntitlementOwnershipRequest)Body);



            GetXboxEntitlementOwnership operation = opBuilder.Build(
                Namespace,
                ProductSku
            );


            AccelByte.Sdk.Api.Platform.Model.PlatformOwnership? response = wrapper.GetXboxEntitlementOwnership(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}