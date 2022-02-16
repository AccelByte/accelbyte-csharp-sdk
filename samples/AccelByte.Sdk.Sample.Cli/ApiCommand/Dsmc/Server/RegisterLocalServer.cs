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
    [SdkConsoleCommand("dsmc","registerlocalserver")]
    public class RegisterLocalServerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "RegisterLocalServer"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsRegisterLocalServerRequest Body { get; set; } = new ModelsRegisterLocalServerRequest();
                
        public RegisterLocalServerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Server wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Server(_SDK);

            RegisterLocalServer operation = new RegisterLocalServer(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Dsmc.Model.ModelsServer? response = wrapper.RegisterLocalServer(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}