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
    [SdkConsoleCommand("platform","publicqueryuserentitlements")]
    public class PublicQueryUserEntitlementsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicQueryUserEntitlements"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("appType")]
        public string? AppType { get; set; }

        [SdkCommandArgument("entitlementClazz")]
        public string? EntitlementClazz { get; set; }

        [SdkCommandArgument("entitlementName")]
        public string? EntitlementName { get; set; }

        [SdkCommandArgument("itemId")]
        public List<string>? ItemId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        public PublicQueryUserEntitlementsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Entitlement wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Entitlement(_SDK);

            PublicQueryUserEntitlements operation = new PublicQueryUserEntitlements(
                Namespace,                
                UserId,                
                AppType,                
                EntitlementClazz,                
                EntitlementName,                
                ItemId,                
                Limit,                
                Offset                
            );            

            AccelByte.Sdk.Api.Platform.Model.EntitlementPagingSlicedResult? response = wrapper.PublicQueryUserEntitlements(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}