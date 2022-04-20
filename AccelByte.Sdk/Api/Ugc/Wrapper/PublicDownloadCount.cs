// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicDownloadCount
    {
        private readonly AccelByteSDK _sdk;

        public PublicDownloadCount(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AddDownloadCount.AddDownloadCountBuilder AddDownloadCountOp
        {
            get { return Operation.AddDownloadCount.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsAddDownloadCountResponse? AddDownloadCount(AddDownloadCount input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PublicDownloadCount_OperationExtensions
    {
        public static Model.ModelsAddDownloadCountResponse? Execute(
            this AddDownloadCount.AddDownloadCountBuilder builder,
            string contentId,
            string namespace_
        )
        {
            AddDownloadCount op = builder.Build(
                contentId,
                namespace_
            );

            return ((PublicDownloadCount)builder.WrapperObject!).AddDownloadCount(op);
        }

    }
}