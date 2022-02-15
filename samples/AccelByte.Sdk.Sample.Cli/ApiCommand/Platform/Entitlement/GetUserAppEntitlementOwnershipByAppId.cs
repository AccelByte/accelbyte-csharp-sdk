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
    [SdkConsoleCommand("platform","getuserappentitlementownershipbyappid")]
    public class GetUserAppEntitlementOwnershipByAppIdCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetUserAppEntitlementOwnershipByAppId"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("appId")]
        public string AppId { get; set; } = String.Empty;

        public GetUserAppEntitlementOwnershipByAppIdCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            GetUserAppEntitlementOwnershipByAppId operation = new GetUserAppEntitlementOwnershipByAppId(
                Namespace,                
                UserId,                
                AppId                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.Ownership? response = wrapper.GetUserAppEntitlementOwnershipByAppId(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}