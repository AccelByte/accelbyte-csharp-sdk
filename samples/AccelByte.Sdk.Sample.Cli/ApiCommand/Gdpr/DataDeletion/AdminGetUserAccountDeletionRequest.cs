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
    [SdkConsoleCommand("gdpr","admingetuseraccountdeletionrequest")]
    public class AdminGetUserAccountDeletionRequestCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "AdminGetUserAccountDeletionRequest"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AdminGetUserAccountDeletionRequestCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletion wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataDeletion(_SDK);

            AdminGetUserAccountDeletionRequest operation = new AdminGetUserAccountDeletionRequest(
                Namespace,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Gdpr.Model.ModelsDeletionData? response = wrapper.AdminGetUserAccountDeletionRequest(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}