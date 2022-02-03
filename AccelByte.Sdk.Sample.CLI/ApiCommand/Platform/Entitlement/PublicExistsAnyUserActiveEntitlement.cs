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
    [SdkConsoleCommand("platform","publicexistsanyuseractiveentitlement")]
    public class PublicExistsAnyUserActiveEntitlementCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicExistsAnyUserActiveEntitlement"; } }

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

            PublicExistsAnyUserActiveEntitlement operation = new PublicExistsAnyUserActiveEntitlement(
                Namespace,                
                UserId,                
                AppIds,                
                ItemIds,                
                Skus                
            );            

            AccelByte.Sdk.Api.Platform.Model.Ownership? response = wrapper.PublicExistsAnyUserActiveEntitlement(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}