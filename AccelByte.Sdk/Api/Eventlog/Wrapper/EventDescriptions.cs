// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Eventlog.Wrapper
{
    public class EventDescriptions
    {
        private readonly AccelByteSDK _sdk;

        public EventDescriptions(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public AgentTypeDescriptionHandler.AgentTypeDescriptionHandlerBuilder AgentTypeDescriptionHandlerOp
        {
            get { return Operation.AgentTypeDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificAgentTypeDescriptionHandler.SpecificAgentTypeDescriptionHandlerBuilder SpecificAgentTypeDescriptionHandlerOp
        {
            get { return Operation.SpecificAgentTypeDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public EventIDDescriptionHandler.EventIDDescriptionHandlerBuilder EventIDDescriptionHandlerOp
        {
            get { return Operation.EventIDDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificEventIDDescriptionHandler.SpecificEventIDDescriptionHandlerBuilder SpecificEventIDDescriptionHandlerOp
        {
            get { return Operation.SpecificEventIDDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public EventLevelDescriptionHandler.EventLevelDescriptionHandlerBuilder EventLevelDescriptionHandlerOp
        {
            get { return Operation.EventLevelDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificEventLevelDescriptionHandler.SpecificEventLevelDescriptionHandlerBuilder SpecificEventLevelDescriptionHandlerOp
        {
            get { return Operation.SpecificEventLevelDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public EventTypeDescriptionHandler.EventTypeDescriptionHandlerBuilder EventTypeDescriptionHandlerOp
        {
            get { return Operation.EventTypeDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificEventTypeDescriptionHandler.SpecificEventTypeDescriptionHandlerBuilder SpecificEventTypeDescriptionHandlerOp
        {
            get { return Operation.SpecificEventTypeDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public UXNameDescriptionHandler.UXNameDescriptionHandlerBuilder UXNameDescriptionHandlerOp
        {
            get { return Operation.UXNameDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SpecificUXDescriptionHandler.SpecificUXDescriptionHandlerBuilder SpecificUXDescriptionHandlerOp
        {
            get { return Operation.SpecificUXDescriptionHandler.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleAgentType? AgentTypeDescriptionHandler(AgentTypeDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleAgentType? SpecificAgentTypeDescriptionHandler(SpecificAgentTypeDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventID? EventIDDescriptionHandler(EventIDDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventID? SpecificEventIDDescriptionHandler(SpecificEventIDDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventLevel? EventLevelDescriptionHandler(EventLevelDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventLevel? SpecificEventLevelDescriptionHandler(SpecificEventLevelDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventType? EventTypeDescriptionHandler(EventTypeDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleEventType? SpecificEventTypeDescriptionHandler(SpecificEventTypeDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleUX? UXNameDescriptionHandler(UXNameDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelsMultipleUX? SpecificUXDescriptionHandler(SpecificUXDescriptionHandler input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
    }

    public static class EventDescriptions_OperationExtensions
    {
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleAgentType? Execute(
            this AgentTypeDescriptionHandler.AgentTypeDescriptionHandlerBuilder builder
        )
        {
            AgentTypeDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).AgentTypeDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleAgentType? Execute(
            this SpecificAgentTypeDescriptionHandler.SpecificAgentTypeDescriptionHandlerBuilder builder
        )
        {
            SpecificAgentTypeDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).SpecificAgentTypeDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleEventID? Execute(
            this EventIDDescriptionHandler.EventIDDescriptionHandlerBuilder builder
        )
        {
            EventIDDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).EventIDDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleEventID? Execute(
            this SpecificEventIDDescriptionHandler.SpecificEventIDDescriptionHandlerBuilder builder
        )
        {
            SpecificEventIDDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).SpecificEventIDDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleEventLevel? Execute(
            this EventLevelDescriptionHandler.EventLevelDescriptionHandlerBuilder builder
        )
        {
            EventLevelDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).EventLevelDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleEventLevel? Execute(
            this SpecificEventLevelDescriptionHandler.SpecificEventLevelDescriptionHandlerBuilder builder
        )
        {
            SpecificEventLevelDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).SpecificEventLevelDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleEventType? Execute(
            this EventTypeDescriptionHandler.EventTypeDescriptionHandlerBuilder builder
        )
        {
            EventTypeDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).EventTypeDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleEventType? Execute(
            this SpecificEventTypeDescriptionHandler.SpecificEventTypeDescriptionHandlerBuilder builder
        )
        {
            SpecificEventTypeDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).SpecificEventTypeDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleUX? Execute(
            this UXNameDescriptionHandler.UXNameDescriptionHandlerBuilder builder
        )
        {
            UXNameDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).UXNameDescriptionHandler(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelsMultipleUX? Execute(
            this SpecificUXDescriptionHandler.SpecificUXDescriptionHandlerBuilder builder
        )
        {
            SpecificUXDescriptionHandler op = builder.Build(
            );

            return ((EventDescriptions)builder.WrapperObject!).SpecificUXDescriptionHandler(op);
        }

    }
}