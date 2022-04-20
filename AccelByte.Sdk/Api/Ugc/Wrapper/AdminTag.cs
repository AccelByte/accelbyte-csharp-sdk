// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminTag
    {
        private readonly AccelByteSDK _sdk;

        public AdminTag(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetTag.AdminGetTagBuilder AdminGetTagOp
        {
            get { return Operation.AdminGetTag.Builder.SetWrapperObject(this); }
        }
        public AdminCreateTag.AdminCreateTagBuilder AdminCreateTagOp
        {
            get { return Operation.AdminCreateTag.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateTag.AdminUpdateTagBuilder AdminUpdateTagOp
        {
            get { return Operation.AdminUpdateTag.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteTag.AdminDeleteTagBuilder AdminDeleteTagOp
        {
            get { return Operation.AdminDeleteTag.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedGetTagResponse? AdminGetTag(AdminGetTag input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateTagResponse? AdminCreateTag(AdminCreateTag input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCreateTagResponse? AdminUpdateTag(AdminUpdateTag input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteTag(AdminDeleteTag input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}