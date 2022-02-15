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
    [SdkConsoleCommand("dsmc","getdefaultprovider")]
    public class GetDefaultProviderCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "GetDefaultProvider"; } }

        public GetDefaultProviderCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Public wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Public(_SDK);

            GetDefaultProvider operation = new GetDefaultProvider(
            );            
            
            AccelByte.Sdk.Api.Dsmc.Model.ModelsDefaultProvider? response = wrapper.GetDefaultProvider(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}