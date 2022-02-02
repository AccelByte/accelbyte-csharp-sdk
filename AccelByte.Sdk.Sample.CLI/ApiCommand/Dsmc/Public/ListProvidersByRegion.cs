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
    [SdkConsoleCommand("dsmc","listprovidersbyregion")]
    public class ListProvidersByRegionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "ListProvidersByRegion"; } }

        [SdkCommandArgument("region")]
        public string Region { get; set; } = String.Empty;

        public ListProvidersByRegionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Public wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Public(_SDK);

            ListProvidersByRegion operation = new ListProvidersByRegion(
                Region                
            );            

            AccelByte.Sdk.Api.Dsmc.Model.ModelsDefaultProvider? response = wrapper.ListProvidersByRegion(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}