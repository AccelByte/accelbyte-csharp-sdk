// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class EventlogEventRegistry_OpExts
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventRegistry? Execute(
            this GetRegisteredEventsHandler.GetRegisteredEventsHandlerBuilder builder
        )
        {
            GetRegisteredEventsHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventRegistry)builder.WrapperObject!).GetRegisteredEventsHandler(op);
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

            ((Eventlog.Wrapper.EventRegistry)builder.WrapperObject!).RegisterEventHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventRegistry? Execute(
            this GetRegisteredEventIDHandler.GetRegisteredEventIDHandlerBuilder builder,
            string eventId
        )
        {
            GetRegisteredEventIDHandler op = builder.Build(
                eventId
            );

            return ((Eventlog.Wrapper.EventRegistry)builder.WrapperObject!).GetRegisteredEventIDHandler(op);
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

            ((Eventlog.Wrapper.EventRegistry)builder.WrapperObject!).UpdateEventRegistryHandler(op);
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

            ((Eventlog.Wrapper.EventRegistry)builder.WrapperObject!).UnregisterEventIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventRegistry? Execute(
            this GetRegisteredEventsByEventTypeHandler.GetRegisteredEventsByEventTypeHandlerBuilder builder,
            string eventType
        )
        {
            GetRegisteredEventsByEventTypeHandler op = builder.Build(
                eventType
            );

            return ((Eventlog.Wrapper.EventRegistry)builder.WrapperObject!).GetRegisteredEventsByEventTypeHandler(op);
        }

    }
}