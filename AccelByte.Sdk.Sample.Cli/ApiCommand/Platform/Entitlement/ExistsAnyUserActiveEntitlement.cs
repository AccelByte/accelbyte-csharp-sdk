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
    [SdkConsoleCommand("platform","existsanyuseractiveentitlement")]
    public class ExistsAnyUserActiveEntitlementCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "ExistsAnyUserActiveEntitlement"; } }

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

        public ExistsAnyUserActiveEntitlementCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            ExistsAnyUserActiveEntitlement operation = new ExistsAnyUserActiveEntitlement(
                Namespace,                
                UserId,                
                AppIds,                
                ItemIds,                
                Skus                
            );            

            AccelByte.Sdk.Api.Platform.Model.Ownership? response = wrapper.ExistsAnyUserActiveEntitlement(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}