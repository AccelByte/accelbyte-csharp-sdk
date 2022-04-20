// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminChannel
    {
        private readonly AccelByteSDK _sdk;

        public AdminChannel(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public SingleAdminGetChannel.SingleAdminGetChannelBuilder SingleAdminGetChannelOp
        {
            get { return Operation.SingleAdminGetChannel.Builder.SetWrapperObject(this); }
        }
        public AdminCreateChannel.AdminCreateChannelBuilder AdminCreateChannelOp
        {
            get { return Operation.AdminCreateChannel.Builder.SetWrapperObject(this); }
        }
        public SingleAdminUpdateChannel.SingleAdminUpdateChannelBuilder SingleAdminUpdateChannelOp
        {
            get { return Operation.SingleAdminUpdateChannel.Builder.SetWrapperObject(this); }
        }
        public SingleAdminDeleteChannel.SingleAdminDeleteChannelBuilder SingleAdminDeleteChannelOp
        {
            get { return Operation.SingleAdminDeleteChannel.Builder.SetWrapperObject(this); }
        }
        public AdminGetChannel.AdminGetChannelBuilder AdminGetChannelOp
        {
            get { return Operation.AdminGetChannel.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateChannel.AdminUpdateChannelBuilder AdminUpdateChannelOp
        {
            get { return Operation.AdminUpdateChannel.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteChannel.AdminDeleteChannelBuilder AdminDeleteChannelOp
        {
            get { return Operation.AdminDeleteChannel.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedGetChannelResponse? SingleAdminGetChannel(SingleAdminGetChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelResponse? AdminCreateChannel(AdminCreateChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelResponse? SingleAdminUpdateChannel(SingleAdminUpdateChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SingleAdminDeleteChannel(SingleAdminDeleteChannel input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedGetChannelResponse? AdminGetChannel(AdminGetChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsChannelResponse? AdminUpdateChannel(AdminUpdateChannel input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteChannel(AdminDeleteChannel input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}