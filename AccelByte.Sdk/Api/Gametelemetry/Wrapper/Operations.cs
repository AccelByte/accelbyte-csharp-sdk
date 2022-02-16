// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Gametelemetry.Wrapper
{
    public class Operations {
        private readonly AccelByteSDK _sdk;

        public Operations(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public void ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public long? ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet(ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet input) {
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