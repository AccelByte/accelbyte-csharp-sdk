// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Eventlog.Wrapper
{
    public class EventV2
    {
        private readonly AccelByteSDK _sdk;

        public EventV2(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryEventStreamHandler.QueryEventStreamHandlerBuilder QueryEventStreamHandlerOp
        {
            get { return Operation.QueryEventStreamHandler.Builder.SetWrapperObject(this); }
        }
        public GetEventSpecificUserV2Handler.GetEventSpecificUserV2HandlerBuilder GetEventSpecificUserV2HandlerOp
        {
            get { return Operation.GetEventSpecificUserV2Handler.Builder.SetWrapperObject(this); }
        }
        public GetPublicEditHistory.GetPublicEditHistoryBuilder GetPublicEditHistoryOp
        {
            get { return Operation.GetPublicEditHistory.Builder.SetWrapperObject(this); }
        }
        public GetUserEventsV2Public.GetUserEventsV2PublicBuilder GetUserEventsV2PublicOp
        {
            get { return Operation.GetUserEventsV2Public.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsEventResponseV2? QueryEventStreamHandler(QueryEventStreamHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsEventResponseV2? GetEventSpecificUserV2Handler(GetEventSpecificUserV2Handler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsEventResponseV2? GetPublicEditHistory(GetPublicEditHistory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsEventResponseV2? GetUserEventsV2Public(GetUserEventsV2Public input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}