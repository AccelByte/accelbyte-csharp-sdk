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
    [SdkConsoleCommand("platform","publicgetmyappentitlementownershipbyappid")]
    public class PublicGetMyAppEntitlementOwnershipByAppIdCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicGetMyAppEntitlementOwnershipByAppId"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("appId")]
        public string AppId { get; set; }

        public PublicGetMyAppEntitlementOwnershipByAppIdCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            PublicGetMyAppEntitlementOwnershipByAppId operation = new PublicGetMyAppEntitlementOwnershipByAppId(
                Namespace,                
                AppId                
            );            

            AccelByte.Sdk.Api.Platform.Model.Ownership? response = wrapper.PublicGetMyAppEntitlementOwnershipByAppId(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}