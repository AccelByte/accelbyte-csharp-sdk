using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr","admingetlistpersonaldatarequest")]
    public class AdminGetListPersonalDataRequestCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "AdminGetListPersonalDataRequest"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("requestDate")]
        public string? RequestDate { get; set; }

        public AdminGetListPersonalDataRequestCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.DataRetrieval(_SDK);

            AdminGetListPersonalDataRequest operation = new AdminGetListPersonalDataRequest(
                Namespace,                
                Limit,                
                Offset,                
                RequestDate                
            );            

            AccelByte.Sdk.Api.Gdpr.Model.ModelsListPersonalDataResponse? response = wrapper.AdminGetListPersonalDataRequest(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}