// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Seasonpass.Wrapper
{
    public class Export
    {
        private readonly AccelByteSDK _sdk;

        public Export(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ExportSeason.ExportSeasonBuilder ExportSeasonOp
        {
            get { return Operation.ExportSeason.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Stream? ExportSeason(ExportSeason input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}