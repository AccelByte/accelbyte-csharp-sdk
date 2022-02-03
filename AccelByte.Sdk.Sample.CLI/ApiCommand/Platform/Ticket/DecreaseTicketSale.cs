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
    [SdkConsoleCommand("platform","decreaseticketsale")]
    public class DecreaseTicketSaleCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "DecreaseTicketSale"; } }

        [SdkCommandArgument("boothName")]
        public string BoothName { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public TicketSaleDecrementRequest? Body { get; set; }
                
        public DecreaseTicketSaleCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Ticket wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Ticket(_SDK);

            DecreaseTicketSale operation = new DecreaseTicketSale(
                BoothName,                
                Namespace,                
                Body                
            );            

            wrapper.DecreaseTicketSale(operation);
            return String.Empty;
        }
    }
}