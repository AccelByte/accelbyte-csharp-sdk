using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc","getallpodconfig")]
    public class GetAllPodConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "GetAllPodConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("count")]
        public long? Count { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetAllPodConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.PodConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.PodConfig(_SDK);

            GetAllPodConfig operation = new GetAllPodConfig(
                Namespace,                
                Count,                
                Offset                
            );            

            AccelByte.Sdk.Api.Dsmc.Model.ModelsListPodConfigResponse? response = wrapper.GetAllPodConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}