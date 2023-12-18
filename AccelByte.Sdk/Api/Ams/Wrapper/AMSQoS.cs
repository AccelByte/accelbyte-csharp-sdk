// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ams.Wrapper
{
    public class AMSQoS
    {
        private readonly AccelByteSDK _sdk;

        public AMSQoS(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QoSRegionsGet.QoSRegionsGetBuilder QoSRegionsGetOp
        {
            get { return Operation.QoSRegionsGet.Builder.SetWrapperObject(this); }
        }
        public QoSRegionsUpdate.QoSRegionsUpdateBuilder QoSRegionsUpdateOp
        {
            get { return Operation.QoSRegionsUpdate.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ApiQoSEndpointResponse? QoSRegionsGet(QoSRegionsGet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void QoSRegionsUpdate(QoSRegionsUpdate input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}