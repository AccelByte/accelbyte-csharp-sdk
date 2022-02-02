using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","upgradeheadlessaccountwithverificationcode")]
    public class UpgradeHeadlessAccountWithVerificationCodeCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "UpgradeHeadlessAccountWithVerificationCode"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelUpgradeHeadlessAccountWithVerificationCodeRequest? Body { get; set; }
                
        public UpgradeHeadlessAccountWithVerificationCodeCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            UpgradeHeadlessAccountWithVerificationCode operation = new UpgradeHeadlessAccountWithVerificationCode(
                Namespace,                
                UserId,                
                Body                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelUserResponse? response = wrapper.UpgradeHeadlessAccountWithVerificationCode(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}