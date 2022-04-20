// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Matchmaking.Wrapper
{
    public class MatchmakingOperations
    {
        private readonly AccelByteSDK _sdk;

        public MatchmakingOperations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetHealthcheckInfo.GetHealthcheckInfoBuilder GetHealthcheckInfoOp
        {
            get { return Operation.GetHealthcheckInfo.Builder.SetWrapperObject(this); }
        }
        public HandlerV3Healthz.HandlerV3HealthzBuilder HandlerV3HealthzOp
        {
            get { return Operation.HandlerV3Healthz.Builder.SetWrapperObject(this); }
        }
        public PublicGetMessages.PublicGetMessagesBuilder PublicGetMessagesOp
        {
            get { return Operation.PublicGetMessages.Builder.SetWrapperObject(this); }
        }
        public VersionCheckHandler.VersionCheckHandlerBuilder VersionCheckHandlerOp
        {
            get { return Operation.VersionCheckHandler.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void GetHealthcheckInfo(GetHealthcheckInfo input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void HandlerV3Healthz(HandlerV3Healthz input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.LogAppMessageDeclaration>? PublicGetMessages(PublicGetMessages input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void VersionCheckHandler(VersionCheckHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}