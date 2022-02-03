using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","retrieveacceptedagreements")]
    public class RetrieveAcceptedAgreementsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrieveAcceptedAgreements"; } }

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public RetrieveAcceptedAgreementsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Agreement wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Agreement(_SDK);

            RetrieveAcceptedAgreements operation = new RetrieveAcceptedAgreements(
                UserId                
            );            

            List<AccelByte.Sdk.Api.Legal.Model.RetrieveAcceptedAgreementResponse>? response = wrapper.RetrieveAcceptedAgreements(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}