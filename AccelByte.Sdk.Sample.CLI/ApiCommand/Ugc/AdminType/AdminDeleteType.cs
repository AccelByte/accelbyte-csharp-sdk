using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","admindeletetype")]
    public class AdminDeleteTypeCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminDeleteType"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("typeId")]
        public string TypeId { get; set; } = String.Empty;

        public AdminDeleteTypeCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminType wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminType(_SDK);

            AdminDeleteType operation = new AdminDeleteType(
                Namespace,                
                TypeId                
            );            

            wrapper.AdminDeleteType(operation);
            return String.Empty;
        }
    }
}