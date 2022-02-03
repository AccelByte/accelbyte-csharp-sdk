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
    [SdkConsoleCommand("platform","publicdeletepaymentaccount")]
    public class PublicDeletePaymentAccountCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicDeletePaymentAccount"; } }

        [SdkCommandArgument("id")]
        public string Id { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("type")]
        public string Type { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public PublicDeletePaymentAccountCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentAccount wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentAccount(_SDK);

            PublicDeletePaymentAccount operation = new PublicDeletePaymentAccount(
                Id,                
                Namespace,                
                Type,                
                UserId                
            );            

            wrapper.PublicDeletePaymentAccount(operation);
            return String.Empty;
        }
    }
}