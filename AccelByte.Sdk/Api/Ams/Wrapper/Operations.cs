// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ams.Wrapper
{
    public class Operations
    {
        private readonly AccelByteSDK _sdk;

        public Operations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public Func1.Func1Builder Func1Op
        {
            get { return Operation.Func1.Builder.SetWrapperObject(this); }
        }
        public BasicHealthCheck.BasicHealthCheckBuilder BasicHealthCheckOp
        {
            get { return Operation.BasicHealthCheck.Builder.SetWrapperObject(this); }
        }
        #endregion

        public void Func1(Func1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void BasicHealthCheck(BasicHealthCheck input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}