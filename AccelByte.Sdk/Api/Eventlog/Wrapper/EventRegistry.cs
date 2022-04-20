// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Eventlog.Wrapper
{
    public class EventRegistry
    {
        private readonly AccelByteSDK _sdk;

        public EventRegistry(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetRegisteredEventsHandler.GetRegisteredEventsHandlerBuilder GetRegisteredEventsHandlerOp
        {
            get { return Operation.GetRegisteredEventsHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public RegisterEventHandler.RegisterEventHandlerBuilder RegisterEventHandlerOp
        {
            get { return Operation.RegisterEventHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetRegisteredEventIDHandler.GetRegisteredEventIDHandlerBuilder GetRegisteredEventIDHandlerOp
        {
            get { return Operation.GetRegisteredEventIDHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public UpdateEventRegistryHandler.UpdateEventRegistryHandlerBuilder UpdateEventRegistryHandlerOp
        {
            get { return Operation.UpdateEventRegistryHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public UnregisterEventIDHandler.UnregisterEventIDHandlerBuilder UnregisterEventIDHandlerOp
        {
            get { return Operation.UnregisterEventIDHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetRegisteredEventsByEventTypeHandler.GetRegisteredEventsByEventTypeHandlerBuilder GetRegisteredEventsByEventTypeHandlerOp
        {
            get { return Operation.GetRegisteredEventsByEventTypeHandler.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventRegistry? GetRegisteredEventsHandler(GetRegisteredEventsHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void RegisterEventHandler(RegisterEventHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventRegistry? GetRegisteredEventIDHandler(GetRegisteredEventIDHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void UpdateEventRegistryHandler(UpdateEventRegistryHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void UnregisterEventIDHandler(UnregisterEventIDHandler input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsEventRegistry? GetRegisteredEventsByEventTypeHandler(GetRegisteredEventsByEventTypeHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
    }

    public static class EventRegistry_OperationExtensions
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventRegistry? Execute(
            this GetRegisteredEventsHandler.GetRegisteredEventsHandlerBuilder builder
        )
        {
            GetRegisteredEventsHandler op = builder.Build(
            );

            return ((EventRegistry)builder.WrapperObject!).GetRegisteredEventsHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this RegisterEventHandler.RegisterEventHandlerBuilder builder,
            ModelsEventRegistry body
        )
        {
            RegisterEventHandler op = builder.Build(
                body
            );

            ((EventRegistry)builder.WrapperObject!).RegisterEventHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventRegistry? Execute(
            this GetRegisteredEventIDHandler.GetRegisteredEventIDHandlerBuilder builder,
            string eventId
        )
        {
            GetRegisteredEventIDHandler op = builder.Build(
                eventId
            );

            return ((EventRegistry)builder.WrapperObject!).GetRegisteredEventIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this UpdateEventRegistryHandler.UpdateEventRegistryHandlerBuilder builder,
            ModelsEventRegistry body,
            string eventId
        )
        {
            UpdateEventRegistryHandler op = builder.Build(
                body,
                eventId
            );

            ((EventRegistry)builder.WrapperObject!).UpdateEventRegistryHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this UnregisterEventIDHandler.UnregisterEventIDHandlerBuilder builder,
            string eventId
        )
        {
            UnregisterEventIDHandler op = builder.Build(
                eventId
            );

            ((EventRegistry)builder.WrapperObject!).UnregisterEventIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsEventRegistry? Execute(
            this GetRegisteredEventsByEventTypeHandler.GetRegisteredEventsByEventTypeHandlerBuilder builder,
            string eventType
        )
        {
            GetRegisteredEventsByEventTypeHandler op = builder.Build(
                eventType
            );

            return ((EventRegistry)builder.WrapperObject!).GetRegisteredEventsByEventTypeHandler(op);
        }

    }
}