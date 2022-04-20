// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Gametelemetry.Wrapper
{
    public class GametelemetryOperations
    {
        private readonly AccelByteSDK _sdk;

        public GametelemetryOperations(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetEventsGameTelemetryV1AdminEventsGet.AdminGetEventsGameTelemetryV1AdminEventsGetBuilder AdminGetEventsGameTelemetryV1AdminEventsGetOp
        {
            get { return Operation.AdminGetEventsGameTelemetryV1AdminEventsGet.Builder.SetWrapperObject(this); }
        }
        public AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet.AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetBuilder AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetOp
        {
            get { return Operation.AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet.Builder.SetWrapperObject(this); }
        }
        public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostBuilder ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostOp
        {
            get { return Operation.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.Builder.SetWrapperObject(this); }
        }
        public ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGetBuilder ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGetOp
        {
            get { return Operation.ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.Builder.SetWrapperObject(this); }
        }
        public ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePutBuilder ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePutOp
        {
            get { return Operation.ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void AdminGetEventsGameTelemetryV1AdminEventsGet(AdminGetEventsGameTelemetryV1AdminEventsGet input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet(AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet(ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut(ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}