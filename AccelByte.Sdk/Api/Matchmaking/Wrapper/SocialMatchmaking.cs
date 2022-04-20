// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Matchmaking.Wrapper
{
    public class SocialMatchmaking
    {
        private readonly AccelByteSDK _sdk;

        public SocialMatchmaking(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UpdatePlayTimeWeight.UpdatePlayTimeWeightBuilder UpdatePlayTimeWeightOp
        {
            get { return Operation.UpdatePlayTimeWeight.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsUpdatePlayerPlaytimeWeightResponse? UpdatePlayTimeWeight(UpdatePlayTimeWeight input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}