using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr","publicsubmituseraccountdeletionrequest")]
    public class PublicSubmitUserAccountDeletionRequestCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "PublicSubmitUserAccountDeletionRequest"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;
                    
        public PublicSubmitUserAccountDeletionRequestCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletion wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletion(_SDK);

            PublicSubmitUserAccountDeletionRequest operation = new PublicSubmitUserAccountDeletionRequest(
                Namespace,                
                UserId,                
                Password                
            );            
            
            AccelByte.Sdk.Api.Gdpr.Model.ModelsRequestDeleteResponse? response = wrapper.PublicSubmitUserAccountDeletionRequest(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}