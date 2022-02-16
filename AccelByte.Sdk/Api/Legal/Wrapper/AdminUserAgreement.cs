// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class AdminUserAgreement {
        private readonly AccelByteSDK _sdk;

        public AdminUserAgreement(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicy(IndirectBulkAcceptVersionedPolicy input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}