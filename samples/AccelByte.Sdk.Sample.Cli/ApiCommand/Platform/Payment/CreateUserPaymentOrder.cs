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
    [SdkConsoleCommand("platform","createuserpaymentorder")]
    public class CreateUserPaymentOrderCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "CreateUserPaymentOrder"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public PaymentOrderCreate? Body { get; set; }
                
        public CreateUserPaymentOrderCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Payment wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Payment(_SDK);

            CreateUserPaymentOrder operation = new CreateUserPaymentOrder(
                Namespace,                
                UserId,                
                Body                
            );            

            AccelByte.Sdk.Api.Platform.Model.PaymentOrderInfo? response = wrapper.CreateUserPaymentOrder(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}