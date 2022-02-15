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
    [SdkConsoleCommand("platform","publicgetmyentitlementownershipbyitemid")]
    public class PublicGetMyEntitlementOwnershipByItemIdCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicGetMyEntitlementOwnershipByItemId"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("entitlementClazz")]
        public string? EntitlementClazz { get; set; }

        [SdkCommandArgument("itemId")]
        public string ItemId { get; set; } = String.Empty;

        public PublicGetMyEntitlementOwnershipByItemIdCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            PublicGetMyEntitlementOwnershipByItemId operation = new PublicGetMyEntitlementOwnershipByItemId(
                Namespace,                
                EntitlementClazz,                
                ItemId                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.TimedOwnership? response = wrapper.PublicGetMyEntitlementOwnershipByItemId(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}