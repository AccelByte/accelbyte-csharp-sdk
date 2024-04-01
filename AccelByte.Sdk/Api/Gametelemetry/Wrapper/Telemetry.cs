// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Gametelemetry.Wrapper
{
    public class Telemetry
    {
        private readonly AccelByteSDK _sdk;

        public Telemetry(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetNamespacesGameTelemetryV1AdminNamespacesGet.GetNamespacesGameTelemetryV1AdminNamespacesGetBuilder GetNamespacesGameTelemetryV1AdminNamespacesGetOp
        {
            get { return Operation.GetNamespacesGameTelemetryV1AdminNamespacesGet.Builder.SetWrapperObject(this); }
        }
        public GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetBuilder GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetOp
        {
            get { return Operation.GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ListBaseResponseStr? GetNamespacesGameTelemetryV1AdminNamespacesGet(GetNamespacesGameTelemetryV1AdminNamespacesGet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ListBaseResponseStr?> GetNamespacesGameTelemetryV1AdminNamespacesGetAsync(GetNamespacesGameTelemetryV1AdminNamespacesGet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PagedResponseGetNamespaceEventResponse? GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet(GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.PagedResponseGetNamespaceEventResponse?> GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGetAsync(GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}