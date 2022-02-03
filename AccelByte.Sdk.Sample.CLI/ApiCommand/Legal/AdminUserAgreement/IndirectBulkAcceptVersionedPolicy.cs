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
    [SdkConsoleCommand("legal","indirectbulkacceptversionedpolicy")]
    public class IndirectBulkAcceptVersionedPolicyCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "IndirectBulkAcceptVersionedPolicy"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("publisherUserId")]
        public string? PublisherUserId { get; set; }

        [SdkCommandArgument("clientId")]
        public string ClientId { get; set; }

        [SdkCommandArgument("countryCode")]
        public string CountryCode { get; set; }

        [SdkCommandData("body")]
        public List<AcceptAgreementRequest>? Body { get; set; }
                
        public IndirectBulkAcceptVersionedPolicyCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.AdminUserAgreement wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.AdminUserAgreement(_SDK);

            IndirectBulkAcceptVersionedPolicy operation = new IndirectBulkAcceptVersionedPolicy(
                Namespace,                
                UserId,                
                PublisherUserId,                
                ClientId,                
                CountryCode,                
                Body                
            );            

            AccelByte.Sdk.Api.Legal.Model.AcceptAgreementResponse? response = wrapper.IndirectBulkAcceptVersionedPolicy(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}