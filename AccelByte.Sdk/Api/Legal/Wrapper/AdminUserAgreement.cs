// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicy(IndirectBulkAcceptVersionedPolicy input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class AdminUserAgreement_OperationExtensions
    {
        public static Model.AcceptAgreementResponse? Execute(
            this IndirectBulkAcceptVersionedPolicy.IndirectBulkAcceptVersionedPolicyBuilder builder,
            string namespace_,
            string userId,
            string clientId,
            string countryCode
        )
        {
            IndirectBulkAcceptVersionedPolicy op = builder.Build(
                namespace_,
                userId,
                clientId,
                countryCode
            );

            return ((AdminUserAgreement)builder.WrapperObject!).IndirectBulkAcceptVersionedPolicy(op);
        }

    }
}