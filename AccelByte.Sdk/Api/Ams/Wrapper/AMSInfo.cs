// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ams.Wrapper
{
    public class AMSInfo
    {
        private readonly AccelByteSDK _sdk;

        public AMSInfo(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public InfoRegions.InfoRegionsBuilder InfoRegionsOp
        {
            get { return Operation.InfoRegions.Builder.SetWrapperObject(this); }
        }
        public InfoSupportedInstances.InfoSupportedInstancesBuilder InfoSupportedInstancesOp
        {
            get { return Operation.InfoSupportedInstances.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApiAMSRegionsResponse? InfoRegions(InfoRegions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApiAvailableInstanceTypesResponse? InfoSupportedInstances(InfoSupportedInstances input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}