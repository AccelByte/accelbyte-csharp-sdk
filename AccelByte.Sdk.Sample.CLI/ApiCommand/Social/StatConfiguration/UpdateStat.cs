using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social","updatestat")]
    public class UpdateStatCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "UpdateStat"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("statCode")]
        public string StatCode { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public StatUpdate? Body { get; set; }
                
        public UpdateStatCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.StatConfiguration wrapper = new AccelByte.Sdk.Api.Social.Wrapper.StatConfiguration(_SDK);

            UpdateStat operation = new UpdateStat(
                Namespace,                
                StatCode,                
                Body                
            );            

            AccelByte.Sdk.Api.Social.Model.StatInfo? response = wrapper.UpdateStat(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}