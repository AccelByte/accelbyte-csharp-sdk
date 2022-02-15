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
    [SdkConsoleCommand("iam","getclientsbynamespace")]
    public class GetClientsbyNamespaceCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "GetClientsbyNamespace"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetClientsbyNamespaceCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Clients wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Clients(_SDK);

            GetClientsbyNamespace operation = new GetClientsbyNamespace(
                Namespace                
            );            
            
            List<AccelByte.Sdk.Api.Iam.Model.ClientmodelClientResponse>? response = wrapper.GetClientsbyNamespace(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}