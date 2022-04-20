// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicLike
    {
        private readonly AccelByteSDK _sdk;

        public PublicLike(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetLikedContent.GetLikedContentBuilder GetLikedContentOp
        {
            get { return Operation.GetLikedContent.Builder.SetWrapperObject(this); }
        }
        public UpdateContentLikeStatus.UpdateContentLikeStatusBuilder UpdateContentLikeStatusOp
        {
            get { return Operation.UpdateContentLikeStatus.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedContentDownloadResponse? GetLikedContent(GetLikedContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsContentLikeResponse? UpdateContentLikeStatus(UpdateContentLikeStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}