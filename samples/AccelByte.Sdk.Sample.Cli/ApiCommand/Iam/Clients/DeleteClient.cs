// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("iam","deleteclient")]
    public class DeleteClientCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "DeleteClient"; } }

        [SdkCommandArgument("clientId")]
        public string ClientId { get; set; } = String.Empty;

        public DeleteClientCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Clients wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Clients(_SDK);

            #pragma warning disable ab_deprecated_operation
            DeleteClient operation = new DeleteClient(
                ClientId                
            );            
            #pragma warning restore ab_deprecated_operation
            
            #pragma warning disable ab_deprecated_operation_wrapper
            wrapper.DeleteClient(operation);
            return String.Empty;
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}