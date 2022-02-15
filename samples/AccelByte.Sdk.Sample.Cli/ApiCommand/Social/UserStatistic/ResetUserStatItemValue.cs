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
    [SdkConsoleCommand("social","resetuserstatitemvalue")]
    public class ResetUserStatItemValueCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "ResetUserStatItemValue"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("statCode")]
        public string StatCode { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("additionalKey")]
        public string? AdditionalKey { get; set; }

        [SdkCommandData("body")]
        public StatResetInfo Body { get; set; } = new StatResetInfo();
                
        public ResetUserStatItemValueCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            ResetUserStatItemValue operation = new ResetUserStatItemValue(
                Namespace,                
                StatCode,                
                UserId,                
                AdditionalKey,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Social.Model.StatItemIncResult? response = wrapper.ResetUserStatItemValue(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}