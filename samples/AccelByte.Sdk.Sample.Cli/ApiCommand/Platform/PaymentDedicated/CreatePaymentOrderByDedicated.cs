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
    [SdkConsoleCommand("platform","createpaymentorderbydedicated")]
    public class CreatePaymentOrderByDedicatedCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "CreatePaymentOrderByDedicated"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ExternalPaymentOrderCreate Body { get; set; } = new ExternalPaymentOrderCreate();
                
        public CreatePaymentOrderByDedicatedCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentDedicated wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentDedicated(_SDK);

            CreatePaymentOrderByDedicated operation = new CreatePaymentOrderByDedicated(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.PaymentOrderCreateResult? response = wrapper.CreatePaymentOrderByDedicated(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}