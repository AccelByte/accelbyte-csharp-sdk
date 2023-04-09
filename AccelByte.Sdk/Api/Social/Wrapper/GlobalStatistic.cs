// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
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
        public GetGlobalStatItemByStatCode.GetGlobalStatItemByStatCodeBuilder GetGlobalStatItemByStatCodeOp
        {
            get { return Operation.GetGlobalStatItemByStatCode.Builder.SetWrapperObject(this); }
        }
        public GetGlobalStatItems1.GetGlobalStatItems1Builder GetGlobalStatItems1Op
        {
            get { return Operation.GetGlobalStatItems1.Builder.SetWrapperObject(this); }
        }
        public GetGlobalStatItemByStatCode1.GetGlobalStatItemByStatCode1Builder GetGlobalStatItemByStatCode1Op
        {
            get { return Operation.GetGlobalStatItemByStatCode1.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.GlobalStatItemPagingSlicedResult? GetGlobalStatItems(GetGlobalStatItems input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GlobalStatItemInfo? GetGlobalStatItemByStatCode(GetGlobalStatItemByStatCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GlobalStatItemPagingSlicedResult? GetGlobalStatItems1(GetGlobalStatItems1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.GlobalStatItemInfo? GetGlobalStatItemByStatCode1(GetGlobalStatItemByStatCode1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}