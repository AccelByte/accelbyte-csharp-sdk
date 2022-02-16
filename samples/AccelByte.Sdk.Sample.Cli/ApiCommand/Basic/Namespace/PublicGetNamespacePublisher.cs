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
    [SdkConsoleCommand("basic","publicgetnamespacepublisher")]
    public class PublicGetNamespacePublisherCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "PublicGetNamespacePublisher"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public PublicGetNamespacePublisherCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.Namespace wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.Namespace(_SDK);

            PublicGetNamespacePublisher operation = new PublicGetNamespacePublisher(
                Namespace                
            );            
            
            AccelByte.Sdk.Api.Basic.Model.NamespacePublisherInfo? response = wrapper.PublicGetNamespacePublisher(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}