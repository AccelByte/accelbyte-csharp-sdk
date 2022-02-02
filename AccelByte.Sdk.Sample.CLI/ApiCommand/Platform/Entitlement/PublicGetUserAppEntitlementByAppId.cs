using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","publicgetuserappentitlementbyappid")]
    public class PublicGetUserAppEntitlementByAppIdCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicGetUserAppEntitlementByAppId"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("appId")]
        public string AppId { get; set; }

        public PublicGetUserAppEntitlementByAppIdCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            PublicGetUserAppEntitlementByAppId operation = new PublicGetUserAppEntitlementByAppId(
                Namespace,                
                UserId,                
                AppId                
            );            

            AccelByte.Sdk.Api.Platform.Model.AppEntitlementInfo? response = wrapper.PublicGetUserAppEntitlementByAppId(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}