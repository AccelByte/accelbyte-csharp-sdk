// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class AdminChannel {
        private readonly AccelByteSDK _sdk;

        public AdminChannel(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
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