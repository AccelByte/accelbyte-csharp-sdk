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
    [SdkConsoleCommand("platform","getuserorder")]
    public class GetUserOrderCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetUserOrder"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("orderNo")]
        public string OrderNo { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public GetUserOrderCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Order wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Order(_SDK);

            GetUserOrder operation = new GetUserOrder(
                Namespace,                
                OrderNo,                
                UserId                
            );            

            AccelByte.Sdk.Api.Platform.Model.OrderInfo? response = wrapper.GetUserOrder(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}