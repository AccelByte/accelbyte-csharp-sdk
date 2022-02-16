// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class SlotConfig {
        private readonly AccelByteSDK _sdk;

        public SlotConfig(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.NamespaceSlotConfigInfo? GetNamespaceSlotConfig(GetNamespaceSlotConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceSlotConfigInfo? UpdateNamespaceSlotConfig(UpdateNamespaceSlotConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteNamespaceSlotConfig(DeleteNamespaceSlotConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSlotConfigInfo? GetUserSlotConfig(GetUserSlotConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.UserSlotConfigInfo? UpdateUserSlotConfig(UpdateUserSlotConfig input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserSlotConfig(DeleteUserSlotConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}