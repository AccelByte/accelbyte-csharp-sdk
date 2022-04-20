// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class EventlogEventDescriptions_OpExts
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleAgentType? Execute(
            this AgentTypeDescriptionHandler.AgentTypeDescriptionHandlerBuilder builder
        )
        {
            AgentTypeDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).AgentTypeDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleAgentType? Execute(
            this SpecificAgentTypeDescriptionHandler.SpecificAgentTypeDescriptionHandlerBuilder builder
        )
        {
            SpecificAgentTypeDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).SpecificAgentTypeDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleEventID? Execute(
            this EventIDDescriptionHandler.EventIDDescriptionHandlerBuilder builder
        )
        {
            EventIDDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).EventIDDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleEventID? Execute(
            this SpecificEventIDDescriptionHandler.SpecificEventIDDescriptionHandlerBuilder builder
        )
        {
            SpecificEventIDDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).SpecificEventIDDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleEventLevel? Execute(
            this EventLevelDescriptionHandler.EventLevelDescriptionHandlerBuilder builder
        )
        {
            EventLevelDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).EventLevelDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleEventLevel? Execute(
            this SpecificEventLevelDescriptionHandler.SpecificEventLevelDescriptionHandlerBuilder builder
        )
        {
            SpecificEventLevelDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).SpecificEventLevelDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleEventType? Execute(
            this EventTypeDescriptionHandler.EventTypeDescriptionHandlerBuilder builder
        )
        {
            EventTypeDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).EventTypeDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleEventType? Execute(
            this SpecificEventTypeDescriptionHandler.SpecificEventTypeDescriptionHandlerBuilder builder
        )
        {
            SpecificEventTypeDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).SpecificEventTypeDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleUX? Execute(
            this UXNameDescriptionHandler.UXNameDescriptionHandlerBuilder builder
        )
        {
            UXNameDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).UXNameDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Eventlog.Model.ModelsMultipleUX? Execute(
            this SpecificUXDescriptionHandler.SpecificUXDescriptionHandlerBuilder builder
        )
        {
            SpecificUXDescriptionHandler op = builder.Build(
            );

            return ((Eventlog.Wrapper.EventDescriptions)builder.WrapperObject!).SpecificUXDescriptionHandler(op);
        }

    }
}