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
    [SdkConsoleCommand("platform","publiccreateuserorder")]
    public class PublicCreateUserOrderCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicCreateUserOrder"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public OrderCreate Body { get; set; } = new OrderCreate();
                
        public PublicCreateUserOrderCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Order wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Order(_SDK);

            PublicCreateUserOrder operation = new PublicCreateUserOrder(
                Namespace,                
                UserId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.OrderInfo? response = wrapper.PublicCreateUserOrder(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}