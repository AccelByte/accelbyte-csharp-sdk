using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser","gettotalactivesession")]
    public class GetTotalActiveSessionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Sessionbrowser"; } }

        public string OperationName{ get { return "GetTotalActiveSession"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sessionType")]
        public string? SessionType { get; set; }

        public GetTotalActiveSessionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            GetTotalActiveSession operation = new GetTotalActiveSession(
                Namespace,                
                SessionType                
            );            

            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsCountActiveSessionResponse? response = wrapper.GetTotalActiveSession(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}