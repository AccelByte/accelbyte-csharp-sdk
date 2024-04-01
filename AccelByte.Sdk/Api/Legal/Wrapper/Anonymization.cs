// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Anonymization
    {
        private readonly AccelByteSDK _sdk;

        public Anonymization(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AnonymizeUserAgreement.AnonymizeUserAgreementBuilder AnonymizeUserAgreementOp
        {
            get { return Operation.AnonymizeUserAgreement.Builder.SetWrapperObject(this); }
        }
        #endregion

        public void AnonymizeUserAgreement(AnonymizeUserAgreement input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeUserAgreementAsync(AnonymizeUserAgreement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}