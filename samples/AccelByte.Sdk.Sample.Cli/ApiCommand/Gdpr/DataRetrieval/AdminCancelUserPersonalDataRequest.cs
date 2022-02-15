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
    [SdkConsoleCommand("gdpr","admincanceluserpersonaldatarequest")]
    public class AdminCancelUserPersonalDataRequestCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "AdminCancelUserPersonalDataRequest"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("requestDate")]
        public string RequestDate { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AdminCancelUserPersonalDataRequestCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval(_SDK);

            AdminCancelUserPersonalDataRequest operation = new AdminCancelUserPersonalDataRequest(
                Namespace,                
                RequestDate,                
                UserId                
            );            
            
            wrapper.AdminCancelUserPersonalDataRequest(operation);
            return String.Empty;
        }
    }
}