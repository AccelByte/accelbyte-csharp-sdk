// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicCreator
    {
        private readonly AccelByteSDK _sdk;

        public PublicCreator(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetCreator.GetCreatorBuilder GetCreatorOp
        {
            get { return Operation.GetCreator.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsCreatorOverviewResponse? GetCreator(GetCreator input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}