// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class AdminUserAgreement
    {
        private readonly AccelByteSDK _sdk;

        public AdminUserAgreement(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public IndirectBulkAcceptVersionedPolicy.IndirectBulkAcceptVersionedPolicyBuilder IndirectBulkAcceptVersionedPolicyOp
        {
            get { return Operation.IndirectBulkAcceptVersionedPolicy.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicy(IndirectBulkAcceptVersionedPolicy input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.AcceptAgreementResponse<T1>? IndirectBulkAcceptVersionedPolicy<T1>(IndirectBulkAcceptVersionedPolicy input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}