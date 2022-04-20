// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class EventlogEvent_OpExts
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventResponse? Execute(
            this GetEventByNamespaceHandler.GetEventByNamespaceHandlerBuilder builder,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByNamespaceHandler op = builder.Build(
                namespace_,
                endDate,
                pageSize,
                startDate
            );

            return ((Eventlog.Wrapper.Event)builder.WrapperObject!).GetEventByNamespaceHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this PostEventHandler.PostEventHandlerBuilder builder,
            ModelsEvent body,
            string namespace_
        )
        {
            PostEventHandler op = builder.Build(
                body,
                namespace_
            );

            ((Eventlog.Wrapper.Event)builder.WrapperObject!).PostEventHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventResponse? Execute(
            this GetEventByEventIDHandler.GetEventByEventIDHandlerBuilder builder,
            double eventId,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByEventIDHandler op = builder.Build(
                eventId,
                namespace_,
                endDate,
                pageSize,
                startDate
            );

            return ((Eventlog.Wrapper.Event)builder.WrapperObject!).GetEventByEventIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventResponse? Execute(
            this GetEventByEventTypeHandler.GetEventByEventTypeHandlerBuilder builder,
            double eventType,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByEventTypeHandler op = builder.Build(
                eventType,
                namespace_,
                endDate,
                pageSize,
                startDate
            );

            return ((Eventlog.Wrapper.Event)builder.WrapperObject!).GetEventByEventTypeHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventResponse? Execute(
            this GetEventByEventTypeAndEventIDHandler.GetEventByEventTypeAndEventIDHandlerBuilder builder,
            double eventId,
            double eventType,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByEventTypeAndEventIDHandler op = builder.Build(
                eventId,
                eventType,
                namespace_,
                endDate,
                pageSize,
                startDate
            );

            return ((Eventlog.Wrapper.Event)builder.WrapperObject!).GetEventByEventTypeAndEventIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventResponse? Execute(
            this GetEventByUserIDHandler.GetEventByUserIDHandlerBuilder builder,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByUserIDHandler op = builder.Build(
                namespace_,
                userId,
                endDate,
                pageSize,
                startDate
            );

            return ((Eventlog.Wrapper.Event)builder.WrapperObject!).GetEventByUserIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventResponse? Execute(
            this GetEventByUserIDAndEventIDHandler.GetEventByUserIDAndEventIDHandlerBuilder builder,
            double eventId,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByUserIDAndEventIDHandler op = builder.Build(
                eventId,
                namespace_,
                userId,
                endDate,
                pageSize,
                startDate
            );

            return ((Eventlog.Wrapper.Event)builder.WrapperObject!).GetEventByUserIDAndEventIDHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventResponse? Execute(
            this GetEventByUserIDAndEventTypeHandler.GetEventByUserIDAndEventTypeHandlerBuilder builder,
            double eventType,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByUserIDAndEventTypeHandler op = builder.Build(
                eventType,
                namespace_,
                userId,
                endDate,
                pageSize,
                startDate
            );

            return ((Eventlog.Wrapper.Event)builder.WrapperObject!).GetEventByUserIDAndEventTypeHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsEventResponse? Execute(
            this GetEventByUserEventIDAndEventTypeHandler.GetEventByUserEventIDAndEventTypeHandlerBuilder builder,
            double eventId,
            double eventType,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            GetEventByUserEventIDAndEventTypeHandler op = builder.Build(
                eventId,
                eventType,
                namespace_,
                userId,
                endDate,
                pageSize,
                startDate
            );

            return ((Eventlog.Wrapper.Event)builder.WrapperObject!).GetEventByUserEventIDAndEventTypeHandler(op);
        }

    }
}