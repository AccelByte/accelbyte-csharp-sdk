// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","updatenamespace")]
    public class UpdateNamespaceCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "UpdateNamespace"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public NamespaceUpdate Body { get; set; } = new NamespaceUpdate();
                
        public UpdateNamespaceCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Namespace wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Namespace(_SDK);

            UpdateNamespace operation = new UpdateNamespace(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Basic.Model.NamespaceInfo? response = wrapper.UpdateNamespace(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}