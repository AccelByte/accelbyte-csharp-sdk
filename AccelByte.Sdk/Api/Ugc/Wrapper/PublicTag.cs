// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicTag
    {
        private readonly AccelByteSDK _sdk;

        public PublicTag(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetTag.GetTagBuilder GetTagOp
        {
            get { return Operation.GetTag.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedGetTagResponse? GetTag(GetTag input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class PublicTag_OperationExtensions
    {
        public static Model.ModelsPaginatedGetTagResponse? Execute(
            this GetTag.GetTagBuilder builder,
            string namespace_
        )
        {
            GetTag op = builder.Build(
                namespace_
            );

            return ((PublicTag)builder.WrapperObject!).GetTag(op);
        }

    }
}