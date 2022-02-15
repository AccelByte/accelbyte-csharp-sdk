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
    [SdkConsoleCommand("iam","publicupdateuseremailaddressv4")]
    public class PublicUpdateUserEmailAddressV4Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicUpdateUserEmailAddressV4"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelEmailUpdateRequestV4 Body { get; set; } = new ModelEmailUpdateRequestV4();
                
        public PublicUpdateUserEmailAddressV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

            PublicUpdateUserEmailAddressV4 operation = new PublicUpdateUserEmailAddressV4(
                Namespace,                
                Body                
            );            
            
            wrapper.PublicUpdateUserEmailAddressV4(operation);
            return String.Empty;
        }
    }
}