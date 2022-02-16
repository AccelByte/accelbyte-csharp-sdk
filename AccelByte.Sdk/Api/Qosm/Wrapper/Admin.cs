// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Qosm.Wrapper
{
    public class Admin {
        private readonly AccelByteSDK _sdk;

        public Admin(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public void DeleteServer(DeleteServer input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SetServerAlias(SetServerAlias input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}