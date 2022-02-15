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
    [SdkConsoleCommand("platform","getticketdynamic")]
    public class GetTicketDynamicCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetTicketDynamic"; } }

        [SdkCommandArgument("boothName")]
        public string BoothName { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetTicketDynamicCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Ticket wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Ticket(_SDK);

            GetTicketDynamic operation = new GetTicketDynamic(
                BoothName,                
                Namespace                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.TicketDynamicInfo? response = wrapper.GetTicketDynamic(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}