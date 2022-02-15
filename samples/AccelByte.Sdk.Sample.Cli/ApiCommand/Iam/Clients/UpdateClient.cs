using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","updateclient")]
    public class UpdateClientCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "UpdateClient"; } }

        [SdkCommandArgument("clientId")]
        public string ClientId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ClientmodelClientUpdateRequest Body { get; set; } = new ClientmodelClientUpdateRequest();
                
        public UpdateClientCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Clients wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Clients(_SDK);

            UpdateClient operation = new UpdateClient(
                ClientId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ClientmodelClientResponse? response = wrapper.UpdateClient(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}