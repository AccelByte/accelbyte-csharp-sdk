using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","publicupgradeheadlessaccountwithverificationcodev4")]
    public class PublicUpgradeHeadlessAccountWithVerificationCodeV4Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicUpgradeHeadlessAccountWithVerificationCodeV4"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4 Body { get; set; } = new AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4();
                
        public PublicUpgradeHeadlessAccountWithVerificationCodeV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

            PublicUpgradeHeadlessAccountWithVerificationCodeV4 operation = new PublicUpgradeHeadlessAccountWithVerificationCodeV4(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.AccountUserResponseV4? response = wrapper.PublicUpgradeHeadlessAccountWithVerificationCodeV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}