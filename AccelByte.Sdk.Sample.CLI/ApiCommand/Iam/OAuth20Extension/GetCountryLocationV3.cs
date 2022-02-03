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
    [SdkConsoleCommand("iam","getcountrylocationv3")]
    public class GetCountryLocationV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "GetCountryLocationV3"; } }

        public GetCountryLocationV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension(_SDK);

            GetCountryLocationV3 operation = new GetCountryLocationV3(
            );            

            AccelByte.Sdk.Api.Iam.Model.OauthmodelCountryLocationResponse? response = wrapper.GetCountryLocationV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}