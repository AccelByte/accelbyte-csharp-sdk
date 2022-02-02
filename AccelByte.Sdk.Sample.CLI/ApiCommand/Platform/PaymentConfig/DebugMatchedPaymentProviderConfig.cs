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
    [SdkConsoleCommand("platform","debugmatchedpaymentproviderconfig")]
    public class DebugMatchedPaymentProviderConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "DebugMatchedPaymentProviderConfig"; } }

        [SdkCommandArgument("namespace_")]
        public string? Namespace { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        public DebugMatchedPaymentProviderConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            DebugMatchedPaymentProviderConfig operation = new DebugMatchedPaymentProviderConfig(
                Namespace,                
                Region                
            );            

            AccelByte.Sdk.Api.Platform.Model.PaymentProviderConfigInfo? response = wrapper.DebugMatchedPaymentProviderConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}