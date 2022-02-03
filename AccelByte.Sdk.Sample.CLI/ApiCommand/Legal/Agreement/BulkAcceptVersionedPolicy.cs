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
    [SdkConsoleCommand("legal","bulkacceptversionedpolicy")]
    public class BulkAcceptVersionedPolicyCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "BulkAcceptVersionedPolicy"; } }

        [SdkCommandData("body")]
        public List<AcceptAgreementRequest>? Body { get; set; }
                
        public BulkAcceptVersionedPolicyCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Agreement wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Agreement(_SDK);

            BulkAcceptVersionedPolicy operation = new BulkAcceptVersionedPolicy(
                Body                
            );            

            AccelByte.Sdk.Api.Legal.Model.AcceptAgreementResponse? response = wrapper.BulkAcceptVersionedPolicy(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}