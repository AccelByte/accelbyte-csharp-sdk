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
    [SdkConsoleCommand("legal","adminretrieveeligibilities")]
    public class AdminRetrieveEligibilitiesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "AdminRetrieveEligibilities"; } }

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

        public AdminRetrieveEligibilitiesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.AdminUserEligibilities wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.AdminUserEligibilities(_SDK);

            AdminRetrieveEligibilities operation = new AdminRetrieveEligibilities(
                Namespace,                
                UserId,                
                PublisherUserId,                
                ClientId,                
                CountryCode                
            );            

            AccelByte.Sdk.Api.Legal.Model.RetrieveUserEligibilitiesIndirectResponse? response = wrapper.AdminRetrieveEligibilities(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}