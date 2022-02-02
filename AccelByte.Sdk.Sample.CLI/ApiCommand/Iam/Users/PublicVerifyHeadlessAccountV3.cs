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
    [SdkConsoleCommand("iam","publicverifyheadlessaccountv3")]
    public class PublicVerifyHeadlessAccountV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicVerifyHeadlessAccountV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelUpgradeHeadlessAccountV3Request? Body { get; set; }
                
        public PublicVerifyHeadlessAccountV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            PublicVerifyHeadlessAccountV3 operation = new PublicVerifyHeadlessAccountV3(
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelUserResponseV3? response = wrapper.PublicVerifyHeadlessAccountV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}