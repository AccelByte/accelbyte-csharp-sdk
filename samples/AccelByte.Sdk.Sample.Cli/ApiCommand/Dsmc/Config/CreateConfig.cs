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
    [SdkConsoleCommand("dsmc","createconfig")]
    public class CreateConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "CreateConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreateDSMConfigRequest Body { get; set; } = new ModelsCreateDSMConfigRequest();
                
        public CreateConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Config(_SDK);

            CreateConfig operation = new CreateConfig(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Dsmc.Model.ModelsDSMConfigRecord? response = wrapper.CreateConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}