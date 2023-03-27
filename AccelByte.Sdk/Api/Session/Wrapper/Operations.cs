// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class Operations
    {
        private readonly AccelByteSDK _sdk;

        public Operations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetHealthcheckInfo.GetHealthcheckInfoBuilder GetHealthcheckInfoOp
        {
            get { return Operation.GetHealthcheckInfo.Builder.SetWrapperObject(this); }
        }
        public GetHealthcheckInfoV1.GetHealthcheckInfoV1Builder GetHealthcheckInfoV1Op
        {
            get { return Operation.GetHealthcheckInfoV1.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void GetHealthcheckInfo(GetHealthcheckInfo input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void GetHealthcheckInfoV1(GetHealthcheckInfoV1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}