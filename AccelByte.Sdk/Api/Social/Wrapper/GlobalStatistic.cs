// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class GlobalStatistic
    {
        private readonly AccelByteSDK _sdk;

        public GlobalStatistic(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetGlobalStatItems.GetGlobalStatItemsBuilder GetGlobalStatItemsOp
        {
            get { return Operation.GetGlobalStatItems.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.GlobalStatItemPagingSlicedResult? GetGlobalStatItems(GetGlobalStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class GlobalStatistic_OperationExtensions
    {
        public static Model.GlobalStatItemPagingSlicedResult? Execute(
            this GetGlobalStatItems.GetGlobalStatItemsBuilder builder,
            string namespace_
        )
        {
            GetGlobalStatItems op = builder.Build(
                namespace_
            );

            return ((GlobalStatistic)builder.WrapperObject!).GetGlobalStatItems(op);
        }

    }
}