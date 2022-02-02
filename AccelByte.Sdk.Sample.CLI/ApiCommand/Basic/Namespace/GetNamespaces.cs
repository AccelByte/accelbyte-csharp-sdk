using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","getnamespaces")]
    public class GetNamespacesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "GetNamespaces"; } }

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        public GetNamespacesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Namespace wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Namespace(_SDK);

            GetNamespaces operation = new GetNamespaces(
                ActiveOnly                
            );            

            List<AccelByte.Sdk.Api.Basic.Model.NamespaceInfo>? response = wrapper.GetNamespaces(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}