using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","publicconsumeuserentitlement")]
    public class PublicConsumeUserEntitlementCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicConsumeUserEntitlement"; } }

        [SdkCommandArgument("entitlementId")]
        public string EntitlementId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public EntitlementDecrement Body { get; set; } = new EntitlementDecrement();
                
        public PublicConsumeUserEntitlementCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            PublicConsumeUserEntitlement operation = new PublicConsumeUserEntitlement(
                EntitlementId,                
                Namespace,                
                UserId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.EntitlementInfo? response = wrapper.PublicConsumeUserEntitlement(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}