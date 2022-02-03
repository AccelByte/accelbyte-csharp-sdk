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
    [SdkConsoleCommand("platform","existsanyuseractiveentitlementbyitemids")]
    public class ExistsAnyUserActiveEntitlementByItemIdsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "ExistsAnyUserActiveEntitlementByItemIds"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("itemIds")]
        public List<string> ItemIds { get; set; }

        public ExistsAnyUserActiveEntitlementByItemIdsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            ExistsAnyUserActiveEntitlementByItemIds operation = new ExistsAnyUserActiveEntitlementByItemIds(
                Namespace,                
                UserId,                
                ItemIds                
            );            

            AccelByte.Sdk.Api.Platform.Model.Ownership? response = wrapper.ExistsAnyUserActiveEntitlementByItemIds(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}