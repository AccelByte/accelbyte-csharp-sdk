// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc","saveconfig")]
    public class SaveConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "SaveConfig"; } }

        [SdkCommandData("body")]
        public ModelsDSMConfigRecord Body { get; set; } = new ModelsDSMConfigRecord();
                
        public SaveConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Config(_SDK);

            #pragma warning disable ab_deprecated_operation
            SaveConfig operation = new SaveConfig(
                Body                
            );            
            #pragma warning restore ab_deprecated_operation
            
            #pragma warning disable ab_deprecated_operation_wrapper
            wrapper.SaveConfig(operation);
            return String.Empty;
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}